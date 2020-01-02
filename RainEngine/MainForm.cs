using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using RainEngine.Abstract;
using RainEngine.Entities;

namespace RainEngine
{
	public partial class MainForm : Form, IView
	{
		Graphics graph;

		private List<BL.Abstract.SceneObject> sceneObjects = new List<BL.Abstract.SceneObject>();

		public OpenFileDialog OpenFileDialog { get; set; }

		public SaveFileDialog SaveFileDialog { get; set; }

		public PropertyGrid PropertyGrid { get; set; }

		public ContextMenuStrip ContextMenuStrip { get; set; }

		public TextBox SearchTextBox { get; set; }

		public MainForm()
		{
			InitializeComponent();
			OpenFileDialog = openFileDialog1;
			SaveFileDialog = saveFileDialog1;
			PropertyGrid = propertyGrid1;
			ContextMenuStrip = contextMenuStrip1;
			SearchTextBox = searchObjectsBox;
			graph = pictureBox1.CreateGraphics();
		}
		
		public void UpdateScenabsData(List<BL.Abstract.SceneObject> scenabs, Bitmap[] scenabimgs)
		{
			listView1.Items.Clear();
			ImageList imageList = new ImageList();
			imageList.ImageSize = new Size(50, 50);
			Bitmap emptyImage = new Bitmap(50, 50);
			using (Graphics gr = Graphics.FromImage(emptyImage))
			{
				gr.Clear(Color.White);
			}

			foreach (Bitmap bm in scenabimgs)
			{
				imageList.Images.Add(bm);
			}
			listView1.LargeImageList = imageList;
			List<BL.Abstract.SceneObject> Objects = scenabs;

			for (int i = 0; i < Objects.Count; i++)
			{
				ListViewItem listViewItem = new ListViewItem(Objects[i].Name);
				listViewItem.ImageIndex = i;
				listViewItem.Tag = Objects[i];
				listView1.Items.Add(listViewItem);
			}
		}

		public void UpdateSceneObjectsData(List<BL.Abstract.SceneObject> SceneObjs)
		{
			listBox1.Items.Clear();

			foreach (BL.Abstract.SceneObject sceneObj in SceneObjs)
			{
				listBox1.Items.Add(sceneObj);
			}

			listBox1.DisplayMember = "Name";
		}

		public void ClearGraphics()
		{
			graph.Clear(Color.White);
		}

		public void ChangeCursor(Cursor cursor)
		{
			Cursor.Current = cursor;
		}

		public void SearchFilesForListViews()
		{
			sceneListView.Items.Clear();
			scriptListView.Items.Clear();

			var scriptsPath = ProjectSettings.Manifest.Root.Element("ScriptsPath").Value;
			var scenesPath = ProjectSettings.Manifest.Root.Element("ScenesPath").Value;

			string[] scripts = Directory.GetFiles(scriptsPath);
			string[] scenes = Directory.GetFiles(scenesPath);

			foreach (string file in scripts)
			{
				string fileName = file.Remove(0, file.LastIndexOf('\\') + 1);

				if (!fileName.Contains(".lua"))
				{
					continue;
				}

				var item = new ListViewItem();
				item.Text = fileName;
				item.ImageIndex = 0;

				scriptListView.Items.Add(item);
			}

			foreach (string file in scenes)
			{
				var item = new ListViewItem();

				item.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
				item.ImageIndex = 1;

				sceneListView.Items.Add(item);
			}
		}

		#region Переброс событий

