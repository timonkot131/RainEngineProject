namespace RainEngine
{
	partial class EditorStart
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.createProjectButton = new System.Windows.Forms.Button();
			this.openProjectButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.creationPath = new System.Windows.Forms.TextBox();
			this.pickPathButton = new System.Windows.Forms.Button();
			this.createProjectButton2 = new System.Windows.Forms.Button();
			this.backToStart = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.projNameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// createProjectButton
			// 
			this.createProjectButton.Location = new System.Drawing.Point(71, 93);
			this.createProjectButton.Name = "createProjectButton";
			this.createProjectButton.Size = new System.Drawing.Size(136, 23);
			this.createProjectButton.TabIndex = 0;
			this.createProjectButton.Text = "Создать проект";
			this.createProjectButton.UseVisualStyleBackColor = true;
			this.createProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
			// 
			// openProjectButton
			// 
			this.openProjectButton.Location = new System.Drawing.Point(71, 122);
			this.openProjectButton.Name = "openProjectButton";
			this.openProjectButton.Size = new System.Drawing.Size(136, 23);
			this.openProjectButton.TabIndex = 1;
			this.openProjectButton.Text = "Открыть проект";
			this.openProjectButton.UseVisualStyleBackColor = true;
			this.openProjectButton.Click += new System.EventHandler(this.OpenProjectButton_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(274, 56);
			this.label1.TabIndex = 2;
			this.label1.Text = "ДОБРО ПОЖАЛОВАТЬ В ДВИЖОК ДОЖДЯ!\r\n\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.CheckFileExists = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(-2, -20);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(295, 340);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.openProjectButton);
			this.tabPage1.Controls.Add(this.createProjectButton);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(287, 294);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Начальный экран";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.projNameBox);
			this.tabPage2.Controls.Add(this.backToStart);
			this.tabPage2.Controls.Add(this.createProjectButton2);
			this.tabPage2.Controls.Add(this.pickPathButton);
			this.tabPage2.Controls.Add(this.creationPath);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(287, 314);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Создание проекта";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// creationPath
			// 
			this.creationPath.Location = new System.Drawing.Point(54, 20);
			this.creationPath.Name = "creationPath";
			this.creationPath.Size = new System.Drawing.Size(166, 20);
			this.creationPath.TabIndex = 0;
			this.creationPath.TextChanged += new System.EventHandler(this.CreationPath_TextChanged);
			// 
			// pickPathButton
			// 
			this.pickPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.pickPathButton.Location = new System.Drawing.Point(226, 20);
			this.pickPathButton.Name = "pickPathButton";
			this.pickPathButton.Size = new System.Drawing.Size(53, 20);
			this.pickPathButton.TabIndex = 1;
			this.pickPathButton.Text = "...";
			this.pickPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.pickPathButton.UseVisualStyleBackColor = true;
			this.pickPathButton.Click += new System.EventHandler(this.PickPathButton_Click);
			// 
			// createProjectButton2
			// 
			this.createProjectButton2.Location = new System.Drawing.Point(160, 260);
			this.createProjectButton2.Name = "createProjectButton2";
			this.createProjectButton2.Size = new System.Drawing.Size(108, 23);
			this.createProjectButton2.TabIndex = 2;
			this.createProjectButton2.Text = "Создать проект";
			this.createProjectButton2.UseVisualStyleBackColor = true;
			this.createProjectButton2.Click += new System.EventHandler(this.CreateProjectButton2_Click);
			// 
			// backToStart
			// 
			this.backToStart.Location = new System.Drawing.Point(6, 260);
			this.backToStart.Name = "backToStart";
			this.backToStart.Size = new System.Drawing.Size(75, 23);
			this.backToStart.TabIndex = 3;
			this.backToStart.Text = "Назад";
			this.backToStart.UseVisualStyleBackColor = true;
			this.backToStart.Click += new System.EventHandler(this.BackToStart_Click);
			// 
			// projNameBox
			// 
			this.projNameBox.Location = new System.Drawing.Point(110, 70);
			this.projNameBox.Name = "projNameBox";
			this.projNameBox.Size = new System.Drawing.Size(154, 20);
			this.projNameBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(-2, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = " Имя проекта:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "Путь:";
			// 
			// EditorStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 319);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "EditorStart";
			this.Text = "EditorStart";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button createProjectButton;
		private System.Windows.Forms.Button openProjectButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button backToStart;
		private System.Windows.Forms.Button createProjectButton2;
		private System.Windows.Forms.Button pickPathButton;
		private System.Windows.Forms.TextBox creationPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox projNameBox;
	}
}