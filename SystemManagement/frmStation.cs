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
    public partial class frmStation : Form
    {
        ConnString cs = new ConnString();
        int StationID = 0;
        public frmStation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmStation_Load(object sender, EventArgs e)
        {
            StationSearch();
        }
        private void RowCount()
        {
            sRows.Text = dgw.Rows.Count.ToString();
        }
        private void StationSearch()
        {
            string stationname = txtStaName.Text;
            DataTable dt = new DataTable();
            int rowNo = 1;
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManStationSearch @stationname = '" + stationname + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                dgw.Rows.Clear();
                for ( int i  =0; i <= dt.Rows.Count -1; i ++)
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
        private void StationInsertUpdate()
        {
            string insUpt = "";
            string stationname = txtStaName.Text;

            //check if station name field is empty
            if (stationname == "")
            {
                MessageBox.Show("Invalid Station name entry", "System validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtStaName.Focus();
                return;
            }
            else
            {
                //check if there is no pending station id to udpate data
                if (StationID == 0)
                {
                    StationGenId();// gen station id 1000 series
                }
                else
                {
                    // no action
                }

                cs.ConnDB();
                insUpt = "sp_SysManStationInsertUpdate @stationid = '" + StationID + "',@stationname = '" + stationname + "',@dateadded = '" + DateTime.Now + "',@addedby = '" + UserID.userid + "'";
                cs.IUD(insUpt);
                cs.disconMy();
                MessageBox.Show("Successfully saved", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clearfields();
                StationSearch();// display record after saving
            }
           
        }
        private void Clearfields()
        {
            StationID = 0;
            txtStaName.Text = "";
            txtStaName.Focus();
        }
        private void StationGenId()
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManStationGenId");
            cs.disconMy();
            StationID = Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StationInsertUpdate();
        }

        private void txtStaName_TextChanged(object sender, EventArgs e)
        {
            StationSearch();
        }

        private void dgw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount();
        }

        private void dgw_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount();
        }

        private void dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgw.Rows.Count > 0)
            {
                StationID = Convert.ToInt32(dgw.CurrentRow.Cells[1].Value.ToString());
                txtStaName.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                txtStaName.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StationDelete();
        }
        private void StationDelete()
        {
            DataTable dt = new DataTable();
            string dlt = "";
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManStationValidate @stationid = '" + StationID + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to remove this record?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                 
                    cs.ConnDB();
                    dlt = "sp_SysManStationDelete @stationid = '" + StationID + "'";
                    cs.IUD(dlt);
                    cs.disconMy();
                    Clearfields();
                    StationSearch();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No record to delete.", "Warning message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtStaName.Focus();
                return;
            }

          
        }
    }
}
