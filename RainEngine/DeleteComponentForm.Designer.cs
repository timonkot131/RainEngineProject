namespace RainEngine
{
	partial class DeleteComponentForm
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
			this.DeleteComponentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// componentsBox
			// 
			this.componentsBox.FormattingEnabled = true;
			this.componentsBox.Location = new System.Drawing.Point(12, 12);
			this.componentsBox.Name = "componentsBox";
			this.componentsBox.Size = new System.Drawing.Size(210, 199);
			this.componentsBox.TabIndex = 1;
			// 
			// DeleteComponentButton
			// 
			this.DeleteComponentButton.Location = new System.Drawing.Point(12, 217);
			this.DeleteComponentButton.Name = "DeleteComponentButton";
			this.DeleteComponentButton.Size = new System.Drawing.Size(210, 23);
			this.DeleteComponentButton.TabIndex = 2;
			this.DeleteComponentButton.Text = "Убрать компонент";
			this.DeleteComponentButton.UseVisualStyleBackColor = true;
			this.DeleteComponentButton.Click += new System.EventHandler(this.DeleteComponentButton_Click);
			// 
			// DeleteComponentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 277);
			this.Controls.Add(this.DeleteComponentButton);
			this.Controls.Add(this.componentsBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DeleteComponentForm";
			this.Text = "DeleteComponentForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox componentsBox;
		private System.Windows.Forms.Button DeleteComponentButton;
	}
}