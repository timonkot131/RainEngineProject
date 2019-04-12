using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainEngine
{
    public partial class Form1 : Form
    {
        Graphics graph;

        Point First_pos;
        Point Current_pos;
        Pen ColourPen = new Pen(Color.Black, 3);
        List<SceneObject> sceneobjs = new List<SceneObject>();
        string[] scenabnames = new string[] { "circle", "square" };
        Bitmap[] scenabimgs = new Bitmap[] {new Bitmap("imgs/circle.png"),new Bitmap("imgs/square.png") };

        public Form1()
        {
            InitializeComponent();
            graph = pictureBox1.CreateGraphics();
            LoadListViewData();
        }

        private void LoadListViewData()
        {
            listView1.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50);
            Bitmap emptyImage = new Bitmap(50, 50);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }
            imageList.Images.Add(scenabimgs[0]);
            imageList.Images.Add(scenabimgs[1]);
            listView1.LargeImageList = imageList;
            string[] ObjectNames = scenabnames;
            for (int i = 0; i < ObjectNames.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem(ObjectNames[i]);
                listViewItem.ImageIndex = i;
                listView1.Items.Add(listViewItem);
            }
        } 

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            First_pos.X = e.X;
            First_pos.Y = e.Y;
            Current_pos.X = e.X;
            Current_pos.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SceneObject obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y,SceneObject.Shapes.Circle);
            sceneobjs.Add(obj);
            SceneManager.UpdateAll(sceneobjs,graph,ColourPen);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                Current_pos.X = e.X;
                Current_pos.Y = e.Y;
                graph.Clear(Color.White);
                graph.DrawEllipse(ColourPen, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y);
                SceneManager.UpdateAll(sceneobjs,graph,ColourPen);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
