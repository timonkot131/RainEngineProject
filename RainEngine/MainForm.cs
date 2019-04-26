﻿using System;
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

       // public event EventHandler<EventArgs> TransferMoney;

        public MainForm()
        {
            InitializeComponent();
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
        }
        #region Переброс событий
        public event EventHandler<MouseEventArgs> MouseDownEvent;
        protected virtual void OnMouseDownEvent(MouseEventArgs e)
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
        #endregion
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDownEvent(e);     
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUpEvent(new EditorEventArgs(e.X, e.Y, listView1.SelectedIndices.Count, listView1.SelectedIndices[0],graph));         
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                OnMouseMoveEvent(new EditorEventArgs(e.X,e.Y,listView1.SelectedIndices.Count,listView1.SelectedIndices[0],graph));              
            }
           
        }   

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OnClearClick(new EditorEventArgs(listView1.SelectedIndices.Count, listView1.SelectedIndices[0], graph));
        }       
    }
}