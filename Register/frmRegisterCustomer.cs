using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMJGasStationPointSystem.Register
{
    
    public partial class frmRegisterCustomer : Form
    {
        ConnString cs = new ConnString();
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmRegisterCustomer_Load(object sender, EventArgs e)
        {

        }
        private void CustomerInfoSearchById(string cusId)
        {
            DataTable dt = new DataTable();
            int accType = 0;
            cs.ConnDB();
            dt = cs.DISPLAY("sp_CustomerInfoSearchById @cusid = '" + cusId + "' ");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                txtLn.Text = dt.Rows[0][1].ToString();
                txtFn.Text = dt.Rows[0][2].ToString();
                txtMn.Text = dt.Rows[0][3].ToString();
                txtAdd.Text = dt.Rows[0][4].ToString();
                accType = Convert.ToInt32(dt.Rows[0][5].ToString());
                cmbAT.SelectedIndex = (accType == 1 ? 0 : 1);
            }
            else
            {
                txtLn.Text = "";
                txtFn.Text = "";
                txtMn.Text = "";
                txtAdd.Text = "";
                cmbAT.Text = null;
            }
        }
        private void Clearfields()
        {
            txtcid.Text = "";
            txtLn.Text = "";
            txtFn.Text = "";
            txtMn.Text = "";
            txtAdd.Text = "";
            cmbAT.Text = null;           
            txtcid.Enabled = true;
            txtcid.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerInfoInsertUpdate();
        }
        private void CustomerInfoInsertUpdate()
        {
            string insUpt = "";
            string cid = txtcid.Text;
            string cln = txtLn.Text;
            string cfn = txtFn.Text;
            string cmn = txtMn.Text;
            string add = txtAdd.Text;
            int addedBy = UserID.userid;
            string machinename = Environment.MachineName.ToString();

            if (cmbAT.Text == "")
            {
                MessageBox.Show("Select Account type", "Warning Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cmbAT.Focus();
                return;
            }
            else
            {
                int acctype = (cmbAT.SelectedIndex == 0 ? 1 : 2);

                cs.ConnDB();
                insUpt = "sp_CustomerInfoInsertUpdate @cusid = '" + cid + "',@cusln = '" + cln + "',@cusfn = '" + cfn + "',@cusmn = '" + cmn + "',@cusAdd = '" + add + "',@acctype = '" + acctype + "',@dateAdded = '" + DateTime.Now + "',@addedBy = '" + addedBy + "' , @machinename = '" + machinename + "'  ";
                cs.IUD(insUpt);
                cs.disconMy();
                Clearfields();
                MessageBox.Show("Customer Successfully saved.", "Success message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clearfields();
            frmCustomerSearch frm = new frmCustomerSearch();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void txtcid_Leave(object sender, EventArgs e)
        {
            txtcid.Enabled = false;
            CustomerInfoSearchById(txtcid.Text);
        }

        private void txtcid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLn.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerInfoDelete(txtcid.Text);
        }
        private void CustomerInfoDelete(string cusid)
        {
            DataTable dt = new DataTable();
            //validate if there is data record to delete
            cs.ConnDB();
            dt = cs.DISPLAY("sp_CustomerInfoValidate @cusid= '" + cusid + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0) // if data found , execute this command below to remove the data
            {
                DialogResult res = MessageBox.Show("Are you sure you want to permanently remove this Customer information?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string dlt = "";
                    cs.ConnDB();
                    dlt = "sp_CustomerInfoDelete @cusid = '" + cusid + "'";
                    cs.IUD(dlt);
                    cs.disconMy();
                    MessageBox.Show("Customer information successfully removed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearfields();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Customer record not found.", "System Verification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
             
        }
    }
}
