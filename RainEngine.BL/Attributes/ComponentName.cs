using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine.Attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	class ComponentName : Attribute
	{
		public string name;

		public ComponentName(string name)
		{
			this.name = name;
		}
	}
}