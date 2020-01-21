using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.BL.Abstract;

namespace RainEngine
{
	public partial class AddComponentForm : Form
	{
		OnComplete onComplete;
		SceneObject target;
		public AddComponentForm(SceneObject target, OnComplete onComplete)
		{
			InitializeComponent();
			this.target = target;
			this.onComplete = onComplete;

			var componentTypes = Assembly
				.GetAssembly(typeof(BL.Abstract.Component))
				.GetTypes()
				.Where(t => t.IsSubclassOf(typeof(BL.Abstract.Component)))
				.ToList();

			foreach(var componentType in componentTypes)
			{
				var component = Activator.CreateInstance(componentType);
				componentsBox.Items.Add(component);
			}
		}

		private void AddComponentButton_Click(object sender, EventArgs e)
		{
			if(componentsBox.SelectedItem == null)
			{
				return;
			}

			onComplete?.Invoke(componentsBox.SelectedItem as BL.Abstract.Component, target);
			Close();
		}
	}
}
