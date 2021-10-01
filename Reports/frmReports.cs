using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMJGasStationPointSystem.Reports
{
    public partial class frmReports : Form
    {
        ConnString cs = new ConnString();
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            LoadStation();
        }
        private void TransactionReport()
        {
            
            int rowNo = 1;
            DataTable dt = new DataTable();

            if (cmbStation.Text == "")
            {
                MessageBox.Show("Select Account type", "Validateion message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStation.Focus();
                cmbStation.DroppedDown = true;
                return;
            }
            else
            {
                cs.ConnDB();                           
                dt = cs.DISPLAY("sp_ReportsTransReport @dateStart = '" + dtStart.Text + "', @dateCutoff = '" + dtCutoff.Text + "', @stationname = '" + cmbStation.Text + "'");
                cs.disconMy();
               
                if (dt.Rows.Count > 0)
                {
                    dgw.Rows.Clear();
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        dgw.Rows.Add((rowNo), dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][4]);
                    }
                    dgw.CurrentRow.Selected = false;
                }
                else
                {
                    MessageBox.Show("No data found", "System message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    dgw.Rows.Clear();
                    return;
                }
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
                cmbStation.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    cmbStation.Items.Add((dt.Rows[i][1]));
                }
            }
            else
            {
                cmbStation.Items.Clear();
            }
        }

        private void dgw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount();
        }
        private void RowCount()
        {
            lblRowNo.Text = dgw.Rows.Count.ToString("n0");
        }

        private void dgw_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
