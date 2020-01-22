using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using RainEngine.Abstract;
using RainEngine.Entities;
using RainEngine.InteractionFabrics;
using RainEngine.BL;
using RainEngine.BL.Abstract;
using RainEngine.BL.Components;
using System.Text.RegularExpressions;
using RainEngineGame;
public delegate void OnComplete(Component component, SceneObject sceneObject);

namespace RainEngine
{
	class RainPresenter
	{
		Point firstPos;
		Point currentPos;
		Pen colourPen = new Pen(Color.Black, 3);
		IMouseInteractionFactory mouseInteraction;

		IMouseInteractionFactory[] interactions = new IMouseInteractionFactory[]
		{
			new DefaultInter(),
			new SizeHorizontalInter(),
			new SizeVerticalInter(),
			new SizeDiagInter(),
			new TransformObjtInter(),
			new CreateObjInter()
		};

		List<SceneObject> scenabs = new List<SceneObject>();
		Bitmap emptyImage = new Bitmap(50, 50);

		Bitmap[] scenabimgs = new Bitmap[4];

		private IView view;
		private IScene model;
		public RainPresenter(IScene model, IView view)
		{
			this.model = model;
			this.view = view;
			this.view.MouseDownEvent += view_MouseDownEvent;
			this.view.MouseUpEvent += view_MouseUpEvent;
			this.view.MouseMoveEvent += view_MouseMoveEvent;
			this.view.PressedMouseMoveEvent += view_PressedMouseMoveEvent;
			this.view.ClearClick += view_ClearClick;
			this.view.OpenFromXMLClick += view_OpenFromXMLClick;
			this.view.SaveToXMLClick += view_SaveToXMLClick;
			this.view.ListBoxSelectedIndexChanged += view_ListBoxSelectedIndexChanged;
			this.view.ListViewSelectedIndexChanged += view_ListViewSelectedIndexChanged;
			this.view.PropertyValueChanged += view_PropertyValueChanged;
			this.view.OpenProjectClick += view_OpenProjectClick;
			this.view.MouseUpRightClick += view_MouseUpRightClick;
			this.view.DeleteClick += view_DeleteObjectClick;
			this.view.DuplicateClick += view_DuplicateObjectClick;
			this.view.SearchTextBox.TextChanged += view_SearchBoxTextChanged;
			this.view.TabControlTabSwithed += view_TabConrolTabSwitched;
			this.view.ComponentAddClick += view_ComponentAddClick;
			this.view.ComponentDeleteClick += view_ComponentDeleteClick;
			this.view.PropertyGrid.SelectedObjectsChanged += view_PropertyGridValueChanged;

		
			var circleBrush = new SceneObject("Circle", 0, 0, 100, 100);
			var circleDrawer = circleBrush.AttachComponent<Drawer>();
			circleDrawer.UseBrush = true;
			circleDrawer.Shape = Shapes.Circle;
			scenabs.Add(circleBrush);

			var squareBrush = new SceneObject("Square", 0, 0, 100, 100);
			var squareDrawer = squareBrush.AttachComponent<Drawer>();
			squareDrawer.UseBrush = true;
			squareDrawer.Shape = Shapes.Square;
			scenabs.Add(squareBrush);

			var arrowVerticalBrush = new SceneObject("Arrow_Vertical", 0, 0, 100, 100);
			var arrowVerticalDrawer = arrowVerticalBrush.AttachComponent<Drawer>();
			arrowVerticalDrawer.UseBrush = true;
			arrowVerticalDrawer.Shape = Shapes.Arrow_Vertical;
			scenabs.Add(arrowVerticalBrush);

			var arrowHorizontalBrush = new SceneObject("Arrow_Horizontal", 0, 0, 100, 100);
			var arrowHorizontalDrawer = arrowHorizontalBrush.AttachComponent<Drawer>();
			arrowHorizontalDrawer.UseBrush = true;
			arrowHorizontalDrawer.Shape = Shapes.Arrow_Horizontal;
			scenabs.Add(arrowHorizontalBrush);

			var stickmanBrush = new SceneObject("Stickman", 0, 0, 100, 100);
			var stickmanDrawer = stickmanBrush.AttachComponent<Drawer>();
			stickmanDrawer.UseBrush = true;
			stickmanDrawer.Shape = Shapes.StickMan;
			scenabs.Add(stickmanBrush);

			using (Graphics gr = Graphics.FromImage(emptyImage))
			{
				gr.Clear(Color.White);
			}

			for(int i = 0; i<scenabimgs.Length;i++)
			{
				scenabimgs[i]=emptyImage;
			}
			
			this.view.UpdateScenabsData(scenabs, scenabimgs);
			mouseInteraction = interactions[0];

			this.view.SceneBox.Scene = model;
		}

