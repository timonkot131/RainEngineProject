using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainEngine.BL.Abstract;
using RainEngine.BL.Components;

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
			if (scaleY < 0 && scaleX < 0)
			{
				upLeftCorner.X = x + scaleX;
				upLeftCorner.Y = y + scaleY;
			}
			else if (scaleY < 0 && scaleX > 0)
			{
				upLeftCorner.X = x;
				upLeftCorner.Y = y + scaleY;
			}
			else if (scaleY > 0 && scaleX < 0)
			{
				upLeftCorner.X = x + scaleX;
				upLeftCorner.Y = y;
			}
			else
			{
				upLeftCorner.X = x;
				upLeftCorner.Y = y;
			}
		}
		private void Normalaze()
		{

		}
		public VectorObject()
		{

		}
		public VectorObject(string name, int x, int y, int scaleX, int scaleY, Shapes shape)
		{
			this.name = name;
			this.shape = shape;
			this.x = x;
			this.y = y;
			this.scaleX = scaleX;
			this.scaleY = scaleY;
			Script script1 = new Script("ShittyScript");
			Script script2 = new Script("AnotherShittyScript");
			Components.Add(script1.Name, script1);
			Components.Add(script2.Name, script2);
			ChangeUpLeftCorner();
		}
		public override void Create(Graphics graphics, Pen pen)
		{
			switch (shape)
			{
				case Shapes.Circle:
					graphics.DrawEllipse(pen, X, Y, scaleX, scaleY);
					break;
				case Shapes.Square:
					graphics.DrawPolygon(pen, new Point[]
						{
							new Point(X,Y),
							new Point(X+scaleX,Y),
							new Point(X+scaleX,Y+scaleY),
							new Point(X,Y+scaleY)

						});
					break;
				case Shapes.StickMan:
					FigureDrawing.MakeStickMan(graphics, X, Y, scaleX, scaleY, pen);
					break;
				case Shapes.Arrow_Horizontal:
					FigureDrawing.MakeArrowHorizontal(graphics, X, Y, scaleX, scaleY, pen);
					break;
				case Shapes.Arrow_Vertical:
					FigureDrawing.MakeArrowVertical(graphics, X, Y, scaleX, scaleY, pen);
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
		public override int ScaleX
		{
			get { return scaleX; }
			set
			{
				if (value < 1)
				{
					scaleX = 1;
				}
				else
				{
					scaleX = value;
					ChangeUpLeftCorner();
				}
			}
		}
		[Browsable(true)]
		[Description("Y scale of object")]
		[DisplayName("Scale_y")]
		[Category("Инспектор")]
		public override int ScaleY
		{
			get { return scaleY; }
			set
			{
				if (value < 1)
				{
					scaleY = 1;
				}
				else
				{
					scaleY = value;
					ChangeUpLeftCorner();
				}
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
			get { return upLeftCorner; }
		}

	}
}
