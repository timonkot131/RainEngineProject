using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine
{
    class Scene
    {
        private List<SceneObject> sceneObjects;

        public Scene()
        {
            sceneObjects = new List<SceneObject>();
        }

        public IEnumerable<string> SceneObjectsNames
        {
            get
            {
                var names = from scenobj in sceneObjects
                            select scenobj.Name;
                return names;
            }
        } 

        public void AddNewObject(SceneObject obj)
        {
            obj.Name = obj.Shape.ToString()+Postfix(obj);
            sceneObjects.Add(obj);
        }
        public void Clear()
        {
            sceneObjects.Clear();
        }
        public void UpdateGraphicsFromScene(Scene scene, Graphics graph, Pen pen)
        {
            foreach (SceneObject obj in sceneObjects)
            {
                switch (obj.Shape)
                {
                    case SceneObject.Shapes.Circle:
                        graph.DrawEllipse(pen, obj.X, obj.Y, obj.Scale_x, obj.Scale_y);
                        break;
                    case SceneObject.Shapes.Square:
                        graph.DrawPolygon(pen, new Point[]
                        {
                            new Point(obj.X,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y),
                            new Point(obj.X+obj.Scale_x,obj.Y+obj.Scale_y),
                            new Point(obj.X,obj.Y+obj.Scale_y)

                        });
                        break;
                    case SceneObject.Shapes.StickMan:
                        FigureDrawing.MakeStickMan(graph, obj.X, obj.Y, obj.Scale_x, obj.Scale_y, pen);
                        break;
                    case SceneObject.Shapes.Arrow_Vertical:
                        FigureDrawing.MakeArrowVertical(graph, obj.X, obj.Y, obj.Scale_x, obj.Scale_y, pen);
                        break;
                    case SceneObject.Shapes.Arrow_Horizontal:
                        FigureDrawing.MakeArrowHorizontal(graph, obj.X, obj.Y, obj.Scale_x, obj.Scale_y, pen);
                        break;
                }
            }
        }
        private string Postfix(SceneObject obj)
        {
        
            int query= sceneObjects.AsQueryable().Count(p => p.Shape == obj.Shape);
            if (query != 0)
                return "(" + query + ")";
            else return "";

        }
    }
}