		private void view_PropertyGridValueChanged(object sender, EventArgs e)
		{
			Overlay.SelectedObject = view.PropertyGrid.SelectedObject as SceneObject;
		}
		private void view_MouseDownEvent(object sender, EditorEventArgs e)
		{
			firstPos.X = e.X;
			firstPos.Y = e.Y;
			currentPos.X = e.X;
			currentPos.Y = e.Y;
			if (e.IndeciesCount == 0)
			{
				if (mouseInteraction is DefaultInter)
				{
					view.SceneBox.Refresh();
					Func<SceneObject, bool> condition = (sceneobject) => (firstPos.X > sceneobject.X && firstPos.X < (sceneobject.X + sceneobject.ScaleX))
					&& (firstPos.Y > sceneobject.Y && firstPos.Y < (sceneobject.Y + sceneobject.ScaleY));
					SceneObject obj = model.GetObjectsQuery(condition).LastOrDefault();
					if (obj != null)
					{
						view.PropertyGrid.SelectedObject = obj;
					}
					else
					{
						view.PropertyGrid.SelectedObject = null;
					}
				}
			}
		}
		private void view_MouseUpEvent(object sender, EditorEventArgs e)
		{
			if (e.IndeciesCount != 0)
			{
				var sceneObject = e.ListViewItemCollection[0].Tag as SceneObject;
				sceneObject.X = firstPos.X;
				sceneObject.Y = firstPos.Y;
				var cloned = sceneObject.Clone() as SceneObject;
				cloned.Name = GetUnicalName(cloned.Name);

				model.AddNewObject(cloned);
				Overlay.DrawingObject = null;
			}
			else
			{
				mouseInteraction = interactions[0];
			}

			view.SceneBox.Refresh();
			view.UpdateSceneObjectsData(model.SceneObjects);
		}

		private string GetUnicalName(string firstPartName)
		{
			Regex regex = new Regex(@"\d+$");
			Regex regex1 = new Regex(@"^[a-zA-Z_]+");

			if (model.SceneObjects.Count == 0)
			{
				return firstPartName;
			}

			var isNotMatches = model.SceneObjects
				.Select(x => x.Name)
				.Where(x => regex1.Match(x).Value == firstPartName)
				.Count()
				.Equals(0);

			if (isNotMatches)
			{
				return firstPartName;
			}

			var matchedElems = model.SceneObjects
				.Select(x => x.Name)
				.Where(x => regex.Match(x).Success && regex1.Match(x).Value == firstPartName);

			long maxValueInScene = 0;

			if (matchedElems.Count() != 0)
			{
				maxValueInScene = matchedElems
					.Select(x => Convert.ToInt64(regex.Match(x).Value))
					.Max();
			}

			if(maxValueInScene == 0)
			{
				return firstPartName + 1;
			}

			maxValueInScene++;
			string result = firstPartName + maxValueInScene;
			return result;
		}

		private void view_MouseMoveEvent(object sender, EditorEventArgs e)
		{
			const int xOffset = 10;
			const int yOffset = 10;

			if (e.X >= e.SceneObject.X - xOffset && e.X <= e.SceneObject.X + xOffset
			&& e.Y >= e.SceneObject.Y - yOffset && e.Y <= e.SceneObject.Y + yOffset)
			{
				mouseInteraction = interactions[4];
				view.ChangeCursor(Cursors.SizeAll);
			}
			else if(e.X >= e.SceneObject.X + e.SceneObject.ScaleX - xOffset && e.X <= e.SceneObject.X + e.SceneObject.ScaleX + xOffset
			&& e.Y >= e.SceneObject.Y + e.SceneObject.ScaleY - yOffset && e.Y <= e.SceneObject.Y + e.SceneObject.ScaleY + yOffset)
			{
				mouseInteraction = interactions[3];
				view.ChangeCursor(Cursors.SizeNWSE);
			}
			else if(e.X >= e.SceneObject.X + e.SceneObject.ScaleX - xOffset && e.X <= e.SceneObject.X + e.SceneObject.ScaleX + xOffset
			&& e.Y >= e.SceneObject.Y - yOffset && e.Y <= e.SceneObject.Y + e.SceneObject.ScaleY + yOffset)
			{
				mouseInteraction = interactions[1];
				view.ChangeCursor(Cursors.SizeWE);
			}
			else if(e.Y >= e.SceneObject.Y + e.SceneObject.ScaleY - yOffset && e.Y <= e.SceneObject.Y + e.SceneObject.ScaleY + yOffset
			&& e.X >= e.SceneObject.X - xOffset && e.X <= e.SceneObject.X + e.SceneObject.ScaleX + xOffset)
			{
				mouseInteraction = interactions[2];
				view.ChangeCursor(Cursors.SizeNS);
			}
			else
			{
				mouseInteraction = interactions[0];
			}
		}
		private void view_PressedMouseMoveEvent(object sender, EditorEventArgs e)
		{
			view.SceneBox.Refresh();
			currentPos.X = e.X;
			currentPos.Y = e.Y;
			mouseInteraction.Interact(view, new Point(e.X, e.Y), e.SceneObject, firstPos);

			if(mouseInteraction is CreateObjInter)
			{
				Overlay.DrawingObject = e.SceneObject;
			}
			
			if (e.SceneObject != null)
			{
				Overlay.SelectedObject = e.SceneObject;
			}
		}
		private void view_ClearClick(object sender, EditorEventArgs e)
		{
			model.ClearObjects();
			view.PropertyGrid.SelectedObject = null;
			view.SceneBox.Refresh();
			view.UpdateSceneObjectsData(model.SceneObjects);
		}
		private void view_SaveToXMLClick(object sender, EventArgs e)
		{

			if (view.SaveFileDialog.ShowDialog() == DialogResult.Cancel)
				return;

			string filename = view.SaveFileDialog.FileName;
			model.SaveXmlFile(filename);
		}
		private void view_OpenFromXMLClick(object sender, EditorEventArgs e)
		{
			if (view.OpenFileDialog.ShowDialog() == DialogResult.Cancel)
				return;

			string filename = view.OpenFileDialog.FileName;
			model.ClearObjects();
			model.LoadXmlFile(filename);
			view.SceneBox.Refresh();
		}

