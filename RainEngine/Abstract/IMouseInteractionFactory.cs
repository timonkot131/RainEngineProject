using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.BL.Abstract;

namespace RainEngine.Abstract
{
	interface IMouseInteractionFactory
	{
		void Interact(IView view, Point mouse, SceneObject sceneObject, Point startPos);
	}
}
