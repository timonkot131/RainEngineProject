﻿using System;
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
	public class TransformObjtInter : IMouseInteractionFactory
	{
		public void Interact(IView view, Point mouse, SceneObject sceneObject, Point startPos)
		{
			sceneObject.X = mouse.X;
			sceneObject.Y = mouse.Y;

			view.ChangeCursor(Cursors.SizeAll);
		}
	}
}
