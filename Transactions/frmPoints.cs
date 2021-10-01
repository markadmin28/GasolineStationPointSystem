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
    public partial class frmPoints : Form
    {
        ConnString cs = new ConnString();
        decimal pointsId = 0;

        public frmPoints()
        {
            InitializeComponent();
        }

        private void frmPoints_Load(object sender, EventArgs e)
        {

        }
        
        private void CustomerPointsInsertUpdate()
        {
            string insUpt = "";
            string customerId = "";
            int claimed = 0; // 0 since the customer didn't claimed his/her points yet.

            if (txtLit.Text == "") // if liter field is empty
            {
                MessageBox.Show("Invalid entry.", "Validation message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtLit.SelectAll();
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Do you want to proceed?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    frmPointsEntry frm = (frmPointsEntry)Owner;
                    customerId = frm.txtCusCode.Text;
                    CustomerPointsGenId(); //generate points id

                    cs.ConnDB();
                    insUpt = "sp_TransCustomerPointsInsertUpdate @pointsid = '" + pointsId + "',@customerid = '" + customerId + "',@liter = '" + txtLit.Text + "',@dateadded = '" + DateTime.Now + "',@addedby = '" + UserID.userid + "' ,@claimed = '" + claimed + "'";
                    cs.IUD(insUpt);
                    cs.disconMy();
                    MessageBox.Show("Customer points successfully saved.", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.txtCusCode.SelectAll();
                    frm.CustomerPointsLoad(customerId);
                    this.Dispose();
                }
                else
                {
                    return;
                }
            }
           
        }
        private void CustomerPointsGenId()
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_TransCustomerPointsGenId");
            cs.disconMy();
            pointsId = Convert.ToDecimal(dt.Rows[0][0].ToString());
        }

        private void txtLit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // when hitting enter key on your keyboard
            {
                CustomerPointsInsertUpdate();
            }
            if (e.KeyCode == Keys.Escape) // exit | close form
            {
                this.Dispose();
            }
        }

        private void txtLit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
                {
                e.Handled = true;
            }
        }
    }
}
