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
    public class VectorObject : SceneObject
    {
        
        private Shapes shape;

        public enum Shapes
        {
            Circle,
            Square,
            StickMan,
            Arrow_Vertical,
            Arrow_Horizontal
        }

        private void ChangeUpLeftCorner()
        {
            if (scale_y < 0 && scale_x < 0)
            {
                upLeftCorner.X = x + scale_x;
                upLeftCorner.Y = y + scale_y;
            }
            else if (scale_y < 0 && scale_x > 0)
            {
                upLeftCorner.X = x;
                upLeftCorner.Y = y + scale_y;
            }
            else if (scale_y > 0 && scale_x < 0)
            {
                upLeftCorner.X = x + scale_x;
                upLeftCorner.Y = y;
            }
            else
            {
                upLeftCorner.X = x;
                upLeftCorner.Y = y;
            }
        }
        public VectorObject()
        {

        }
        public VectorObject(string name,int x, int y, int scale_x, int scale_y, Shapes shape)
        {
            this.name = name;
            this.shape = shape;
            this.x = x;
            this.y = y;
            this.scale_x = scale_x;
            this.scale_y = scale_y;
            ChangeUpLeftCorner();
        }
        public override void Create(Graphics graphics,Pen pen)
        {
            switch (shape)
            {
                case Shapes.Circle:
                    graphics.DrawEllipse(pen, X, Y, Scale_x, Scale_y);
                    break;
                case Shapes.Square:
                    graphics.DrawPolygon(pen, new Point[]
                        {
                            new Point(X,Y),
                            new Point(X+Scale_x,Y),
                            new Point(X+Scale_x,Y+Scale_y),
                            new Point(X,Y+Scale_y)

                        });
                    break;
                case Shapes.StickMan:
                    FigureDrawing.MakeStickMan(graphics, X, Y, Scale_x, Scale_y, pen);
                    break;
                case Shapes.Arrow_Horizontal:
                    FigureDrawing.MakeArrowHorizontal(graphics, X, Y, Scale_x, Scale_y, pen);
                    break;
                case Shapes.Arrow_Vertical:
                    FigureDrawing.MakeArrowVertical(graphics, X, Y, Scale_x, Scale_y, pen);
                    break;
            }
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
        public override int X
        {
            get { return x; }
            set
            {
                x = value;
                ChangeUpLeftCorner();
            }
        }
        [Browsable(true)]
        [Description("Y coordinate of object")]
        [DisplayName("Y")]
        [Category("Инспектор")]
        public override int Y
        {
            get { return y; }
            set
            {
                y = value;
                ChangeUpLeftCorner();
            }
        }

        [Browsable(true)]
        [Description("X scale of object")]
        [DisplayName("Scale_x")]
        [Category("Инспектор")]
        public override int Scale_x
        {
            get { return scale_x; }
            set
            {
                scale_x = value;
                ChangeUpLeftCorner();
            }
        }
        [Browsable(true)]
        [Description("Y scale of object")]
        [DisplayName("Scale_y")]
        [Category("Инспектор")]
        public override int Scale_y
        {
            get { return scale_y; }
            set
            {
                scale_y = value;
                ChangeUpLeftCorner();
            }
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
            get {return upLeftCorner; }
        }

    }
}
