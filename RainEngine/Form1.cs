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
        string[] scenabnames = new string[]
        {
            "Circle",
            "Square",
            "Stickman",
            "Arrow Up",
            "Arrow Down",
            "Arrow Left",
            "Arrow Right"
        };
        Bitmap[] scenabimgs = new Bitmap[]
        {
            new Bitmap("imgs/Circle.png"),
            new Bitmap("imgs/Square.png"),
            new Bitmap("imgs/StickMan.png"),
            new Bitmap("imgs/Arrow_Up.png"),
            new Bitmap("imgs/Arrow_Down.png"),
            new Bitmap("imgs/Arrow_Left.png"),
            new Bitmap("imgs/Arrow_Right.png")
        };

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

        private void ClearAll()
        {
            sceneobjs.Clear();
            graph.Clear(Color.White);
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
            SceneObject obj;
            if (listView1.SelectedIndices.Count != 0)
            {
                obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, SceneObject.Shapes.Circle);
                switch (Convert.ToInt32(listView1.SelectedIndices[0]))
                {
                    case 0:
                        obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, SceneObject.Shapes.Circle);
                        break;
                    case 1:
                        obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, SceneObject.Shapes.Square);
                        break;
                    case 2:
                        obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, SceneObject.Shapes.StickMan);
                        break;
                }
                sceneobjs.Add(obj);
            }
            SceneManager.UpdateAll(sceneobjs, graph, ColourPen);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Current_pos.X = e.X;
                Current_pos.Y = e.Y;
                graph.Clear(Color.White);
                //graph.FillPolygon(new SolidBrush(Color.White), new Point[]
                //       {
                //            new Point(First_pos.X-((int)ColourPen.Width+5),First_pos.Y-((int)ColourPen.Width+5)),
                //            new Point(Current_pos.X+((int)ColourPen.Width+5),First_pos.Y-((int)ColourPen.Width+5)),
                //            new Point(Current_pos.X+((int)ColourPen.Width+5),Current_pos.Y+((int)ColourPen.Width+5)),
                //            new Point(First_pos.X-((int)ColourPen.Width+5),Current_pos.Y+((int)ColourPen.Width+5))

                //       });
                if (listView1.SelectedIndices.Count!=0)
                switch (Convert.ToInt32(listView1.SelectedIndices[0]))
                {
                    default:
                        graph.DrawEllipse(ColourPen, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y);
                        break;
                    case 0:
                        graph.DrawEllipse(ColourPen, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y);
                        break;
                    case 1:
                        graph.DrawPolygon(ColourPen, new Point[]
                        {
                            new Point(First_pos.X,First_pos.Y),
                            new Point(Current_pos.X,First_pos.Y),
                            new Point(Current_pos.X,Current_pos.Y),
                            new Point(First_pos.X,Current_pos.Y)

                        });
                        break;
                    case 2:
                            FigureDrawing.MakeStickMan(graph, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, ColourPen);
                        break;
                }
                SceneManager.UpdateAll(sceneobjs,graph,ColourPen);
            }
           
        }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
