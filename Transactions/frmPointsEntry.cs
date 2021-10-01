using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMJGasStationPointSystem.Transactions
{
    public partial class frmPointsEntry : Form
    {
        ConnString cs = new ConnString();
        public frmPointsEntry()
        {
            InitializeComponent();
        }

        private void frmPointsEntry_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width) / 6;
            pnlMain.Top = (this.Height) / 5;
        }
        public void CustomerPointsLoad(string customerid)
        {
            DataTable dt = new DataTable();
            int rowNo = 1;
            cs.ConnDB();
            dt = cs.DISPLAY("sp_TransCustomerPointsLoad @customerid = '" + customerid + "' ");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                dgw.Rows.Clear();
                for (int i =0; i <= dt.Rows.Count -1; i++)
                {
                    dgw.Rows.Add((rowNo), dt.Rows[i][0], dt.Rows[i][1]);
                    rowNo += 1;
                }
                dgw.CurrentRow.Selected = false;
            }
            else
            {
                dgw.Rows.Clear();
            }
        }
        private void CustomerInfoSearchById(string cusId)
        {
            string ln;
            string fn;
            string mn;
            string add;
            int accType;
            string acctypeDesc;

            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_CustomerInfoSearchById @cusid = '" + cusId + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                ln = dt.Rows[0][1].ToString();
                fn = dt.Rows[0][2].ToString();
                mn = dt.Rows[0][3].ToString();
                add = dt.Rows[0][4].ToString();
                accType = Convert.ToInt32(dt.Rows[0][5].ToString());
                acctypeDesc = (accType == 1 ? "Free" : "Premium");

                CustomerPointsLoad(txtCusCode.Text); // load previous transactions


                frmPoints frm = new frmPoints();
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                // if customer code not found
                MessageBox.Show("Invalid customer code", "Verification message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                ln = "--";
                fn = "--";
                mn = "--";
                add = "--";
                accType = 0;
                acctypeDesc = "--";
                txtCusCode.Focus();
                txtCusCode.SelectAll();
               
            }
            txtName.Text = ln + ", " + fn + ", " + mn;
            txtAdd.Text = add;
            lblAccType.Text = acctypeDesc;


        }

        private void txtCusCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustomerInfoSearchById(txtCusCode.Text);
            }
        }

        private void dgw_Leave(object sender, EventArgs e)
        {
            if (dgw.Rows.Count > 0)
            {
                dgw.CurrentRow.Selected = false;
            }
            else
            {
                //no action
            }
        }

        private void dgw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount();
        }
        private void RowCount()
        {
            lblRowNo.Text = dgw.Rows.Count.ToString();
        }

        private void dgw_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount();
        }

        private void frmPointsEntry_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                return;
            }
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void f1LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLogout.PerformClick();
        }

        private void frmPointsEntry_Enter(object sender, EventArgs e)
        {
          
        }

        private void pnlMain_Enter(object sender, EventArgs e)
        {
            txtCusCode.Focus();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Clearfields();
        }
        private void Clearfields()
        {
            dgw.Rows.Clear();
            txtCusCode.Text = "";
            txtName.Text = "--";
            txtAdd.Text = "--";
            lblAccType.Text = "--";
            txtCusCode.Focus();
        }

        private void f2RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void f3InquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnInquiry.PerformClick();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            frmPointsInquiry frm = new frmPointsInquiry();
            frm.ShowDialog();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtAdd_Enter(object sender, EventArgs e)
        {
            dgw.Focus();
        }

        private void dgw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (dgw.Rows.Count > 0)
                {
                    txtCusCode.Focus();

                }
                else
                {
                    //no action
                }
            }
          
        }
    }
}
