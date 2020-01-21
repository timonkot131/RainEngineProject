namespace RainEngine
{
	partial class AddComponentForm
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
			this.componentsBox = new System.Windows.Forms.ListBox();
			this.AddComponentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// componentsBox
			// 
			this.componentsBox.FormattingEnabled = true;
			this.componentsBox.Location = new System.Drawing.Point(12, 12);
			this.componentsBox.Name = "componentsBox";
			this.componentsBox.Size = new System.Drawing.Size(210, 186);
			this.componentsBox.TabIndex = 0;
			// 
			// AddComponentButton
			// 
			this.AddComponentButton.Location = new System.Drawing.Point(12, 204);
			this.AddComponentButton.Name = "AddComponentButton";
			this.AddComponentButton.Size = new System.Drawing.Size(210, 23);
			this.AddComponentButton.TabIndex = 1;
			this.AddComponentButton.Text = "Добавить компонент";
			this.AddComponentButton.UseVisualStyleBackColor = true;
			this.AddComponentButton.Click += new System.EventHandler(this.AddComponentButton_Click);
			// 
			// AddComponentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 236);
			this.Controls.Add(this.AddComponentButton);
			this.Controls.Add(this.componentsBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AddComponentForm";
			this.Text = "AddComponentForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox componentsBox;
		private System.Windows.Forms.Button AddComponentButton;
	}
}