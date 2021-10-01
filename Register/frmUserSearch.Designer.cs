namespace CMJGasStationPointSystem.Register
{
    partial class frmUserSearch
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.sRowCount = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.sRowCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(701, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(248, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "(Search Name)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 29);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNo,
            this.uid,
            this.name,
            this.un,
            this.pw,
            this.al,
            this.Stat});
            this.dgw.Location = new System.Drawing.Point(12, 44);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersVisible = false;
            this.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(764, 395);
            this.dgw.TabIndex = 15;
            this.dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellDoubleClick);
            this.dgw.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgw_RowsAdded);
            this.dgw.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgw_RowsRemoved);
            // 
            // sRowCount
            // 
            this.sRowCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sRows});
            this.sRowCount.Location = new System.Drawing.Point(0, 443);
            this.sRowCount.Name = "sRowCount";
            this.sRowCount.Size = new System.Drawing.Size(786, 22);
            this.sRowCount.TabIndex = 18;
            this.sRowCount.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Rows :";
            // 
            // sRows
            // 
            this.sRows.Name = "sRows";
            this.sRows.Size = new System.Drawing.Size(13, 17);
            this.sRows.Text = "0";
            // 
            // rowNo
            // 
            this.rowNo.HeaderText = "#";
            this.rowNo.Name = "rowNo";
            this.rowNo.ReadOnly = true;
            this.rowNo.Width = 60;
            // 
            // uid
            // 
            this.uid.HeaderText = "User ID";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 350;
            // 
            // un
            // 
            this.un.HeaderText = "Username";
            this.un.Name = "un";
            this.un.ReadOnly = true;
            this.un.Visible = false;
            // 
            // pw
            // 
            this.pw.HeaderText = "Password";
            this.pw.Name = "pw";
            this.pw.ReadOnly = true;
            this.pw.Visible = false;
            // 
            // al
            // 
            this.al.HeaderText = "Access level";
            this.al.Name = "al";
            this.al.ReadOnly = true;
            this.al.Width = 150;
            // 
            // Stat
            // 
            this.Stat.HeaderText = "Status";
            this.Stat.Name = "Stat";
            this.Stat.ReadOnly = true;
            // 
            // frmUserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 465);
            this.Controls.Add(this.sRowCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgw);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Masterlist";
            this.Load += new System.EventHandler(this.frmUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.sRowCount.ResumeLayout(false);
            this.sRowCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.StatusStrip sRowCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn un;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.DataGridViewTextBoxColumn al;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stat;
    }
}