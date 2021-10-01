namespace CMJGasStationPointSystem.Reports
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtCutoff = new System.Windows.Forms.DateTimePicker();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.stat = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRowNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.stat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(115, 19);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(126, 29);
            this.dtStart.TabIndex = 0;
            // 
            // dtCutoff
            // 
            this.dtCutoff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCutoff.Location = new System.Drawing.Point(115, 47);
            this.dtCutoff.Name = "dtCutoff";
            this.dtCutoff.Size = new System.Drawing.Size(126, 29);
            this.dtCutoff.TabIndex = 1;
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(345, 47);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(223, 29);
            this.cmbStation.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(17, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "From ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(17, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "To ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(247, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 29);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Station ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.dtCutoff);
            this.panel1.Controls.Add(this.cmbStation);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 96);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(753, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "&View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(845, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Print";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tm,
            this.cid,
            this.cusName,
            this.lit,
            this.pts,
            this.at});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.Location = new System.Drawing.Point(12, 126);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersVisible = false;
            this.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(1038, 440);
            this.dgw.TabIndex = 6;
            this.dgw.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgw_RowsAdded);
            this.dgw.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgw_RowsRemoved);
            this.dgw.Leave += new System.EventHandler(this.dgw_Leave);
            // 
            // stat
            // 
            this.stat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblRowNo});
            this.stat.Location = new System.Drawing.Point(0, 581);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(1066, 22);
            this.stat.TabIndex = 20;
            this.stat.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Rows :";
            // 
            // lblRowNo
            // 
            this.lblRowNo.Name = "lblRowNo";
            this.lblRowNo.Size = new System.Drawing.Size(13, 17);
            this.lblRowNo.Text = "0";
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
            this.dt.HeaderText = "Date";
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            // 
            // tm
            // 
            this.tm.HeaderText = "Time";
            this.tm.Name = "tm";
            this.tm.ReadOnly = true;
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
            // at
            // 
            this.at.HeaderText = "Account type";
            this.at.Name = "at";
            this.at.ReadOnly = true;
            this.at.Width = 140;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(937, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "&Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 603);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction report";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.stat.ResumeLayout(false);
            this.stat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtCutoff;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.StatusStrip stat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblRowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lit;
        private System.Windows.Forms.DataGridViewTextBoxColumn pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn at;
        private System.Windows.Forms.Button button3;
    }
}