using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RainEngine.BL.Abstract;

namespace RainEngine
{
	public partial class DeleteComponentForm : Form
	{
		OnComplete onComplete;
		SceneObject target;

		public DeleteComponentForm(SceneObject target, OnComplete onComplete)
		{
			InitializeComponent();
			this.target = target;
			this.onComplete = onComplete;
			
			foreach(var typeComponent in target.Components)
			{
				componentsBox.Items.Add(typeComponent.Value);
			}
		}

		private void DeleteComponentButton_Click(object sender, EventArgs e)
		{
			if (componentsBox.SelectedItem == null)
			{
				return;
			}

			onComplete?.Invoke(componentsBox.SelectedItem as BL.Abstract.Component, target);
			Close();
		}
	}
}
