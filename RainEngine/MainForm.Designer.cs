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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.listView2 = new System.Windows.Forms.ListView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.sceneListView = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.scriptListView = new System.Windows.Forms.ListView();
			this.scripts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.searchObjectsBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.removeComponentButton = new System.Windows.Forms.Button();
			this.addComponentButton = new System.Windows.Forms.Button();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.открытьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новыйПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
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
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.Location = new System.Drawing.Point(5, 26);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(212, 173);
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
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(903, 483);
			this.splitContainer1.SplitterDistance = 671;
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
			this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer2.Size = new System.Drawing.Size(652, 476);
			this.splitContainer2.SplitterDistance = 355;
			this.splitContainer2.SplitterWidth = 3;
			this.splitContainer2.TabIndex = 2;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(3, -3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(647, 117);
			this.tabControl1.TabIndex = 2;
			this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl1_Selecting);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(639, 91);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Объекты - кисти";
			this.tabPage1.UseVisualStyleBackColor = true;
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
			this.listView1.Location = new System.Drawing.Point(0, 2);
			this.listView1.Margin = new System.Windows.Forms.Padding(2);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(639, 89);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
			this.listView1.Leave += new System.EventHandler(this.ListView1_Leave);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.listView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(639, 91);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Сценабы";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(3, 4);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(630, 83);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.sceneListView);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(639, 91);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Сцены";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// sceneListView
			// 
			this.sceneListView.HideSelection = false;
			this.sceneListView.LargeImageList = this.imageList1;
			this.sceneListView.Location = new System.Drawing.Point(4, 3);
			this.sceneListView.Name = "sceneListView";
			this.sceneListView.Size = new System.Drawing.Size(634, 84);
			this.sceneListView.TabIndex = 0;
			this.sceneListView.UseCompatibleStateImageBehavior = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "moon.png");
			this.imageList1.Images.SetKeyName(1, "scene");
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.scriptListView);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(639, 91);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Скрипты";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// scriptListView
			// 
			this.scriptListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.scripts});
			this.scriptListView.HideSelection = false;
			this.scriptListView.LargeImageList = this.imageList1;
			this.scriptListView.Location = new System.Drawing.Point(0, 0);
			this.scriptListView.Name = "scriptListView";
			this.scriptListView.Size = new System.Drawing.Size(639, 90);
			this.scriptListView.TabIndex = 0;
			this.scriptListView.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(639, 91);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Аудиофайлы";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.splitContainer3.Location = new System.Drawing.Point(3, 4);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.searchObjectsBox);
			this.splitContainer3.Panel1.Controls.Add(this.listBox1);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer3.Size = new System.Drawing.Size(220, 473);
			this.splitContainer3.SplitterDistance = 206;
			this.splitContainer3.TabIndex = 1;
			// 
			// searchObjectsBox
			// 
			this.searchObjectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchObjectsBox.Location = new System.Drawing.Point(5, 2);
			this.searchObjectsBox.Margin = new System.Windows.Forms.Padding(2);
			this.searchObjectsBox.Name = "searchObjectsBox";
			this.searchObjectsBox.Size = new System.Drawing.Size(212, 20);
			this.searchObjectsBox.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Controls.Add(this.removeComponentButton);
			this.flowLayoutPanel1.Controls.Add(this.addComponentButton);
			this.flowLayoutPanel1.Controls.Add(this.propertyGrid1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 257);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// removeComponentButton
			// 
			this.removeComponentButton.Location = new System.Drawing.Point(3, 3);
			this.removeComponentButton.Name = "removeComponentButton";
			this.removeComponentButton.Size = new System.Drawing.Size(189, 23);
			this.removeComponentButton.TabIndex = 5;
			this.removeComponentButton.Text = "Убрать компонент";
			this.removeComponentButton.UseVisualStyleBackColor = true;
			// 
			// addComponentButton
			// 
			this.addComponentButton.Location = new System.Drawing.Point(3, 32);
			this.addComponentButton.Name = "addComponentButton";
			this.addComponentButton.Size = new System.Drawing.Size(189, 23);
			this.addComponentButton.TabIndex = 4;
			this.addComponentButton.Text = "Добавить компонент";
			this.addComponentButton.UseVisualStyleBackColor = true;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid1.Location = new System.Drawing.Point(2, 60);
			this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2);
			this.propertyGrid1.MinimumSize = new System.Drawing.Size(190, 214);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(190, 214);
			this.propertyGrid1.TabIndex = 3;
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid1_PropertyValueChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton3,
            this.OpenFromXML,
            this.SaveToXML,
            this.toolStripButton6,
            this.toolStripButton7});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(914, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
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
			this.открытьПроектToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.открытьПроектToolStripMenuItem.Text = "Открыть проект";
			this.открытьПроектToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectButton_Click);
			// 
			// сохранитьПроектToolStripMenuItem
			// 
			this.сохранитьПроектToolStripMenuItem.Name = "сохранитьПроектToolStripMenuItem";
			this.сохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.сохранитьПроектToolStripMenuItem.Text = "Сохранить проект";
			// 
			// новыйПроектToolStripMenuItem
			// 
			this.новыйПроектToolStripMenuItem.Name = "новыйПроектToolStripMenuItem";
			this.новыйПроектToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.новыйПроектToolStripMenuItem.Text = "Новый проект";
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 511);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
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
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button addComponentButton;
		private System.Windows.Forms.Button removeComponentButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.ListView scriptListView;
		private System.Windows.Forms.ColumnHeader scripts;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListView sceneListView;
	}
}

