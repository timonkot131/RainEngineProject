using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.BL.Abstract;
using RainEngine.Abstract;

namespace RainEngine.InteractionFabrics
{
	public class SizeDiagInter:IMouseInteractionFactory
	{
		public void Interact(IView view, Point mouse, SceneObject sceneObject, Point startPos)
		{
			int xOffset = mouse.X - sceneObject.X;
			int yOffset = mouse.Y - sceneObject.Y;

			sceneObject.ScaleX = xOffset;
			sceneObject.ScaleY = yOffset;

			view.ChangeCursor(Cursors.SizeNWSE);
		}
	}
}
