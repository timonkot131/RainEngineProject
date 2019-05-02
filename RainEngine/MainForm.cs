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

        public void UpdateScenabsData(string[] scenabnames, Bitmap[] scenabimgs)
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
            string[] ObjectNames = scenabnames;
            for (int i = 0; i < ObjectNames.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem(ObjectNames[i]);
                listViewItem.ImageIndex = i;
                listView1.Items.Add(listViewItem);
            }
        }

        public void UpdateSceneObjectsData(IEnumerable<string> SceneObjectsNames)
        {
            listBox1.Items.Clear();
            foreach (string name in SceneObjectsNames)
            {
                listBox1.Items.Add(name);
            }
            //EditorEventArgs[] evs = new EditorEventArgs[] {new EditorEventArgs(3,4,5,graph), new EditorEventArgs(3, 4, 53, graph) };
            //for(int i = 0; i < evs.Length; i++)
            //{
            //    listBox1.Items.Add(evs[i]);
            //}
            //listBox1.DisplayMember = "IndeciesCount";
            //EditorEventArgs ev22 = (EditorEventArgs)listBox1.Items[1];
            //MessageBox.Show(Convert.ToString(ev22.IndeciesCount));
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
                OnMouseUpEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count, listView1.SelectedIndices[0],graph));         
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && listView1.SelectedIndices.Count!=0)            
                OnMouseMoveEvent(new EditorEventArgs(e.X,e.Y,listView1.SelectedIndices.Count,listView1.SelectedIndices[0],graph));                        
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
