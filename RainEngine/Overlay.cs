using RainEngine.BL.Abstract;
using RainEngine.BL.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine
{
	static class Overlay
	{
		private static Pen colourPen = new Pen(Color.Black, 3);
		public static SceneObject DrawingObject { get; set; }
		public static SceneObject SelectedObject { get; set; }
		static public void DrawOverlay(Graphics graph)
		{
			if (SelectedObject != null)
			{
				graph.DrawPolygon(new Pen(Color.Green), new Point[]
				{
				new Point(SelectedObject.X,SelectedObject.Y),
				new Point(SelectedObject.X+SelectedObject.ScaleX,SelectedObject.Y),
				new Point(SelectedObject.X+SelectedObject.ScaleX,SelectedObject.Y+SelectedObject.ScaleY),
				new Point(SelectedObject.X,SelectedObject.Y+SelectedObject.ScaleY)
				});
			}

			if (DrawingObject != null)
			{
				DrawingObject.GetComponent<Drawer>().Draw(graph, colourPen);
			}
		}
	}
}
