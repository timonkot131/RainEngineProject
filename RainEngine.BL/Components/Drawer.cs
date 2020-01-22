using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RainEngine.BL.Abstract;

namespace RainEngine.BL.Components
{
	public class Drawer : Abstract.Component
	{
		public Drawer()
		{

		}

		public override string ToString()
		{
			return "Drawer";
		}

		public override string GetName()
		{
			return "Drawer";
		}

		[DisplayName("Векторная кисть")]
		[Browsable(true)]
		[Description("Рисует векторную картинку")]
		[Category("Поля компонента")]
		public Shapes Shape { get; set; }

		[DisplayName("Спрайт")]
		[Browsable(true)]
		[Description("Рисует растровую картинку")]
		[Category("Поля компонента")]
		public Bitmap Sprite { get; set; }

		[DisplayName("Использовать векторную кисть")]
		[Browsable(true)]
		[Description("Использует только векторную кисть для рисования")]
		[Category("Поля компонента")]
		public bool UseBrush { get; set; }

		public override object Clone(SceneObject newTarget)
		{
			Bitmap bitmap = null;

			if(Sprite != null)
			{
				bitmap = Sprite.Clone() as Bitmap;
			}

			return new Drawer
			{
				UseBrush = UseBrush,
				Shape = Shape,
				Sprite = bitmap,
				Target = newTarget
			};
		}

		public Drawer Draw(Graphics graphics, Pen pen)
		{
			if (UseBrush)
			{
				switch (Shape)
				{
					case Shapes.Circle:
						graphics.DrawEllipse(pen, Target.X, Target.Y, Target.ScaleX, Target.ScaleY);
						break;
					case Shapes.Square:
						graphics.DrawPolygon(pen, new Point[]
							{
							new Point(Target.X,Target.Y),
							new Point(Target.X+Target.ScaleX,Target.Y),
							new Point(Target.X+Target.ScaleX,Target.Y+Target.ScaleY),
							new Point(Target.X,Target.Y+Target.ScaleY)

							});
						break;
					case Shapes.StickMan:
						FigureDrawing.MakeStickMan(graphics, Target.X, Target.Y, Target.ScaleX, Target.ScaleY, pen);
						break;
					case Shapes.Arrow_Horizontal:
						FigureDrawing.MakeArrowHorizontal(graphics, Target.X, Target.Y, Target.ScaleX, Target.ScaleY, pen);
						break;
					case Shapes.Arrow_Vertical:
						FigureDrawing.MakeArrowVertical(graphics, Target.X, Target.Y, Target.ScaleX, Target.ScaleY, pen);
						break;
				}
			}
			else
			{

			}

			return this;
		}
	}
}
