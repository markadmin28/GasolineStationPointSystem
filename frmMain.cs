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
    public partial class frmMain : Form
    {
        ConnString cs = new ConnString();
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register.frmRegisterMenu frm = new Register.frmRegisterMenu();
            frm.ShowDialog();
        }

        private void systemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemManagement.frmSystemManagementMenu frm = new SystemManagement.frmSystemManagementMenu();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Transactions.frmPointsEntry frm = new Transactions.frmPointsEntry();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timerMain.Start();
            LoadUserInfo();
            LoadStation();// load station list
        }
        private void LoadStation()
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManStationSearch");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                cmbStation.Items.Clear();
                for (int i =0; i <= dt.Rows.Count -1; i++)
                {
                    cmbStation.Items.Add((dt.Rows[i][1]));
                }
            }
            else
            {
                cmbStation.Items.Clear();
            }
        }
        private void LoadUserInfo()
        {

            lblUser.Text = UserName.userName.ToString();
            lblAccLev.Text = (AccessLevel.accessLevel == 1 ? "User" : "Administrator");
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyy");
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerMain.Stop();
        }

        private void cmbStation_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCustomerRecentTrans(cmbStation.Text);
        }
        private void CalcTotalLit_Points()
        {
            decimal totalLit = 0;
            decimal totalPoints = 0;
            for (int i =0; i <= dgw.Rows.Count -1; i++)
            {
                totalLit += Convert.ToDecimal(dgw.Rows[i].Cells[4].Value.ToString());
                totalPoints += Convert.ToDecimal(dgw.Rows[i].Cells[5].Value.ToString());
            }
            txtTotalLit.Text = totalLit.ToString("n2");
            txtTotalPoints.Text = totalPoints.ToString("n0");
        }
        private void LoadCustomerRecentTrans(string stationName)
        {
            int claimed = 0;
            int rowNo = 1;
            DataTable dt = new DataTable();

            if (cmbStation.Text == "")
            {
                MessageBox.Show("Select station", "Validation message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cmbStation.DroppedDown = true;
                cmbStation.Focus();
                return;
            }
            else
            {
                cs.ConnDB();
                dt = cs.DISPLAY("sp_CustomerRecentTrans @dateNow = '" + DateTime.Now + "',@claimed = '" + claimed + "',@stationname = '" + stationName + "'");
                cs.disconMy();
                if (dt.Rows.Count > 0)
                {
                    dgw.Rows.Clear();
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        dgw.Rows.Add((rowNo), dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][4], dt.Rows[i][5]);
                        rowNo += 1;
                    }
                    dgw.CurrentRow.Selected = false;
                    CalcTotalLit_Points(); // calculate total liters
                }
                else
                {
                    MessageBox.Show("No data found", "System message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    dgw.Rows.Clear();
                    return;
                }
            }

         
        }

        private void dgw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount();
        }
        private void RowCount()
        {
            txtRowNo.Text = dgw.Rows.Count.ToString();
        }

        private void dgw_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Reports.frmReportsMenu frm = new Reports.frmReportsMenu();
            frm.ShowDialog();
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgw.Rows.Count > 0)
            {
                dgw.Rows.Clear();
                txtTotalLit.Text = "0";
                txtTotalPoints.Text = "0";
                txtRowNo.Text = "0";
            }
            else
            {
                //no action
            }
        }
    }
}
