using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainEngine.CustomInterface
{
	public partial class ComponentView : UserControl
	{
		public ComponentView()
		{
			InitializeComponent();
		}

		public ComponentView(Component component)
		{
			InitializeComponent();
		}
	}
}
