﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RainEngine.BL.Abstract;

namespace RainEngine.BL.Components
{
		
	public class Script : Abstract.Component
	{
		[Browsable(true)]
		[DisplayName("Имя скрипта")]
		[Category("Поля компонента")]
		public string Name { get; set; }

		public Script()
		{

		}

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