		private void view_ListBoxSelectedIndexChanged(object sender, SceneObjectListEventArgs e)
		{
			view.SceneBox.Refresh();
			SceneObject obj = model.GetSceneObject(e.Item);
			view.PropertyGrid.SelectedObject = obj;
		}
		private void view_ListViewSelectedIndexChanged(object sender, SceneObjectListEventArgs e)
		{
			view.PropertyGrid.SelectedObject = null;
			if (e.Item != 0)
			{
				mouseInteraction = interactions[5];
				view.ChangeCursor(Cursors.Cross);
			}
			else
			{
				mouseInteraction = interactions[0];
				view.ChangeCursor(Cursors.Default);
			}
		}
		private void view_PropertyValueChanged(object sender, EditorEventArgs e)
		{
			view.SceneBox.Refresh();
			view.UpdateSceneObjectsData(model.SceneObjects);
		}

		private void view_OpenProjectClick(object sender, EventArgs e)
		{
			Form form = new RainEngineGame.GameForm();
		}

		private void view_MouseUpRightClick(object sender, MouseEventArgs e)
		{
			view.ContextMenuStrip.Show(e.Location);
		}

		private void view_DeleteObjectClick(object sender, EditorEventArgs e)
		{
			if(view.PropertyGrid.SelectedObject != null)
			{
				model.SceneObjects.Remove((SceneObject)view.PropertyGrid.SelectedObject);
				view.SceneBox.Refresh();
				view.UpdateSceneObjectsData(model.SceneObjects);
				view.PropertyGrid.SelectedObject = null;
			}
		}

		private void view_DuplicateObjectClick(object sender, EditorEventArgs e)
		{
		}

		private void view_SearchBoxTextChanged(object sender, EventArgs e)
		{
			var sceneObjects = model.SceneObjects.Where(x => x.Name.Contains(view.SearchTextBox.Text)).ToList();
			view.UpdateSceneObjectsData(sceneObjects);
		}

		private void view_TabConrolTabSwitched(object sender,EventArgs e)
		{
			view.SearchFilesForListViews();
		}

		private void view_ComponentAddClick(object sender, EventArgs e)
		{
			var form = new AddComponentForm(view.PropertyGrid.SelectedObject as SceneObject, OnAddComponentChoosed);
			form.Show();
		}

		private void view_ComponentDeleteClick(object sender, EventArgs e)
		{
			var form = new DeleteComponentForm(view.PropertyGrid.SelectedObject as SceneObject, OnDeleteComponentChoosed);
			form.Show();
		}

		private void OnAddComponentChoosed(Component choosedComponent, SceneObject target)
		{
			try
			{
				target.AttachComponent(choosedComponent);
			}
			catch(ArgumentException e)
			{
				MessageBox.Show("Вы не можете добавить этот компонент, так как он уже установлен на этот объект");
			}
		}

		private void OnDeleteComponentChoosed(Component choosedComponent, SceneObject target)
		{
			target.RemoveComponentByTypeOf(choosedComponent);
		}
	}
}