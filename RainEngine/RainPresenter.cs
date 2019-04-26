﻿using System;
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


        string[] scenabnames = new string[]
        {
            "Circle",
            "Square",
            "Stickman",
            "Arrow Vertical",
            "Arrow Horizontal",
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
            this.view.UpdateScenabsData(scenabnames, scenabimgs);
        }

        private void view_MouseDownEvent(object sender, MouseEventArgs e)
        {
            First_pos.X = e.X;
            First_pos.Y = e.Y;
            Current_pos.X = e.X;
            Current_pos.Y = e.Y;
        }
        private void view_MouseUpEvent(object sender, EditorEventArgs e)
        {
            SceneObject obj;
            if (e.IndeciesCount != 0)
            {
                obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, SceneObject.Shapes.Circle);
                switch (Convert.ToInt32(e.SelectedIndex))
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
                    case 3:
                        obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, SceneObject.Shapes.Arrow_Vertical);
                        break;
                    case 4:
                        obj = new SceneObject(First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, SceneObject.Shapes.Arrow_Horizontal);
                        break;
                }
                model.AddNewObject(obj);
            }
            model.UpdateGraphicsFromScene(e.Graph, ColourPen);
            view.UpdateSceneObjectsData(model.SceneObjectsNames);
        }
        private void view_MouseMoveEvent(object sender, EditorEventArgs e)
        {
            Current_pos.X = e.X;
            Current_pos.Y = e.Y;
            e.Graph.Clear(Color.White);           
            if (e.IndeciesCount != 0)
                switch (Convert.ToInt32(e.SelectedIndex))
                {
                    default:
                        e.Graph.DrawEllipse(ColourPen, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y);
                        break;
                    case 0:
                        e.Graph.DrawEllipse(ColourPen, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y);
                        break;
                    case 1:
                        e.Graph.DrawPolygon(ColourPen, new Point[]
                        {
                            new Point(First_pos.X,First_pos.Y),
                            new Point(Current_pos.X,First_pos.Y),
                            new Point(Current_pos.X,Current_pos.Y),
                            new Point(First_pos.X,Current_pos.Y)

                        });
                        break;
                    case 2:
                        FigureDrawing.MakeStickMan(e.Graph, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, ColourPen);
                        break;
                    case 3:
                        FigureDrawing.MakeArrowVertical(e.Graph, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, ColourPen);
                        break;
                    case 4:
                        FigureDrawing.MakeArrowHorizontal(e.Graph, First_pos.X, First_pos.Y, Current_pos.X - First_pos.X, Current_pos.Y - First_pos.Y, ColourPen);
                        break;
                }
            model.UpdateGraphicsFromScene(e.Graph, ColourPen);
        }
        private void view_ClearClick(object sender, EditorEventArgs e)
        {
            model.ClearObjects();
            e.Graph.Clear(Color.White);
            view.UpdateSceneObjectsData(model.SceneObjectsNames);
        }
    }
}
