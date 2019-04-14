using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine
{
    static class SceneManager
    {
        static public void UpdateAll(List<SceneObject> sceneobj,Graphics graph,Pen pen)
        {
            foreach (SceneObject obj in sceneobj)
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
                        FigureDrawing.MakeStickMan(graph, obj.X, obj.Y, obj.Scale_x, obj.Scale_y,pen);
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
        static public void AddSceneObject()
        {
           
        }
    }
}
