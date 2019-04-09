using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine
{
    class SceneObject
    {
        private int x;
        private int y;
        private int scale_x;
        private int scale_y;
        private string name;
        private Shapes shape;

        public enum Shapes
        {
            Circle,
            Square
        }

        public SceneObject(int x,int y,int scale_x,int scale_y,Shapes shape)
        {
            this.shape = shape;
            this.x = x;
            this.y = y;
            this.scale_x = scale_x;
            this.scale_y = scale_y;
        }

        Shapes Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        int X
        {
            get { return x; }
            set { x = value; }
        }

        int Y
        {
            get { return y; }
            set { y = value; }
        }

        int Scale_x
        {
            get { return scale_x; }
            set { scale_x = value; }
        }

        int Scale_y
        {
            get { return scale_y; }
            set { scale_y = value; }
        }

        string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
