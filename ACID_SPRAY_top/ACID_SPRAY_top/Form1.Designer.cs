namespace ACID_SPRAY_top
{
    partial class Form1
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
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConnectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.ColorSelect = new System.Windows.Forms.ComboBox();
            this.ScalSelect = new System.Windows.Forms.ComboBox();
            this.LEDTrack = new System.Windows.Forms.TrackBar();
            this.LEDLabel = new System.Windows.Forms.Label();
            this.OE_check = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.blue_scaled_lbl = new System.Windows.Forms.Label();
            this.green_scaled_lbl = new System.Windows.Forms.Label();
            this.red_scaled_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.set_white_max = new System.Windows.Forms.Button();
            this.set_blue_max = new System.Windows.Forms.Button();
            this.set_green_max = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.set_red_max_btn = new System.Windows.Forms.Button();
            this.white_max_lbl = new System.Windows.Forms.Label();
            this.blue_max_lbl = new System.Windows.Forms.Label();
            this.green_max_lbl = new System.Windows.Forms.Label();
            this.red_max_lbl = new System.Windows.Forms.Label();
            this.set_min_btn = new System.Windows.Forms.Button();
            this.white_min_lbl = new System.Windows.Forms.Label();
            this.blue_min_lbl = new System.Windows.Forms.Label();
            this.green_min_lbl = new System.Windows.Forms.Label();
            this.red_min_lbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Heater = new System.Windows.Forms.CheckBox();
            this.DropVal = new System.Windows.Forms.Label();
            this.Droplbl = new System.Windows.Forms.Label();
            this.TempVal = new System.Windows.Forms.Label();
            this.Templbl = new System.Windows.Forms.Label();
            this.DropGraph = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.IR_val_lbl = new System.Windows.Forms.Label();
            this.IRTrack = new System.Windows.Forms.TrackBar();
            this.IR_graph = new ZedGraph.ZedGraphControl();
            this.PUMPLabel = new System.Windows.Forms.Label();
            this.PUMPTrack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEDTrack)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IRTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUMPTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // COM
            // 
            this.COM.BaudRate = 115200;
            this.COM.PortName = "COM3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConnectMenu
            // 
            this.ConnectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отключитьToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.ConnectMenu.Name = "ConnectMenu";
            this.ConnectMenu.Size = new System.Drawing.Size(97, 20);
            this.ConnectMenu.Text = "Подключение";
            this.ConnectMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ConnectMenu_DropDownItemClicked);
            this.ConnectMenu.Click += new System.EventHandler(this.ConnectMenu_Click);
            // 
            // отключитьToolStripMenuItem
            // 
            this.отключитьToolStripMenuItem.Name = "отключитьToolStripMenuItem";
            this.отключитьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.отключитьToolStripMenuItem.Text = "Отключить";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1025, 398);
            this.zedGraphControl1.TabIndex = 1;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // ColorSelect
            // 
            this.ColorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorSelect.FormattingEnabled = true;
            this.ColorSelect.Items.AddRange(new object[] {
            "White",
            "Red",
            "Green",
            "Blue",
            "ALL"});
            this.ColorSelect.Location = new System.Drawing.Point(1265, 42);
            this.ColorSelect.Name = "ColorSelect";
            this.ColorSelect.Size = new System.Drawing.Size(121, 21);
            this.ColorSelect.TabIndex = 2;
            this.ColorSelect.SelectedIndexChanged += new System.EventHandler(this.ColorSelect_SelectedIndexChanged);
            // 
            // ScalSelect
            // 
            this.ScalSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScalSelect.FormattingEnabled = true;
            this.ScalSelect.Items.AddRange(new object[] {
            "2%",
            "20%",
            "100%",
            "OFF"});
            this.ScalSelect.Location = new System.Drawing.Point(1265, 83);
            this.ScalSelect.Name = "ScalSelect";
            this.ScalSelect.Size = new System.Drawing.Size(121, 21);
            this.ScalSelect.TabIndex = 3;
            this.ScalSelect.SelectedIndexChanged += new System.EventHandler(this.ColorSelect_SelectedIndexChanged);
            // 
            // LEDTrack
            // 
            this.LEDTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LEDTrack.Location = new System.Drawing.Point(1225, 110);
            this.LEDTrack.Maximum = 100;
            this.LEDTrack.Name = "LEDTrack";
            this.LEDTrack.Size = new System.Drawing.Size(190, 45);
            this.LEDTrack.TabIndex = 4;
            this.LEDTrack.Scroll += new System.EventHandler(this.LEDTrack_Scroll);
            // 
            // LEDLabel
            // 
            this.LEDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LEDLabel.AutoSize = true;
            this.LEDLabel.Location = new System.Drawing.Point(1312, 158);
            this.LEDLabel.Name = "LEDLabel";
            this.LEDLabel.Size = new System.Drawing.Size(35, 13);
            this.LEDLabel.TabIndex = 5;
            this.LEDLabel.Text = "label1";
            // 
            // OE_check
            // 
            this.OE_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OE_check.Appearance = System.Windows.Forms.Appearance.Button;
            this.OE_check.AutoSize = true;
            this.OE_check.Location = new System.Drawing.Point(1176, 23);
            this.OE_check.Name = "OE_check";
            this.OE_check.Size = new System.Drawing.Size(68, 23);
            this.OE_check.TabIndex = 6;
            this.OE_check.Text = "Вкл/Выкл";
            this.OE_check.UseVisualStyleBackColor = true;
            this.OE_check.CheckedChanged += new System.EventHandler(this.ColorSelect_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1468, 424);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.blue_scaled_lbl);
            this.tabPage1.Controls.Add(this.green_scaled_lbl);
            this.tabPage1.Controls.Add(this.red_scaled_lbl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.set_white_max);
            this.tabPage1.Controls.Add(this.set_blue_max);
            this.tabPage1.Controls.Add(this.set_green_max);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.set_red_max_btn);
            this.tabPage1.Controls.Add(this.white_max_lbl);
            this.tabPage1.Controls.Add(this.blue_max_lbl);
            this.tabPage1.Controls.Add(this.green_max_lbl);
            this.tabPage1.Controls.Add(this.red_max_lbl);
            this.tabPage1.Controls.Add(this.set_min_btn);
            this.tabPage1.Controls.Add(this.white_min_lbl);
            this.tabPage1.Controls.Add(this.blue_min_lbl);
            this.tabPage1.Controls.Add(this.green_min_lbl);
            this.tabPage1.Controls.Add(this.red_min_lbl);
            this.tabPage1.Controls.Add(this.ColorSelect);
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Controls.Add(this.OE_check);
            this.tabPage1.Controls.Add(this.ScalSelect);
            this.tabPage1.Controls.Add(this.LEDLabel);
            this.tabPage1.Controls.Add(this.LEDTrack);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1460, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Цвет";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1346, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1346, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1346, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "R";
            // 
            // blue_scaled_lbl
            // 
            this.blue_scaled_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blue_scaled_lbl.AutoSize = true;
            this.blue_scaled_lbl.Location = new System.Drawing.Point(1376, 274);
            this.blue_scaled_lbl.Name = "blue_scaled_lbl";
            this.blue_scaled_lbl.Size = new System.Drawing.Size(23, 13);
            this.blue_scaled_lbl.TabIndex = 28;
            this.blue_scaled_lbl.Text = "n/s";
            // 
            // green_scaled_lbl
            // 
            this.green_scaled_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.green_scaled_lbl.AutoSize = true;
            this.green_scaled_lbl.Location = new System.Drawing.Point(1376, 252);
            this.green_scaled_lbl.Name = "green_scaled_lbl";
            this.green_scaled_lbl.Size = new System.Drawing.Size(23, 13);
            this.green_scaled_lbl.TabIndex = 27;
            this.green_scaled_lbl.Text = "n/s";
            // 
            // red_scaled_lbl
            // 
            this.red_scaled_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.red_scaled_lbl.AutoSize = true;
            this.red_scaled_lbl.Location = new System.Drawing.Point(1376, 230);
            this.red_scaled_lbl.Name = "red_scaled_lbl";
            this.red_scaled_lbl.Size = new System.Drawing.Size(23, 13);
            this.red_scaled_lbl.TabIndex = 26;
            this.red_scaled_lbl.Text = "n/s";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1212, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Max";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1101, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Min";
            // 
            // set_white_max
            // 
            this.set_white_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set_white_max.Location = new System.Drawing.Point(1249, 310);
            this.set_white_max.Name = "set_white_max";
            this.set_white_max.Size = new System.Drawing.Size(59, 23);
            this.set_white_max.TabIndex = 23;
            this.set_white_max.Text = "Set Max";
            this.set_white_max.UseVisualStyleBackColor = true;
            this.set_white_max.Click += new System.EventHandler(this.set_white_max_Click);
            // 
            // set_blue_max
            // 
            this.set_blue_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set_blue_max.Location = new System.Drawing.Point(1249, 274);
            this.set_blue_max.Name = "set_blue_max";
            this.set_blue_max.Size = new System.Drawing.Size(59, 23);
            this.set_blue_max.TabIndex = 22;
            this.set_blue_max.Text = "Set Max";
            this.set_blue_max.UseVisualStyleBackColor = true;
            this.set_blue_max.Click += new System.EventHandler(this.set_blue_max_Click);
            // 
            // set_green_max
            // 
            this.set_green_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set_green_max.Location = new System.Drawing.Point(1249, 242);
            this.set_green_max.Name = "set_green_max";
            this.set_green_max.Size = new System.Drawing.Size(59, 23);
            this.set_green_max.TabIndex = 21;
            this.set_green_max.Text = "Set Max";
            this.set_green_max.UseVisualStyleBackColor = true;
            this.set_green_max.Click += new System.EventHandler(this.set_green_max_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1046, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "White";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1046, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Blue";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1046, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Green";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1046, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Red";
            // 
            // set_red_max_btn
            // 
            this.set_red_max_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set_red_max_btn.Location = new System.Drawing.Point(1249, 208);
            this.set_red_max_btn.Name = "set_red_max_btn";
            this.set_red_max_btn.Size = new System.Drawing.Size(59, 23);
            this.set_red_max_btn.TabIndex = 16;
            this.set_red_max_btn.Text = "Set Max";
            this.set_red_max_btn.UseVisualStyleBackColor = true;
            this.set_red_max_btn.Click += new System.EventHandler(this.set_red_max_btn_Click);
            // 
            // white_max_lbl
            // 
            this.white_max_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.white_max_lbl.AutoSize = true;
            this.white_max_lbl.Location = new System.Drawing.Point(1216, 310);
            this.white_max_lbl.Name = "white_max_lbl";
            this.white_max_lbl.Size = new System.Drawing.Size(23, 13);
            this.white_max_lbl.TabIndex = 15;
            this.white_max_lbl.Text = "n/s";
            // 
            // blue_max_lbl
            // 
            this.blue_max_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blue_max_lbl.AutoSize = true;
            this.blue_max_lbl.Location = new System.Drawing.Point(1216, 274);
            this.blue_max_lbl.Name = "blue_max_lbl";
            this.blue_max_lbl.Size = new System.Drawing.Size(23, 13);
            this.blue_max_lbl.TabIndex = 14;
            this.blue_max_lbl.Text = "n/s";
            // 
            // green_max_lbl
            // 
            this.green_max_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.green_max_lbl.AutoSize = true;
            this.green_max_lbl.Location = new System.Drawing.Point(1216, 242);
            this.green_max_lbl.Name = "green_max_lbl";
            this.green_max_lbl.Size = new System.Drawing.Size(23, 13);
            this.green_max_lbl.TabIndex = 13;
            this.green_max_lbl.Text = "n/s";
            // 
            // red_max_lbl
            // 
            this.red_max_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.red_max_lbl.AutoSize = true;
            this.red_max_lbl.Location = new System.Drawing.Point(1216, 213);
            this.red_max_lbl.Name = "red_max_lbl";
            this.red_max_lbl.Size = new System.Drawing.Size(23, 13);
            this.red_max_lbl.TabIndex = 12;
            this.red_max_lbl.Text = "n/s";
            // 
            // set_min_btn
            // 
            this.set_min_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set_min_btn.Location = new System.Drawing.Point(1069, 342);
            this.set_min_btn.Name = "set_min_btn";
            this.set_min_btn.Size = new System.Drawing.Size(59, 23);
            this.set_min_btn.TabIndex = 11;
            this.set_min_btn.Text = "Set Min";
            this.set_min_btn.UseVisualStyleBackColor = true;
            this.set_min_btn.Click += new System.EventHandler(this.set_min_btn_Click);
            // 
            // white_min_lbl
            // 
            this.white_min_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.white_min_lbl.AutoSize = true;
            this.white_min_lbl.Location = new System.Drawing.Point(1115, 310);
            this.white_min_lbl.Name = "white_min_lbl";
            this.white_min_lbl.Size = new System.Drawing.Size(13, 13);
            this.white_min_lbl.TabIndex = 10;
            this.white_min_lbl.Text = "0";
            // 
            // blue_min_lbl
            // 
            this.blue_min_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blue_min_lbl.AutoSize = true;
            this.blue_min_lbl.Location = new System.Drawing.Point(1115, 274);
            this.blue_min_lbl.Name = "blue_min_lbl";
            this.blue_min_lbl.Size = new System.Drawing.Size(13, 13);
            this.blue_min_lbl.TabIndex = 9;
            this.blue_min_lbl.Text = "0";
            // 
            // green_min_lbl
            // 
            this.green_min_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.green_min_lbl.AutoSize = true;
            this.green_min_lbl.Location = new System.Drawing.Point(1115, 242);
            this.green_min_lbl.Name = "green_min_lbl";
            this.green_min_lbl.Size = new System.Drawing.Size(13, 13);
            this.green_min_lbl.TabIndex = 8;
            this.green_min_lbl.Text = "0";
            // 
            // red_min_lbl
            // 
            this.red_min_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.red_min_lbl.AutoSize = true;
            this.red_min_lbl.Location = new System.Drawing.Point(1115, 213);
            this.red_min_lbl.Name = "red_min_lbl";
            this.red_min_lbl.Size = new System.Drawing.Size(13, 13);
            this.red_min_lbl.TabIndex = 7;
            this.red_min_lbl.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Heater);
            this.tabPage2.Controls.Add(this.DropVal);
            this.tabPage2.Controls.Add(this.Droplbl);
            this.tabPage2.Controls.Add(this.TempVal);
            this.tabPage2.Controls.Add(this.Templbl);
            this.tabPage2.Controls.Add(this.DropGraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1460, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Капли";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Heater
            // 
            this.Heater.Appearance = System.Windows.Forms.Appearance.Button;
            this.Heater.AutoSize = true;
            this.Heater.Location = new System.Drawing.Point(1313, 313);
            this.Heater.Name = "Heater";
            this.Heater.Size = new System.Drawing.Size(95, 23);
            this.Heater.TabIndex = 6;
            this.Heater.Text = "НАГРЕВАТЕЛЬ";
            this.Heater.UseVisualStyleBackColor = true;
            this.Heater.CheckedChanged += new System.EventHandler(this.LEDTrack_Scroll);
            // 
            // DropVal
            // 
            this.DropVal.AutoSize = true;
            this.DropVal.Location = new System.Drawing.Point(1361, 157);
            this.DropVal.Name = "DropVal";
            this.DropVal.Size = new System.Drawing.Size(13, 13);
            this.DropVal.TabIndex = 4;
            this.DropVal.Text = "0";
            // 
            // Droplbl
            // 
            this.Droplbl.AutoSize = true;
            this.Droplbl.Location = new System.Drawing.Point(1294, 157);
            this.Droplbl.Name = "Droplbl";
            this.Droplbl.Size = new System.Drawing.Size(52, 13);
            this.Droplbl.TabIndex = 3;
            this.Droplbl.Text = "DropADC";
            // 
            // TempVal
            // 
            this.TempVal.AutoSize = true;
            this.TempVal.Location = new System.Drawing.Point(1361, 125);
            this.TempVal.Name = "TempVal";
            this.TempVal.Size = new System.Drawing.Size(13, 13);
            this.TempVal.TabIndex = 2;
            this.TempVal.Text = "0";
            // 
            // Templbl
            // 
            this.Templbl.AutoSize = true;
            this.Templbl.Location = new System.Drawing.Point(1294, 125);
            this.Templbl.Name = "Templbl";
            this.Templbl.Size = new System.Drawing.Size(61, 13);
            this.Templbl.TabIndex = 1;
            this.Templbl.Text = "Temprature";
            // 
            // DropGraph
            // 
            this.DropGraph.Location = new System.Drawing.Point(0, 0);
            this.DropGraph.Name = "DropGraph";
            this.DropGraph.ScrollGrace = 0D;
            this.DropGraph.ScrollMaxX = 0D;
            this.DropGraph.ScrollMaxY = 0D;
            this.DropGraph.ScrollMaxY2 = 0D;
            this.DropGraph.ScrollMinX = 0D;
            this.DropGraph.ScrollMinY = 0D;
            this.DropGraph.ScrollMinY2 = 0D;
            this.DropGraph.Size = new System.Drawing.Size(1265, 429);
            this.DropGraph.TabIndex = 0;
            this.DropGraph.UseExtendedPrintDialog = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.IR_val_lbl);
            this.tabPage3.Controls.Add(this.IRTrack);
            this.tabPage3.Controls.Add(this.IR_graph);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1460, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // IR_val_lbl
            // 
            this.IR_val_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IR_val_lbl.AutoSize = true;
            this.IR_val_lbl.Location = new System.Drawing.Point(1354, 159);
            this.IR_val_lbl.Name = "IR_val_lbl";
            this.IR_val_lbl.Size = new System.Drawing.Size(35, 13);
            this.IR_val_lbl.TabIndex = 7;
            this.IR_val_lbl.Text = "label1";
            // 
            // IRTrack
            // 
            this.IRTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IRTrack.Location = new System.Drawing.Point(1267, 111);
            this.IRTrack.Maximum = 100;
            this.IRTrack.Name = "IRTrack";
            this.IRTrack.Size = new System.Drawing.Size(190, 45);
            this.IRTrack.TabIndex = 6;
            this.IRTrack.Scroll += new System.EventHandler(this.LEDTrack_Scroll);
            // 
            // IR_graph
            // 
            this.IR_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IR_graph.Location = new System.Drawing.Point(0, 0);
            this.IR_graph.Name = "IR_graph";
            this.IR_graph.ScrollGrace = 0D;
            this.IR_graph.ScrollMaxX = 0D;
            this.IR_graph.ScrollMaxY = 0D;
            this.IR_graph.ScrollMaxY2 = 0D;
            this.IR_graph.ScrollMinX = 0D;
            this.IR_graph.ScrollMinY = 0D;
            this.IR_graph.ScrollMinY2 = 0D;
            this.IR_graph.Size = new System.Drawing.Size(1256, 398);
            this.IR_graph.TabIndex = 2;
            this.IR_graph.UseExtendedPrintDialog = true;
            // 
            // PUMPLabel
            // 
            this.PUMPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PUMPLabel.AutoSize = true;
            this.PUMPLabel.Location = new System.Drawing.Point(774, 463);
            this.PUMPLabel.Name = "PUMPLabel";
            this.PUMPLabel.Size = new System.Drawing.Size(35, 13);
            this.PUMPLabel.TabIndex = 33;
            this.PUMPLabel.Text = "label1";
            // 
            // PUMPTrack
            // 
            this.PUMPTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PUMPTrack.Location = new System.Drawing.Point(578, 453);
            this.PUMPTrack.Maximum = 100;
            this.PUMPTrack.Name = "PUMPTrack";
            this.PUMPTrack.Size = new System.Drawing.Size(190, 45);
            this.PUMPTrack.TabIndex = 32;
            this.PUMPTrack.Scroll += new System.EventHandler(this.LEDTrack_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "НАСОС";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 485);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PUMPLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PUMPTrack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEDTrack)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IRTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUMPTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConnectMenu;
        private System.Windows.Forms.ToolStripMenuItem отключитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox ColorSelect;
        private System.Windows.Forms.ComboBox ScalSelect;
        private System.Windows.Forms.TrackBar LEDTrack;
        private System.Windows.Forms.Label LEDLabel;
        private System.Windows.Forms.CheckBox OE_check;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl DropGraph;
        private System.Windows.Forms.Label TempVal;
        private System.Windows.Forms.Label Templbl;
        private System.Windows.Forms.Label Droplbl;
        private System.Windows.Forms.Label DropVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button set_red_max_btn;
        private System.Windows.Forms.Label white_max_lbl;
        private System.Windows.Forms.Label blue_max_lbl;
        private System.Windows.Forms.Label green_max_lbl;
        private System.Windows.Forms.Label red_max_lbl;
        private System.Windows.Forms.Button set_min_btn;
        private System.Windows.Forms.Label white_min_lbl;
        private System.Windows.Forms.Label blue_min_lbl;
        private System.Windows.Forms.Label green_min_lbl;
        private System.Windows.Forms.Label red_min_lbl;
        private System.Windows.Forms.Button set_white_max;
        private System.Windows.Forms.Button set_blue_max;
        private System.Windows.Forms.Button set_green_max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label blue_scaled_lbl;
        private System.Windows.Forms.Label green_scaled_lbl;
        private System.Windows.Forms.Label red_scaled_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl IR_graph;
        private System.Windows.Forms.Label IR_val_lbl;
        private System.Windows.Forms.TrackBar IRTrack;
        private System.Windows.Forms.Label PUMPLabel;
        private System.Windows.Forms.TrackBar PUMPTrack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Heater;
    }
}

