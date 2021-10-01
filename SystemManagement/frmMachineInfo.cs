using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMJGasStationPointSystem.SystemManagement
{
    public partial class frmMachineInfo : Form
    {
        ConnString cs = new ConnString();
        int MachineId = 0;
        public frmMachineInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMachineInfo_Load(object sender, EventArgs e)
        {
            txtComName.Text = Environment.MachineName.ToString();
            LoadStation();
            LoadMachineInfo(txtComName.Text);
        }
        private void MachineInfoDelete(string machinename)
        {
            DataTable dt = new DataTable();
            //validate registered machine
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManMachineInfoValidate @machinename = '" + machinename + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0 )
            {
                DialogResult res = MessageBox.Show("Are you sure you want to remove this machine information?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string dlt = "";
                    cs.ConnDB();
                    dlt = "sp_SysManMachineInfoDelete @machinename = '" + machinename + "'";
                    cs.IUD(dlt);
                    cs.disconMy();
                    MessageBox.Show("Machine information successfully removed.", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MachineId = 0;
                    txtMaNo.Text = "";
                    cmbSta.Text = null;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Unable to delete record does not exist", "System Verification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

           
        }
        private void LoadStation()
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManStationSearch");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                cmbSta.Items.Clear();
               for (int i =0; i <= dt.Rows.Count -1; i ++)
                {
                    cmbSta.Items.Add(dt.Rows[i][1]);
                }
            }
            else
            {
                //no aciton
            }
        }
        private void MachineInfoInsertUpdate()
        {
            string insUpt = "";
            DataTable dtStation = new DataTable();
            int stationid = 0;
            //validate if station is existing
            cs.ConnDB();
            dtStation = cs.DISPLAY("sp_SysManMachineINfoValidateStation @stationname = '" + cmbSta.Text + "'");
            cs.disconMy();
            if (dtStation.Rows.Count > 0)
            {
                stationid = Convert.ToInt32(dtStation.Rows[0][0].ToString());

                MachineInfoGenId();// generate machine id 10000 series
                cs.ConnDB();
                insUpt = "sp_SysManMachineInfoInsertUpdate @machineId = '" + MachineId + "',@machinename = '" + txtComName.Text + "',@machineno = '" + txtMaNo.Text + "' ,@stationid = '" + stationid + "',@dateadded = '" + DateTime.Now + "',@addedby = '" + UserID.userid + "'";
                cs.IUD(insUpt);
                cs.disconMy();
                MessageBox.Show("Machine information successfully saved", "Success message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                stationid = 0;
            }
            else
            {
                MessageBox.Show("Select valid station" , "System validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cmbSta.Focus();
                stationid = 0;
                return;
            }

           
        }
        private void LoadMachineInfo(string machinename)
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManMachineInfoLoad @machinename = '" + machinename + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                txtMaNo.Text = dt.Rows[0][1].ToString();
                cmbSta.Text = dt.Rows[0][2].ToString();
            }
            else
            {
                txtMaNo.Text = "";
                cmbSta.Text = null;
            }
        }
        private void MachineInfoGenId()
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManMachineInfoGenId");
            cs.disconMy();
            MachineId = Convert.ToInt32(dt.Rows[0][0].ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MachineInfoInsertUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MachineInfoDelete(txtComName.Text);
        }
    }
}
