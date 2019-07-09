using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.Abstract;
using RainEngine.BL.Abstract;

namespace RainEngine.InteractionFabrics
{
	public class SizeVerticalInter : IMouseInteractionFactory
	{
		public void Interact(IView view, Point mouse, SceneObject sceneObject, Point startPos)
		{
			int offset = mouse.Y - sceneObject.Y;

			sceneObject.ScaleY = offset;

			view.ChangeCursor(Cursors.SizeNS);
		}
	}
}
