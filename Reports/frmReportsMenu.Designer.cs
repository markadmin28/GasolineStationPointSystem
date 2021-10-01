namespace CMJGasStationPointSystem.Reports
{
    partial class frmReportsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportsMenu));
            this.btnTransRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransRep
            // 
            this.btnTransRep.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransRep.Image = ((System.Drawing.Image)(resources.GetObject("btnTransRep.Image")));
            this.btnTransRep.Location = new System.Drawing.Point(30, 23);
            this.btnTransRep.Name = "btnTransRep";
            this.btnTransRep.Size = new System.Drawing.Size(177, 82);
            this.btnTransRep.TabIndex = 2;
            this.btnTransRep.Text = "Transaction reports";
            this.btnTransRep.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTransRep.UseVisualStyleBackColor = false;
            this.btnTransRep.Click += new System.EventHandler(this.btnTransRep_Click);
            // 
            // frmReportsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(552, 128);
            this.Controls.Add(this.btnTransRep);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReportsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTransRep;
    }
}