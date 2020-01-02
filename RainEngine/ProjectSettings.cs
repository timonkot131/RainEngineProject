using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RainEngine
{
	public static class ProjectSettings
	{
		static public XDocument Manifest
		{
			get;
			set;
		}
	}
}
