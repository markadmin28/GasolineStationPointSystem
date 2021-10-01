namespace CMJGasStationPointSystem
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAccLev = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRowNo = new System.Windows.Forms.TextBox();
            this.txtTotalLit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPoints = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tsMainMenu.SuspendLayout();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.AutoSize = false;
            this.tsMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMainMenu.BackgroundImage")));
            this.tsMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton2});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 29);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(1292, 77);
            this.tsMainMenu.TabIndex = 0;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 70);
            this.toolStripButton1.Text = "Register";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(100, 70);
            this.toolStripButton4.Text = "Inquiry";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 70);
            this.toolStripButton3.Text = "Reports";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(100, 70);
            this.toolStripButton2.Text = "Transactions";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1292, 29);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "msMain";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemManagementToolStripMenuItem,
            this.databaseManagementToolStripMenuItem,
            this.pointsSettingsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // systemManagementToolStripMenuItem
            // 
            this.systemManagementToolStripMenuItem.Name = "systemManagementToolStripMenuItem";
            this.systemManagementToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.systemManagementToolStripMenuItem.Text = "System Management";
            this.systemManagementToolStripMenuItem.Click += new System.EventHandler(this.systemManagementToolStripMenuItem_Click);
            // 
            // databaseManagementToolStripMenuItem
            // 
            this.databaseManagementToolStripMenuItem.Name = "databaseManagementToolStripMenuItem";
            this.databaseManagementToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.databaseManagementToolStripMenuItem.Text = "Database Management";
            // 
            // pointsSettingsToolStripMenuItem
            // 
            this.pointsSettingsToolStripMenuItem.Name = "pointsSettingsToolStripMenuItem";
            this.pointsSettingsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.pointsSettingsToolStripMenuItem.Text = "Points Settings";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // ssMain
            // 
            this.ssMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ssMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.toolStripStatusLabel10,
            this.lblUser,
            this.toolStripStatusLabel12,
            this.toolStripSplitButton3,
            this.toolStripStatusLabel7,
            this.lblAccLev,
            this.toolStripStatusLabel9,
            this.toolStripSplitButton4,
            this.toolStripStatusLabel4,
            this.lblDate,
            this.toolStripStatusLabel6,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1,
            this.lblTime});
            this.ssMain.Location = new System.Drawing.Point(0, 672);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1292, 26);
            this.ssMain.TabIndex = 12;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 24);
            this.toolStripSplitButton2.Text = "toolStripSplitButton1";
            this.toolStripSplitButton2.ToolTipText = "User";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(49, 21);
            this.toolStripStatusLabel10.Text = "User :";
            // 
            // lblUser
            // 
            this.lblUser.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(17, 21);
            this.lblUser.Text = "_";
            // 
            // toolStripStatusLabel12
            // 
            this.toolStripStatusLabel12.Name = "toolStripStatusLabel12";
            this.toolStripStatusLabel12.Size = new System.Drawing.Size(14, 21);
            this.toolStripStatusLabel12.Text = "|";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 24);
            this.toolStripSplitButton3.Text = "toolStripSplitButton1";
            this.toolStripSplitButton3.ToolTipText = "User";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(103, 21);
            this.toolStripStatusLabel7.Text = "Access Level :";
            // 
            // lblAccLev
            // 
            this.lblAccLev.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblAccLev.Name = "lblAccLev";
            this.lblAccLev.Size = new System.Drawing.Size(17, 21);
            this.lblAccLev.Text = "_";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(14, 21);
            this.toolStripStatusLabel9.Text = "|";
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(32, 24);
            this.toolStripSplitButton4.Text = "toolStripSplitButton1";
            this.toolStripSplitButton4.ToolTipText = "User";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(49, 21);
            this.toolStripStatusLabel4.Text = "Date :";
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 21);
            this.lblDate.Text = "09/02/2021";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(14, 21);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ToolTipText = "User";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 21);
            this.toolStripStatusLabel1.Text = "Time :";
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(67, 21);
            this.lblTime.Text = "1:43 PM";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbStation);
            this.panel1.Controls.Add(this.dgw);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 537);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNo,
            this.cid,
            this.cusName,
            this.tm,
            this.lit,
            this.pts});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgw.Location = new System.Drawing.Point(14, 85);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersVisible = false;
            this.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(796, 419);
            this.dgw.TabIndex = 18;
            this.dgw.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgw_RowsAdded);
            this.dgw.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgw_RowsRemoved);
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(519, 50);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(272, 29);
            this.cmbStation.TabIndex = 19;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbStation_SelectedIndexChanged);
            this.cmbStation.Click += new System.EventHandler(this.cmbStation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Station";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "&View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Recent transactions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // rowNo
            // 
            this.rowNo.HeaderText = "#";
            this.rowNo.Name = "rowNo";
            this.rowNo.ReadOnly = true;
            this.rowNo.Width = 50;
            // 
            // cid
            // 
            this.cid.HeaderText = "C - Code";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cusName
            // 
            this.cusName.HeaderText = "Name";
            this.cusName.Name = "cusName";
            this.cusName.ReadOnly = true;
            this.cusName.Width = 300;
            // 
            // tm
            // 
            this.tm.HeaderText = "Time";
            this.tm.Name = "tm";
            this.tm.ReadOnly = true;
            // 
            // lit
            // 
            this.lit.HeaderText = "No. of Liter";
            this.lit.Name = "lit";
            this.lit.ReadOnly = true;
            this.lit.Width = 110;
            // 
            // pts
            // 
            this.pts.HeaderText = "Points";
            this.pts.Name = "pts";
            this.pts.ReadOnly = true;
            this.pts.Width = 115;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtTotalPoints);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTotalLit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtRowNo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(858, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 380);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total Customers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Summary";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Location = new System.Drawing.Point(858, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 50);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "___________________________________________________";
            // 
            // txtRowNo
            // 
            this.txtRowNo.BackColor = System.Drawing.Color.White;
            this.txtRowNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRowNo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRowNo.ForeColor = System.Drawing.Color.Navy;
            this.txtRowNo.Location = new System.Drawing.Point(16, 121);
            this.txtRowNo.Name = "txtRowNo";
            this.txtRowNo.ReadOnly = true;
            this.txtRowNo.Size = new System.Drawing.Size(363, 50);
            this.txtRowNo.TabIndex = 27;
            this.txtRowNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalLit
            // 
            this.txtTotalLit.BackColor = System.Drawing.Color.White;
            this.txtTotalLit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalLit.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLit.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalLit.Location = new System.Drawing.Point(16, 208);
            this.txtTotalLit.Name = "txtTotalLit";
            this.txtTotalLit.ReadOnly = true;
            this.txtTotalLit.Size = new System.Drawing.Size(363, 50);
            this.txtTotalLit.TabIndex = 29;
            this.txtTotalLit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total No. of liters";
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.BackColor = System.Drawing.Color.White;
            this.txtTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPoints.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalPoints.Location = new System.Drawing.Point(16, 294);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.ReadOnly = true;
            this.txtTotalPoints.Size = new System.Drawing.Size(363, 50);
            this.txtTotalPoints.TabIndex = 31;
            this.txtTotalPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Total points";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1292, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMainMenu);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMJ Gas Station Point System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel12;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lblAccLev;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgw;
        internal System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tm;
        private System.Windows.Forms.DataGridViewTextBoxColumn lit;
        private System.Windows.Forms.DataGridViewTextBoxColumn pts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtRowNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalLit;
        private System.Windows.Forms.Label label6;
    }
}

