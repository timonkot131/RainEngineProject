using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RainEngine.BL
{
    public class SceneObject
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
            Square,
            StickMan,
            Arrow_Vertical,
            Arrow_Horizontal
        }

        public SceneObject(int x, int y, int scale_x, int scale_y, Shapes shape)
        {
            this.shape = shape;
            this.x = x;
            this.y = y;
            this.scale_x = scale_x;
            this.scale_y = scale_y;
        }

        [Browsable(true)]
        [Description("Shape of object")]
        [DisplayName("Shape")]
        [Category("Инспектор")]
        public Shapes Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        [Browsable(true)]
        [Description("X coordinate of object")]
        [DisplayName("X")]
        [Category("Инспектор")]
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        [Browsable(true)]
        [Description("Y coordinate of object")]
        [DisplayName("Y")]
        [Category("Инспектор")]
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        [Browsable(true)]
        [Description("X scale of object")]
        [DisplayName("Scale_x")]
        [Category("Инспектор")]
        public int Scale_x
        {
            get { return scale_x; }
            set { scale_x = value; }
        }
        [Browsable(true)]
        [Description("Y scale of object")]
        [DisplayName("Scale_y")]
        [Category("Инспектор")]
        public int Scale_y
        {
            get { return scale_y; }
            set { scale_y = value; }
        }
        [Browsable(true)]
        [Description("Name of object")]
        [DisplayName("Name")]
        [Category("Инспектор")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