		public event EventHandler<EventArgs> TabControlTabSwithed;
		protected virtual void OnTabSwitched(EventArgs e)
		{
			TabControlTabSwithed?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> DeleteClick;
		protected virtual void OnDeleteClick(EditorEventArgs e)
		{
			DeleteClick?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> DuplicateClick;
		protected virtual void OnDuplicateClick(EditorEventArgs e)
		{
			DuplicateClick?.Invoke(this, e);
		}

		public event EventHandler<MouseEventArgs> MouseUpRightClick;
		protected virtual void OnMouseUpRightClick (MouseEventArgs e)
		{
			MouseUpRightClick?.Invoke(this, e);
		}

		public event EventHandler<EventArgs> OpenProjectClick;
		protected virtual void OnOpenProjectClick (EventArgs e)
		{
			OpenProjectClick?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> MouseDownEvent;
		protected virtual void OnMouseDownEvent(EditorEventArgs e)
		{
			MouseDownEvent?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> MouseUpEvent;
		protected virtual void OnMouseUpEvent(EditorEventArgs e)
		{
			e.ListViewItemCollection = listView1.SelectedItems;
			MouseUpEvent?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> MouseMoveEvent;
		protected virtual void OnMouseMoveEvent(EditorEventArgs e)
		{
			MouseMoveEvent?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> PressedMouseMoveEvent;
		protected virtual void OnPressedMouseMoveEvent(EditorEventArgs e)
		{
			PressedMouseMoveEvent?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> ClearClick;
		protected virtual void OnClearClick(EditorEventArgs e)
		{
			ClearClick?.Invoke(this, e);
		}

		public event EventHandler<EventArgs> SaveToXMLClick;
		protected virtual void OnSaveToXMLClick(EventArgs e)
		{
			SaveToXMLClick?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> OpenFromXMLClick;
		protected virtual void OnLoadFromXMLClick(EditorEventArgs e)
		{
			OpenFromXMLClick?.Invoke(this, e);
		}

		public event EventHandler<SceneObjectListEventArgs> ListBoxSelectedIndexChanged;
		protected virtual void OnListBoxSelectedIndexChanged(SceneObjectListEventArgs e)
		{
			e.Graph = graph;
			ListBoxSelectedIndexChanged?.Invoke(this, e);
		}

		public event EventHandler<SceneObjectListEventArgs> ListViewSelectedIndexChanged;
		protected virtual void OnListViewSelectedIndexChanged(SceneObjectListEventArgs e)
		{
			ListViewSelectedIndexChanged?.Invoke(this, e);
		}

		public event EventHandler<EditorEventArgs> PropertyValueChanged;
		protected virtual void OnPropertyValueChangedEventArgs(EditorEventArgs e)
		{
			PropertyValueChanged?.Invoke(this, e);
		}
		#endregion
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			OnMouseDownEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count, graph));
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			OnMouseUpEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count, graph));
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (listView1.SelectedIndices.Count != 0)
				{
					OnPressedMouseMoveEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count, (BL.Abstract.SceneObject)listView1.SelectedItems[0].Tag, graph));
				}
				else
				{
					OnPressedMouseMoveEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count, (BL.Abstract.SceneObject)PropertyGrid.SelectedObject, graph));
				}
			}
			if (PropertyGrid.SelectedObject != null)
			{
				OnMouseMoveEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count, (BL.Abstract.SceneObject)PropertyGrid.SelectedObject, graph));
			}
		}
		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			OnClearClick(new EditorEventArgs(graph));
		}

		private void OpenFromXML_Click(object sender, EventArgs e)
		{
			OnLoadFromXMLClick(new EditorEventArgs(graph));
		}

		private void SaveToXML_Click(object sender, EventArgs e)
		{
			OnSaveToXMLClick(e);
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			OnListBoxSelectedIndexChanged(new SceneObjectListEventArgs(listBox1.SelectedIndex));
		}

		private void PropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			OnPropertyValueChangedEventArgs(new EditorEventArgs(graph));
		}

		private void ListView1_Leave(object sender, EventArgs e)
		{
			listView1.SelectedItems.Clear();
		}

		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			OnListViewSelectedIndexChanged(new SceneObjectListEventArgs(listView1.SelectedItems.Count));
		}

		private void OpenProjectButton_Click(object sender, EventArgs e)
		{
			OnOpenProjectClick(e);
		}

		private void Form_MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				OnMouseUpRightClick(e);
			}
			
		}

		private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OnDeleteClick(new EditorEventArgs(graph));
		}

		private void ДублироватьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OnDuplicateClick(new EditorEventArgs(graph));
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{

			SearchFilesForListViews();
			try
			{
				var projectName = ProjectSettings.Manifest.Root.Attribute("name").Value;
				var projectVersion = ProjectSettings.Manifest.Root.Attribute("version").Value;
				Text = "RainEngine - " + projectName + " " + projectVersion;
			}
			catch
			{
				MessageBox.Show("Произошла ошибка парсинга проекта. Возможно неверный формат файла.");
			}
		}

		private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
		{
			OnTabSwitched(e);
		}
	}
}
