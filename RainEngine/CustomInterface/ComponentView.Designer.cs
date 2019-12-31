namespace RainEngine.CustomInterface
{
	partial class ComponentView
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.componentName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mainLayoutPanel
			// 
			this.mainLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.mainLayoutPanel.Location = new System.Drawing.Point(3, 32);
			this.mainLayoutPanel.Name = "mainLayoutPanel";
			this.mainLayoutPanel.Size = new System.Drawing.Size(267, 180);
			this.mainLayoutPanel.TabIndex = 0;
			// 
			// componentName
			// 
			this.componentName.AutoSize = true;
			this.componentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.23F);
			this.componentName.Location = new System.Drawing.Point(3, 5);
			this.componentName.Name = "componentName";
			this.componentName.Size = new System.Drawing.Size(60, 24);
			this.componentName.TabIndex = 1;
			this.componentName.Text = "label1";
			// 
			// ComponentView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.componentName);
			this.Controls.Add(this.mainLayoutPanel);
			this.Name = "ComponentView";
			this.Size = new System.Drawing.Size(273, 215);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel mainLayoutPanel;
		private System.Windows.Forms.Label componentName;
	}
}
