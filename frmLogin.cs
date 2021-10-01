using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMJGasStationPointSystem
{
    public partial class frmLogin : Form
    {
        ConnString cs = new ConnString();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width) / 7;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit the program ?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPw.Focus();
            }
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtUn.Text, txtPw.Text);
        }
        private void Login(string un, string pw)
        {
            DataTable dt = new DataTable();
            int accessLevel = 0;
            int stat = 0;

            if (txtUn.Text == "") // if username field is empty
            {
                MessageBox.Show("Invalid Username entry", "Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUn.Focus();
                return;
            }
            else
            {
                if (txtPw.Text == "") // if passowrd field is empty
                {
                    MessageBox.Show("Invalid Password entry", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUn.Focus();
                    return;
                }
                else
                {
                    cs.ConnDB();
                    dt = cs.DISPLAY("sp_UserLogin @un = '" + un + "',@pw = '" + pw + "'");
                    cs.disconMy();
                    if (dt.Rows.Count > 0)
                    {
                        
                        UserID.userid = Convert.ToInt32(dt.Rows[0][0].ToString());
                        UserName.userName = dt.Rows[0][1].ToString();
                        UserUserName.userUsername = dt.Rows[0][2].ToString();
                        accessLevel = Convert.ToInt32(dt.Rows[0][3].ToString());
                        AccessLevel.accessLevel = accessLevel;
                        stat = Convert.ToInt32(dt.Rows[0][4].ToString());

                        if (stat == 0) // if status is inactive
                        {
                            MessageBox.Show("Account Inactive!", "Validation message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (accessLevel == 1)
                            {
                                Transactions.frmPointsEntry frm = new Transactions.frmPointsEntry();
                                frm.ShowDialog();
                            }
                            else if (accessLevel == 2)
                            {
                                frmMain frm = new frmMain();
                                frm.ShowDialog();
                            }
                             
                        }
                        txtUn.Focus();
                        txtUn.Text = "";
                        txtPw.Text = "";
                       
                    }
                    else
                    {
                        stat = 0;
                        AccessLevel.accessLevel = 0;
                        UserID.userid = 0;
                        UserUserName.userUsername = "";
                        UserName.userName = "";
                        accessLevel = 0;
                        MessageBox.Show("Invalid Account", "Validation message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }
    }
}
