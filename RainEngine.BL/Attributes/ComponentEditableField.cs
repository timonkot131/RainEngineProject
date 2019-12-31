using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainEngine.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	class EditableField : Attribute
	{
		public string name;

		public Type type;
	}
}
