using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.Abstract;
using RainEngine.Entities;
using RainEngine.BL;
using RainEngine.BL.Abstract;


namespace RainEngine
{
    class RainPresenter
    {
        Point First_pos;
        Point Current_pos;
        Pen ColourPen = new Pen(Color.Black, 3);


        List<SceneObject> scenabs = new List<SceneObject>()
        {
            new VectorObject("Circle",0,0,100,100,VectorObject.Shapes.Circle),
            new VectorObject("Square",0,0,100,100,VectorObject.Shapes.Square),
            new VectorObject("StickMan",0,0,100,100,VectorObject.Shapes.StickMan),
            new VectorObject("Arrow_Vertical",0,0,100,100,VectorObject.Shapes.Arrow_Vertical),
            new VectorObject("Arrow_Horizontal",0,0,100,100,VectorObject.Shapes.Arrow_Horizontal)
        };
        Bitmap[] scenabimgs = new Bitmap[]
        {
            new Bitmap("imgs/Circle.png"),
            new Bitmap("imgs/Square.png"),
            new Bitmap("imgs/StickMan.png"),
            new Bitmap("imgs/Arrow_Up.png"),
            new Bitmap("imgs/Arrow_Right.png"),
        };


        private IView view;
        private IScene model;
        public RainPresenter(IScene model,IView view)
        {
            this.model = model;
            this.view = view;
            this.view.MouseDownEvent += view_MouseDownEvent;
            this.view.MouseUpEvent += view_MouseUpEvent;
            this.view.MouseMoveEvent += view_MouseMoveEvent;
            this.view.ClearClick += view_ClearClick;
            this.view.OpenFromXMLClick += view_OpenFromXMLClick;
            this.view.SaveToXMLClick += view_SaveToXMLClick;
            this.view.SelectedIndexChanged += view_SelectedIndexChanged;
            this.view.PropertyValueChanged += view_PropertyValueChanged;
            this.view.UpdateScenabsData(scenabs, scenabimgs);
        }

        private void view_MouseDownEvent(object sender, EditorEventArgs e)
        {
            First_pos.X = e.X;
            First_pos.Y = e.Y;
            Current_pos.X = e.X;
            Current_pos.Y = e.Y;
            if (e.IndeciesCount == 0)
            {
                view.ClearGraphics();
                model.UpdateGraphicsFromScene(e.Graph, ColourPen);
                Func<SceneObject, bool> condition = (sceneobject) => (First_pos.X > sceneobject.UpLeftCorner.X && First_pos.X < (sceneobject.UpLeftCorner.X + Math.Abs(sceneobject.Scale_x)))
                && (First_pos.Y > sceneobject.UpLeftCorner.Y && First_pos.Y < (sceneobject.UpLeftCorner.Y + Math.Abs(sceneobject.Scale_y)));
                SceneObject obj = model.GetObjectsQuery(condition).LastOrDefault();
                if (obj != null)
                {
                    e.Graph.DrawPolygon(new Pen(Color.Green), new Point[]
                    {
                            new Point(obj.X,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y+obj.Scale_y),
                            new Point(obj.X,obj.Y+obj.Scale_y)
                    });
                    view.PropertyGrid.SelectedObject = obj;
                }
            }
        }
        private void view_MouseUpEvent(object sender, EditorEventArgs e)
        {
            e.SelectedObject.X = First_pos.X;
            e.SelectedObject.Y = First_pos.Y;
            if (e.SelectedObject is VectorObject)
            {
                VectorObject obj= (VectorObject)e.SelectedObject;
                model.AddNewObject(new VectorObject(obj.Name, obj.X, obj.Y, obj.Scale_x, obj.Scale_y, obj.Shape));
            }
            model.UpdateGraphicsFromScene(e.Graph, ColourPen);
            view.UpdateSceneObjectsData(model.SceneObjects);
        }
        private void view_MouseMoveEvent(object sender, EditorEventArgs e)
        {
            Current_pos.X = e.X;
            Current_pos.Y = e.Y;
            view.ClearGraphics();
            e.SelectedObject.X = First_pos.X;
            e.SelectedObject.Y = First_pos.Y;
            e.SelectedObject.Scale_x = Current_pos.X - First_pos.X;
            e.SelectedObject.Scale_y = Current_pos.Y - First_pos.Y;
            e.SelectedObject.Create(e.Graph, ColourPen);
            model.UpdateGraphicsFromScene(e.Graph, ColourPen);
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
            model.UpdateGraphicsFromScene(e.Graph, ColourPen);
            view.UpdateSceneObjectsData(model.SceneObjects);
        }

        private void view_SelectedIndexChanged(object sender, SceneObjectListEventArgs e)
        {
            view.ClearGraphics();
            model.UpdateGraphicsFromScene(e.Graph, ColourPen);
            SceneObject obj = model.GetSceneObject(e.Item);
            view.PropertyGrid.SelectedObject = obj;
            e.Graph.DrawPolygon(new Pen(Color.Green), new Point[]
                {
                            new Point(obj.X,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y+obj.Scale_y),
                            new Point(obj.X,obj.Y+obj.Scale_y)
            });  
        }
        private void view_PropertyValueChanged(object sender, EditorEventArgs e)
        {
            view.ClearGraphics();
            model.UpdateGraphicsFromScene(e.Graph, ColourPen);
            view.UpdateSceneObjectsData(model.SceneObjects);
        }
    }
}