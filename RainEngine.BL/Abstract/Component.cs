using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;

namespace RainEngine.BL.Abstract
{
	[Serializable]
	[XmlInclude(typeof(Components.Script))]
	[XmlInclude(typeof(Components.Drawer))]
	public abstract class Component
	{
		public abstract object Clone(SceneObject newTarget);

		public abstract string GetName();

		[DisplayName("Прикрепленный объект")]
		[Browsable(true)]
		[Category("Поля компонента")]
		public SceneObject Target { get; set; }
	}
}
