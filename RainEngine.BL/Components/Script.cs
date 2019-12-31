using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainEngine.BL.Abstract;

namespace RainEngine.BL.Components
{
		
	class Script : Abstract.Component
	{
		[Browsable(true)]
		[DisplayName("Имя скрипта")]
		[Category("Поля компонента")]
		public string Name { get; set; }

		public Script(string name)
		{
			Name = name;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
