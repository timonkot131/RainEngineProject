using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;
using RainEngine.Abstract;

namespace RainEngine
{
	public partial class EditorStart : Form
	{
		string createProjectPath;
		IView view;

		public EditorStart(IView view)
		{
			InitializeComponent();
			this.view = view;
		}

		private void CreateProjectButton_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage2;
		}

		private void BackToStart_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage1;
		}

		private void PickPathButton_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				creationPath.Text = folderBrowserDialog1.SelectedPath;
				return;
			}

		}

		private void CreateProjectButton2_Click(object sender, EventArgs e)
		{
			if (createProjectPath == null || string.IsNullOrWhiteSpace(creationPath.Text))
			{
				MessageBox.Show("Вы должны выбрать путь");
				return;
			}

			if (string.IsNullOrWhiteSpace(projNameBox.Text))
			{
				MessageBox.Show("Вы должны ввести имя проекта");
				return;
			}

			try
			{
				createProjectPath += "/" + projNameBox.Text;
				XDocument rainManifest = new XDocument();
				
				rainManifest.Add(new XElement("Project", new XAttribute("name", projNameBox.Text), new XAttribute("version", "1.0")));
				var root = rainManifest.Root;
				//adding folders, then add this name in document
				root.Add(new XElement("ProjectPath", Directory.CreateDirectory(createProjectPath).FullName));
				root.Add(new XElement("ScriptsPath", Directory.CreateDirectory(createProjectPath + "/scripts").FullName));
				root.Add(new XElement("ScenesPath", Directory.CreateDirectory(createProjectPath + "/scenes").FullName));
				root.Add(new XElement("ScenabsPath", Directory.CreateDirectory(createProjectPath + "/scenabs").FullName));

				rainManifest.Save(createProjectPath + "/rainManifest.xml");

				ProjectSettings.Manifest = rainManifest;

				var form = view as MainForm;
				form.Show();
				Hide();
			}
			catch(Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		private void OpenProjectButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					ProjectSettings.Manifest = XDocument.Load(openFileDialog1.FileName);
					var form = view as MainForm;
					form.Show();
					Hide();
				}
				catch(Exception err)
				{
					MessageBox.Show(err.Message);
				}
			}
		}

		private void CreationPath_TextChanged(object sender, EventArgs e)
		{
			createProjectPath = folderBrowserDialog1.SelectedPath;
		}
	}
}
