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
    public partial class frmPointsInquiry : Form
    {
        ConnString cs = new ConnString();
        public frmPointsInquiry()
        {
            InitializeComponent();
        }

        private void frmPointsInquiry_Load(object sender, EventArgs e)
        {

        }
        private void CustomerPointsLoad(string customerid)
        {
            DataTable dt = new DataTable();
            int rowNo = 1;
            cs.ConnDB();
            dt = cs.DISPLAY("sp_TransCustomerPointsLoad @customerid = '" + customerid + "' ");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                dgw.Rows.Clear();
                for (int i =0; i <= dt.Rows.Count -1; i ++)
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
        private void CustomerPointsInquiry(string customerid)
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_TransCustomerPointsInquiry @customerid = '" + customerid + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                lblTotalLit.Text = dt.Rows[0][0].ToString();
                lblTotalPoints.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                lblTotalLit.Text = "0";
                lblTotalPoints.Text = "0";
            }
        }
        private void CustomerInfoLoad(string customerid)
        {
            string ln = "";
            string fn = "";
            string mn = "";
            string add = "";
            string accTypeDesc = "";
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_CustomerInfoSearchById @cusid = '" + customerid + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                ln = dt.Rows[0][1].ToString();
                fn = dt.Rows[0][2].ToString();
                mn = dt.Rows[0][3].ToString();
                add = dt.Rows[0][4].ToString();
                accTypeDesc = ((Convert.ToInt32(dt.Rows[0][5].ToString())) == 1 ? "Free" : "Premium");
                CustomerPointsLoad(customerid); // load customer previous transaction
                CustomerPointsInquiry(customerid);// get total liter and points
            }
            else
            {
                MessageBox.Show("No data found", "Verification message",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                ln = "";
                fn = "";
                mn = "";
                add = "";
                accTypeDesc = "";
                txtCusCode.Focus();
                txtCusCode.SelectAll();
                dgw.Rows.Clear();
                lblTotalLit.Text = "0";
                lblTotalPoints.Text = "0";
            }
            txtName.Text = ln + ", " + fn + ", " + mn;
            txtAdd.Text = add;
            txtAccType.Text = accTypeDesc;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void f1LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCusCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustomerInfoLoad(txtCusCode.Text);
            }
        }

        private void f2ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
        private void Clearfields()
        {
            txtCusCode.Text = "";
            txtName.Text = "";
            txtAdd.Text = "";
            txtAccType.Text = "";
            dgw.Rows.Clear();
            lblTotalLit.Text = "0";
            lblTotalPoints.Text = "0";
        }

        private void dgw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount();
        }
        private void RowCount()
        {
            lblFt.Text = dgw.Rows.Count.ToString();
        }

        private void dgw_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount();
        }
    }
}
