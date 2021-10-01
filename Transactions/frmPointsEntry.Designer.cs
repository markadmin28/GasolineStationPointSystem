namespace CMJGasStationPointSystem.Transactions
{
    partial class frmPointsEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointsEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCusCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRowNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.rowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblAccType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnInquiry = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.f1LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f3InquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tsMainMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scan Customer Code";
            // 
            // txtCusCode
            // 
            this.txtCusCode.BackColor = System.Drawing.Color.White;
            this.txtCusCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusCode.ForeColor = System.Drawing.Color.Black;
            this.txtCusCode.Location = new System.Drawing.Point(17, 52);
            this.txtCusCode.Name = "txtCusCode";
            this.txtCusCode.Size = new System.Drawing.Size(303, 29);
            this.txtCusCode.TabIndex = 0;
            this.txtCusCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusCode_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblRowNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgw);
            this.panel1.Location = new System.Drawing.Point(372, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 463);
            this.panel1.TabIndex = 2;
            // 
            // lblRowNo
            // 
            this.lblRowNo.AutoSize = true;
            this.lblRowNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowNo.ForeColor = System.Drawing.Color.Maroon;
            this.lblRowNo.Location = new System.Drawing.Point(93, 428);
            this.lblRowNo.Name = "lblRowNo";
            this.lblRowNo.Size = new System.Drawing.Size(19, 21);
            this.lblRowNo.TabIndex = 17;
            this.lblRowNo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Row :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Previous transactions";
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNo,
            this.dt,
            this.lt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.Location = new System.Drawing.Point(18, 52);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersVisible = false;
            this.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(464, 373);
            this.dgw.TabIndex = 16;
            this.dgw.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgw_RowsAdded);
            this.dgw.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgw_RowsRemoved);
            this.dgw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgw_KeyDown);
            this.dgw.Leave += new System.EventHandler(this.dgw_Leave);
            // 
            // rowNo
            // 
            this.rowNo.HeaderText = "#";
            this.rowNo.Name = "rowNo";
            this.rowNo.ReadOnly = true;
            this.rowNo.Width = 50;
            // 
            // dt
            // 
            this.dt.HeaderText = "Date & Time";
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.Width = 180;
            // 
            // lt
            // 
            this.lt.HeaderText = "Liter";
            this.lt.Name = "lt";
            this.lt.ReadOnly = true;
            this.lt.Width = 210;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.White;
            this.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.ForeColor = System.Drawing.Color.Black;
            this.txtAdd.Location = new System.Drawing.Point(17, 259);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ReadOnly = true;
            this.txtAdd.Size = new System.Drawing.Size(303, 90);
            this.txtAdd.TabIndex = 6;
            this.txtAdd.Text = "--";
            this.txtAdd.Enter += new System.EventHandler(this.txtAdd_Enter);
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.ForeColor = System.Drawing.Color.Black;
            this.lblAccType.Location = new System.Drawing.Point(53, 394);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(35, 32);
            this.lblAccType.TabIndex = 8;
            this.lblAccType.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Account type";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(17, 117);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(303, 115);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "--";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DimGray;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Location = new System.Drawing.Point(122, 112);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(899, 544);
            this.pnlMain.TabIndex = 10;
            this.pnlMain.Enter += new System.EventHandler(this.pnlMain_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(17, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Customer information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtAdd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtCusCode);
            this.panel3.Controls.Add(this.lblAccType);
            this.panel3.Location = new System.Drawing.Point(23, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 463);
            this.panel3.TabIndex = 10;
            // 
            // ssMain
            // 
            this.ssMain.BackColor = System.Drawing.SystemColors.Control;
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
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.ssMain.Location = new System.Drawing.Point(0, 686);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1144, 26);
            this.ssMain.TabIndex = 11;
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
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(106, 21);
            this.lblUser.Text = "Mark Morales";
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
            this.lblAccLev.Name = "lblAccLev";
            this.lblAccLev.Size = new System.Drawing.Size(106, 21);
            this.lblAccLev.Text = "Administrator";
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
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(94, 21);
            this.toolStripStatusLabel5.Text = "09/02/2021";
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 21);
            this.toolStripStatusLabel2.Text = "1:43 PM";
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.AutoSize = false;
            this.tsMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMainMenu.BackgroundImage")));
            this.tsMainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout,
            this.btnRefresh,
            this.btnInquiry});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 29);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(1144, 76);
            this.tsMainMenu.TabIndex = 12;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 70);
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 70);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // btnInquiry
            // 
            this.btnInquiry.AutoSize = false;
            this.btnInquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInquiry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.Image = ((System.Drawing.Image)(resources.GetObject("btnInquiry.Image")));
            this.btnInquiry.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInquiry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(100, 70);
            this.btnInquiry.Text = "Inquiry";
            this.btnInquiry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInquiry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1LogoutToolStripMenuItem,
            this.f2RefreshToolStripMenuItem,
            this.f3InquiryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // f1LogoutToolStripMenuItem
            // 
            this.f1LogoutToolStripMenuItem.Name = "f1LogoutToolStripMenuItem";
            this.f1LogoutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.f1LogoutToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.f1LogoutToolStripMenuItem.Text = "F1 - Logout";
            this.f1LogoutToolStripMenuItem.Click += new System.EventHandler(this.f1LogoutToolStripMenuItem_Click);
            // 
            // f2RefreshToolStripMenuItem
            // 
            this.f2RefreshToolStripMenuItem.Name = "f2RefreshToolStripMenuItem";
            this.f2RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.f2RefreshToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.f2RefreshToolStripMenuItem.Text = "F2 - Refresh";
            this.f2RefreshToolStripMenuItem.Click += new System.EventHandler(this.f2RefreshToolStripMenuItem_Click);
            // 
            // f3InquiryToolStripMenuItem
            // 
            this.f3InquiryToolStripMenuItem.Name = "f3InquiryToolStripMenuItem";
            this.f3InquiryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.f3InquiryToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.f3InquiryToolStripMenuItem.Text = "F3 - Inquiry";
            this.f3InquiryToolStripMenuItem.Click += new System.EventHandler(this.f3InquiryToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 41);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmPointsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 712);
            this.Controls.Add(this.tsMainMenu);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPointsEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMJ Gas Station Point System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPointsEntry_Load);
            this.SizeChanged += new System.EventHandler(this.frmPointsEntry_SizeChanged);
            this.Enter += new System.EventHandler(this.frmPointsEntry_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtCusCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lt;
        private System.Windows.Forms.Label lblRowNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel12;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lblAccLev;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripButton btnInquiry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem f1LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f3InquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem f2RefreshToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}