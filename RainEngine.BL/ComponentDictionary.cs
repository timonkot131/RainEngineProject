using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainEngine.BL.Abstract;

namespace RainEngine.BL
{
	[Category("Прочие компоненты")]
	public class ComponentDictionary : Dictionary<string, Abstract.Component>
	{
		[Browsable(false)]
		new public int Count
		{
			get
			{
				return base.Count;
			}
		}

		[Browsable(false)]
		new public IEqualityComparer<string> Comparer
		{
			get
			{
				return base.Comparer;
			}
		}

		[Browsable(false)]
		new public KeyCollection Keys
		{
			get { return base.Keys; }
		}

		[Browsable(true)]
		[DisplayName("Компоненты")]
		new public ValueCollection Values
		{
			get { return base.Values;  }
		}

		public ComponentDictionary() : base() {}

		public override string ToString()
		{
			return "Адаптер коллекции компонентов";
		}
	}
}
