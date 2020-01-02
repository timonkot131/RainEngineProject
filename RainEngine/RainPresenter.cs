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
using System.Text.RegularExpressions;
using RainEngineGame;


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

		List<SceneObject> scenabs = new List<SceneObject>()
		{
			new VectorObject("Circle",0,0,100,100,VectorObject.Shapes.Circle),
			new VectorObject("Square",0,0,100,100,VectorObject.Shapes.Square),
			new VectorObject("StickMan",0,0,100,100,VectorObject.Shapes.StickMan),
			new VectorObject("Arrow_Vertical",0,0,100,100,VectorObject.Shapes.Arrow_Vertical),
			new VectorObject("Arrow_Horizontal",0,0,100,100,VectorObject.Shapes.Arrow_Horizontal)
		};
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
					view.ClearGraphics();
					model.UpdateGraphicsFromScene(e.Graph, colourPen);
					Func<SceneObject, bool> condition = (sceneobject) => (firstPos.X > sceneobject.X && firstPos.X < (sceneobject.X + sceneobject.ScaleX))
					&& (firstPos.Y > sceneobject.Y && firstPos.Y < (sceneobject.Y + sceneobject.ScaleY));
					SceneObject obj = model.GetObjectsQuery(condition).LastOrDefault();
					if (obj != null)
					{
						DrawGreenSquare(obj,e.Graph);
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
				SceneObject sceneObject = (SceneObject)e.ListViewItemCollection[0].Tag;
				sceneObject.X = firstPos.X;
				sceneObject.Y = firstPos.Y;

				if (sceneObject is VectorObject)
				{
					VectorObject obj = (VectorObject)sceneObject;
					model.AddNewObject(new VectorObject(GetUnicalName(obj.Name), obj.X, obj.Y, obj.ScaleX, obj.ScaleY, obj.Shape));
				}
			}
			else
			{
				mouseInteraction = interactions[0];
			}

			model.UpdateGraphicsFromScene(e.Graph, colourPen);
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
			currentPos.X = e.X;
			currentPos.Y = e.Y;
			view.ClearGraphics();
			mouseInteraction.Interact(view, new Point(e.X, e.Y), e.SceneObject, firstPos);
			if(mouseInteraction is CreateObjInter)
			{
				e.SceneObject.Create(e.Graph, colourPen);
			}
			if (e.SceneObject != null)
			{
				DrawGreenSquare(e.SceneObject, e.Graph);
			}
			model.UpdateGraphicsFromScene(e.Graph, colourPen);
		}
		private void view_ClearClick(object sender, EditorEventArgs e)
		{
			model.ClearObjects();
			view.ClearGraphics();
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
			view.ClearGraphics();
			model.LoadXmlFile(filename);
			model.UpdateGraphicsFromScene(e.Graph, colourPen);
			view.UpdateSceneObjectsData(model.SceneObjects);
		}

		private void view_ListBoxSelectedIndexChanged(object sender, SceneObjectListEventArgs e)
		{
			view.ClearGraphics();
			model.UpdateGraphicsFromScene(e.Graph, colourPen);
			SceneObject obj = model.GetSceneObject(e.Item);
			view.PropertyGrid.SelectedObject = obj;
			e.Graph.DrawPolygon(new Pen(Color.Green), new Point[]
				{
							new Point(obj.X,obj.Y),
							new Point(obj.X+obj.ScaleX,obj.Y),
							new Point(obj.X+obj.ScaleX,obj.Y+obj.ScaleY),
							new Point(obj.X,obj.Y+obj.ScaleY)
			});
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
			view.ClearGraphics();
			model.UpdateGraphicsFromScene(e.Graph, colourPen);
			view.UpdateSceneObjectsData(model.SceneObjects);
		}
		private void DrawGreenSquare(SceneObject obj, Graphics graph)
		{
			graph.DrawPolygon(new Pen(Color.Green), new Point[]
						{
							new Point(obj.X,obj.Y),
							new Point(obj.X+obj.ScaleX,obj.Y),
							new Point(obj.X+obj.ScaleX,obj.Y+obj.ScaleY),
							new Point(obj.X,obj.Y+obj.ScaleY)
						});
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
				view.ClearGraphics();
				model.UpdateGraphicsFromScene(e.Graph, colourPen);
				view.UpdateSceneObjectsData(model.SceneObjects);
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
	}
}