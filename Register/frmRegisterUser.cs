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
    public partial class frmRegisterUser : Form
    {
        ConnString cs = new ConnString();
        public int userId = 0; // needs to reset to 0 after saving
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {

        }
        private void Clearfields()
        {
            txtName.Text = "";
            txtUn.Text = "";
            txtPw.Text = "";
            txtCpw.Text = "";
            cmbAl.Text = null;
            rbtnActive.Checked = true;
            rbtnInactive.Checked = false;
            txtName.Focus();
            userId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInfoInsertUpdate();
        }
        private void UserInfoInsertUpdate()
        {
            string insUpt = "";
            string name = txtName.Text;
            string uname = txtUn.Text;
            string pw = txtPw.Text;
            string cpw = txtCpw.Text;
            int accesslevel = 0;
            int stat = 0;
            int isPwMatch = 0;
            int addedBy = UserID.userid;


            if (txtName.Text == "") // checking if name field is empty
            {
                MessageBox.Show("Invalid name", "System Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            else
            { //username and password validation
                if (txtUn.Text == "" || txtPw.Text == "")
                {
                    MessageBox.Show("Check Username or Password", "System Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else // if all set put code here for the insert and udpate command
                {
                    isPwMatch = (cpw == pw ? 1 : 0);
                    if (isPwMatch == 1) // if password matched
                    {
                        if (cmbAl.Text == "") // if access level not selected
                        {
                            MessageBox.Show("Select Access level", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cmbAl.Focus();
                            return;
                        }
                        else
                        {
                            accesslevel = (cmbAl.SelectedIndex == 0 ? 1 : 2);

                            if (rbtnActive.Checked == true && rbtnInactive.Checked == false) // status : 1 for active | 0 for inactive
                            {
                                stat = 1;
                            }
                            else if (rbtnActive.Checked == false && rbtnInactive.Checked == true)
                            {
                                stat = 0;
                            }

                            //checking if there is pending user id to update data
                            if (userId == 0)
                            {
                                //generate user id commadn
                                UserInfoGenUserId();
                            }
                            else
                            {
                                // no action
                            }
                            // insert update command
                            cs.ConnDB();
                            insUpt = "sp_UserInfoInsertUpdate @userid = '" + userId + "' ,@name = '" + name + "',@username = '" + uname + "',@password = '" + pw + "',@accesslevel = '" + accesslevel + "',@status = '" + stat + "',@dateAdded = '" + DateTime.Now + "',@addedby = '" + addedBy + "'";
                            cs.IUD(insUpt);
                            cs.disconMy();
                            MessageBox.Show("User Information successfully saved", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clearfields();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password mismatch", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCpw.Focus();
                        return;
                    }
                }
            }

            
             
        }
        private void UserInfoGenUserId()
        {
            // generate user id
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_UserInfoGenUserId");
            cs.disconMy();
            userId = Convert.ToInt32(dt.Rows[0][0].ToString());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clearfields();
            frmUserSearch frm = new frmUserSearch();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
