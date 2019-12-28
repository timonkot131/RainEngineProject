namespace RainEngineGame
{
	partial class GameForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.GameScene = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.GameScene)).BeginInit();
			this.SuspendLayout();
			// 
			// GameScene
			// 
			this.GameScene.Location = new System.Drawing.Point(12, 12);
			this.GameScene.Name = "GameScene";
			this.GameScene.Size = new System.Drawing.Size(776, 426);
			this.GameScene.TabIndex = 0;
			this.GameScene.TabStop = false;
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.GameScene);
			this.Name = "GameForm";
			this.Text = "RainEngine";
			((System.ComponentModel.ISupportInitialize)(this.GameScene)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox GameScene;
	}
}

