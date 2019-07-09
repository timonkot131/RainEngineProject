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
	public class CreateObjInter : IMouseInteractionFactory
	{
		public void Interact(IView view, Point mouse, SceneObject sceneObject, Point startPos)
		{
			sceneObject.X = startPos.X;
			sceneObject.Y = startPos.Y;
			sceneObject.ScaleX = mouse.X - startPos.X;
			sceneObject.ScaleY = mouse.Y - startPos.Y;

			view.ChangeCursor(Cursors.Cross);
		}
	}
	
}
