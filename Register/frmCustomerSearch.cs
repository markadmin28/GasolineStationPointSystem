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
    public partial class frmCustomerSearch : Form
    {
        ConnString cs = new ConnString();
        public frmCustomerSearch()
        {
            InitializeComponent();
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {

        }
        private void SearchCustomer(string keyword)
        {
            DataTable dt = new DataTable();
            int rowNo = 1;

            cs.ConnDB();
            dt = cs.DISPLAY("sp_CustomerInfoSearch @keyword = '" + keyword  + "'");
            cs.disconMy();
            dgw.Rows.Clear();
            if (dt.Rows.Count > 0)
            {                
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dgw.Rows.Add((rowNo), dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);
                    rowNo += 1;
                }
                dgw.CurrentRow.Selected = false;
            }
            else
            {
                dgw.Rows.Clear();               
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer(txtSearch.Text);
        }

        private void dgw_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rowCount();
        }
        private void rowCount()
        {
            sRows.Text = dgw.Rows.Count.ToString();
        }

        private void dgw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            rowCount();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               
               if (dgw.Rows.Count > 0)
                {
                    dgw.Focus();
                    dgw.CurrentRow.Selected = true;                   
                }
               else
                {
                    txtSearch.Focus();
                }
            }
        }

        private void dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw.Rows.Count > 0)
            {
                frmRegisterCustomer frm = (frmRegisterCustomer)Owner;
                frm.txtcid.Text = dgw.CurrentRow.Cells[1].Value.ToString();
                this.Dispose();
            }
            else
            {
                //no action
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
