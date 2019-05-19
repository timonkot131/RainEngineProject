using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainEngine.BL.Abstract;

namespace RainEngine.BL
{
    [Serializable]
    public class EmptyObject:SceneObject
    {
        public EmptyObject()
        {

        }
        public override void Create(Graphics graphics,Pen pen)
        {

        }

        [Browsable(true)]
        [Description("X coordinate of object")]
        [DisplayName("X")]
        [Category("Инспектор")]
        public override int X
        {
            get { return x; }
            set { x = value; }
        }
        [Browsable(true)]
        [Description("Y coordinate of object")]
        [DisplayName("Y")]
        [Category("Инспектор")]
        public override int Y
        {
            get { return y; }
            set { y = value; }
        }

        [Browsable(true)]
        [Description("X scale of object")]
        [DisplayName("Scale_x")]
        [Category("Инспектор")]
        public override int Scale_x
        {
            get { return scale_x; }
            set { scale_x = value; }
        }
        [Browsable(true)]
        [Description("Y scale of object")]
        [DisplayName("Scale_y")]
        [Category("Инспектор")]
        public override int Scale_y
        {
            get { return scale_y; }
            set { scale_y = value; }
        }
        [Browsable(true)]
        [Description("Name of object")]
        [DisplayName("Name")]
        [Category("Инспектор")]
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        [Browsable(false)]
        public override Point UpLeftCorner
        {
            get { return new Point(X, Y); }
        }
    }
}
