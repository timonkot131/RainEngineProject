using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.Abstract;
using RainEngine.Entities;

namespace RainEngine
{
    public partial class MainForm : Form, IView
    {
        Graphics graph;

        public OpenFileDialog OpenFileDialog { get; set; }

        public SaveFileDialog SaveFileDialog { get; set; }

        public PropertyGrid PropertyGrid { get; set; }

        public MainForm()
        {
            InitializeComponent();
            OpenFileDialog = openFileDialog1;
            SaveFileDialog = saveFileDialog1;
            PropertyGrid = propertyGrid1;
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

        #region Переброс событий

        public event EventHandler<EditorEventArgs> MouseDownEvent;
        protected virtual void OnMouseDownEvent(EditorEventArgs e)
        {
            MouseDownEvent?.Invoke(this, e);
        }

        public event EventHandler<EditorEventArgs> MouseUpEvent;
        protected virtual void OnMouseUpEvent(EditorEventArgs e)
        {
            MouseUpEvent?.Invoke(this, e);
        }

        public event EventHandler<EditorEventArgs> MouseMoveEvent;
        protected virtual void OnMouseMoveEvent(EditorEventArgs e)
        {
            MouseMoveEvent?.Invoke(this, e);
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

        public event EventHandler<SceneObjectListEventArgs> SelectedIndexChanged;
        protected virtual void OnSelectedIndexChanged(SceneObjectListEventArgs e)
        {
            e.Graph = graph;
            SelectedIndexChanged?.Invoke(this, e);
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
            if (listView1.SelectedIndices.Count != 0)
                OnMouseUpEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count,(BL.Abstract.SceneObject)listView1.SelectedItems[0].Tag, graph));         
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && listView1.SelectedIndices.Count!=0)            
                OnMouseMoveEvent(new EditorEventArgs(e.X,e.Y,listView1.SelectedIndices.Count,(BL.Abstract.SceneObject)listView1.SelectedItems[0].Tag, graph));                        
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
            OnSelectedIndexChanged(new SceneObjectListEventArgs(listBox1.SelectedIndex));
        }

        private void PropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            OnPropertyValueChangedEventArgs(new EditorEventArgs(graph));
        }

        private void ListView1_Leave(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
        }
    }
}
