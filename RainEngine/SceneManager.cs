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
                        graph.DrawRectangle(pen, obj.X, obj.Y, obj.Scale_x, obj.Scale_y);
                        break;
                }
            }

        }
    }
}
