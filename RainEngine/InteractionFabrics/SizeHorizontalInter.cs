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
	public class SizeHorizontalInter: IMouseInteractionFactory
	{
		public void Interact(IView view, Point mouse, SceneObject sceneObject, Point startPos)
		{
			int offset = mouse.X - sceneObject.X;

			sceneObject.ScaleX = offset;

			view.ChangeCursor(Cursors.SizeWE);
		}
	}
}
