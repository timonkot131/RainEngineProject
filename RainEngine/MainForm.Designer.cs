namespace RainEngine
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("прапр");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("рпапр");
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("рпар");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.listView1 = new System.Windows.Forms.ListView();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.searchObjectsBox = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.openProjectButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.OpenFromXML = new System.Windows.Forms.ToolStripButton();
			this.SaveToXML = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.дублироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.открытьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новыйПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(11, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(630, 347);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseClick);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.Location = new System.Drawing.Point(11, 37);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(163, 238);
			this.listBox1.TabIndex = 1;
			this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseClick);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Location = new System.Drawing.Point(2, 22);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
			this.splitContainer1.Panel2.Controls.Add(this.searchObjectsBox);
			this.splitContainer1.Panel2.Controls.Add(this.listBox1);
			this.splitContainer1.Size = new System.Drawing.Size(838, 483);
			this.splitContainer1.SplitterDistance = 659;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 2;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Location = new System.Drawing.Point(2, 1);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.listView1);
			this.splitContainer2.Size = new System.Drawing.Size(653, 476);
			this.splitContainer2.SplitterDistance = 365;
			this.splitContainer2.SplitterWidth = 3;
			this.splitContainer2.TabIndex = 2;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.CausesValidation = false;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
			this.listView1.Location = new System.Drawing.Point(2, 5);
			this.listView1.Margin = new System.Windows.Forms.Padding(2);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(634, 100);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
			this.listView1.Leave += new System.EventHandler(this.ListView1_Leave);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid1.Location = new System.Drawing.Point(11, 279);
			this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(162, 202);
			this.propertyGrid1.TabIndex = 3;
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid1_PropertyValueChanged);
			// 
			// searchObjectsBox
			// 
			this.searchObjectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchObjectsBox.Location = new System.Drawing.Point(11, 14);
			this.searchObjectsBox.Margin = new System.Windows.Forms.Padding(2);
			this.searchObjectsBox.Name = "searchObjectsBox";
			this.searchObjectsBox.Size = new System.Drawing.Size(163, 20);
			this.searchObjectsBox.TabIndex = 2;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.openProjectButton,
            this.toolStripButton3,
            this.OpenFromXML,
            this.SaveToXML,
            this.toolStripButton6,
            this.toolStripButton7});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(849, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(42, 22);
			this.toolStripButton1.Text = "Старт";
			// 
			// openProjectButton
			// 
			this.openProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.openProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("openProjectButton.Image")));
			this.openProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openProjectButton.Name = "openProjectButton";
			this.openProjectButton.Size = new System.Drawing.Size(99, 22);
			this.openProjectButton.Text = "Открыть проект";
			this.openProjectButton.Click += new System.EventHandler(this.OpenProjectButton_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(98, 22);
			this.toolStripButton3.Text = "Очистить сцену";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// OpenFromXML
			// 
			this.OpenFromXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.OpenFromXML.Image = ((System.Drawing.Image)(resources.GetObject("OpenFromXML.Image")));
			this.OpenFromXML.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenFromXML.Name = "OpenFromXML";
			this.OpenFromXML.Size = new System.Drawing.Size(135, 22);
			this.OpenFromXML.Text = "Открыть сцену из XML";
			this.OpenFromXML.Click += new System.EventHandler(this.OpenFromXML_Click);
			// 
			// SaveToXML
			// 
			this.SaveToXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.SaveToXML.Image = ((System.Drawing.Image)(resources.GetObject("SaveToXML.Image")));
			this.SaveToXML.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveToXML.Name = "SaveToXML";
			this.SaveToXML.Size = new System.Drawing.Size(140, 22);
			this.SaveToXML.Text = "Сохранить сцену в XML";
			this.SaveToXML.Click += new System.EventHandler(this.SaveToXML_Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripButton6.Size = new System.Drawing.Size(65, 22);
			this.toolStripButton6.Text = "Отменить";
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripButton7.Size = new System.Drawing.Size(50, 22);
			this.toolStripButton7.Text = "Вперед";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "(*.xml)|*.xml";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "(*.xml)|*.xml";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.дублироватьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItem_Click);
			// 
			// дублироватьToolStripMenuItem
			// 
			this.дублироватьToolStripMenuItem.Name = "дублироватьToolStripMenuItem";
			this.дублироватьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.дублироватьToolStripMenuItem.Text = "Дублировать";
			this.дублироватьToolStripMenuItem.Click += new System.EventHandler(this.ДублироватьToolStripMenuItem_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПроектToolStripMenuItem,
            this.сохранитьПроектToolStripMenuItem,
            this.новыйПроектToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
			this.toolStripDropDownButton1.Text = "Файл";
			// 
			// открытьПроектToolStripMenuItem
			// 
			this.открытьПроектToolStripMenuItem.Name = "открытьПроектToolStripMenuItem";
			this.открытьПроектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.открытьПроектToolStripMenuItem.Text = "Открыть проект";
			this.открытьПроектToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectButton_Click);
			// 
			// сохранитьПроектToolStripMenuItem
			// 
			this.сохранитьПроектToolStripMenuItem.Name = "сохранитьПроектToolStripMenuItem";
			this.сохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сохранитьПроектToolStripMenuItem.Text = "Сохранить проект";
			// 
			// новыйПроектToolStripMenuItem
			// 
			this.новыйПроектToolStripMenuItem.Name = "новыйПроектToolStripMenuItem";
			this.новыйПроектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.новыйПроектToolStripMenuItem.Text = "Новый проект";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 511);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton openProjectButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton OpenFromXML;
        private System.Windows.Forms.ToolStripButton SaveToXML;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox searchObjectsBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дублироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem открытьПроектToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьПроектToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новыйПроектToolStripMenuItem;
	}
}

