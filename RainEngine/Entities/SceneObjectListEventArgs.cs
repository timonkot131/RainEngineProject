using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RainEngine.BL;
using RainEngine.BL.Abstract;

namespace RainEngine.Entities
{
	public class SceneObjectListEventArgs : EventArgs
	{
		public SceneObjectListEventArgs(int itemIndex)
		{
			Item = itemIndex;
			SceneObject = new EmptyObject();
		}
		public SceneObjectListEventArgs(SceneObject sceneObject)
		{
			Item = 0;
			SceneObject = sceneObject;
		}

		public int Item { get; set; }

		public SceneObject SceneObject { get;set; }

        public Graphics Graph { get; set; }
    }
}
