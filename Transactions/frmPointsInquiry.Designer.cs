namespace CMJGasStationPointSystem.Transactions
{
    partial class frmPointsInquiry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCusCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.f1LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.rowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.f2ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFt = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblTotalLit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCusCode
            // 
            this.txtCusCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusCode.Location = new System.Drawing.Point(142, 16);
            this.txtCusCode.Name = "txtCusCode";
            this.txtCusCode.Size = new System.Drawing.Size(165, 29);
            this.txtCusCode.TabIndex = 1;
            this.txtCusCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusCode_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(439, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 29);
            this.txtName.TabIndex = 3;
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(142, 49);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(595, 29);
            this.txtAdd.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(16, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(127, 29);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Address";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(313, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(127, 29);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Name";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Location = new System.Drawing.Point(16, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(127, 29);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Customer Code";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.txtAccType);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.txtCusCode);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 126);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.Location = new System.Drawing.Point(16, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(127, 29);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Account type";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAccType
            // 
            this.txtAccType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccType.Location = new System.Drawing.Point(142, 82);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.Size = new System.Drawing.Size(595, 29);
            this.txtAccType.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1LogoutToolStripMenuItem,
            this.f2ResetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 29);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // f1LogoutToolStripMenuItem
            // 
            this.f1LogoutToolStripMenuItem.Name = "f1LogoutToolStripMenuItem";
            this.f1LogoutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.f1LogoutToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.f1LogoutToolStripMenuItem.Text = "F1 - Close";
            this.f1LogoutToolStripMenuItem.Click += new System.EventHandler(this.f1LogoutToolStripMenuItem_Click);
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNo,
            this.dt,
            this.lt});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgw.Location = new System.Drawing.Point(12, 171);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersVisible = false;
            this.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(464, 431);
            this.dgw.TabIndex = 17;
            this.dgw.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgw_RowsAdded);
            this.dgw.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgw_RowsRemoved);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblTotalLit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTotalPoints);
            this.panel2.Controls.Add(this.lblFt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(482, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 431);
            this.panel2.TabIndex = 18;
            // 
            // f2ResetToolStripMenuItem
            // 
            this.f2ResetToolStripMenuItem.Name = "f2ResetToolStripMenuItem";
            this.f2ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.f2ResetToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.f2ResetToolStripMenuItem.Text = "F2 - Clear";
            this.f2ResetToolStripMenuItem.Click += new System.EventHandler(this.f2ResetToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fueled times";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Points earned";
            // 
            // lblFt
            // 
            this.lblFt.AutoSize = true;
            this.lblFt.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFt.ForeColor = System.Drawing.Color.Black;
            this.lblFt.Location = new System.Drawing.Point(57, 64);
            this.lblFt.Name = "lblFt";
            this.lblFt.Size = new System.Drawing.Size(41, 40);
            this.lblFt.TabIndex = 2;
            this.lblFt.Text = "__";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalPoints.Location = new System.Drawing.Point(57, 270);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(41, 40);
            this.lblTotalPoints.TabIndex = 3;
            this.lblTotalPoints.Text = "__";
            // 
            // lblTotalLit
            // 
            this.lblTotalLit.AutoSize = true;
            this.lblTotalLit.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLit.ForeColor = System.Drawing.Color.Green;
            this.lblTotalLit.Location = new System.Drawing.Point(57, 168);
            this.lblTotalLit.Name = "lblTotalLit";
            this.lblTotalLit.Size = new System.Drawing.Size(41, 40);
            this.lblTotalLit.TabIndex = 5;
            this.lblTotalLit.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Liter(s)";
            // 
            // frmPointsInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(775, 614);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPointsInquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPointsInquiry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCusCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtAccType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem f1LogoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem f2ResetToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Label lblFt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalLit;
        private System.Windows.Forms.Label label6;
    }
}