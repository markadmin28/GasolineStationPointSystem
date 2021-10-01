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
    public partial class frmUserSearch : Form
    {
        ConnString cs = new ConnString();
        public frmUserSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUserSearch_Load(object sender, EventArgs e)
        {

        }
        private void UserSearch(string keyword)
        {
            DataTable dt = new DataTable();
            int rowNo = 0;
            cs.ConnDB();
            dt = cs.DISPLAY("sp_UserInfoSearch @keyword = '" + keyword + "'");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                dgw.Rows.Clear();
                for (int i =0; i <= dt.Rows.Count -1; i ++)
                {
                    dgw.Rows.Add((rowNo), dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5]);
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
            UserSearch(txtSearch.Text);
        }
        private void RowCount()
        {
            sRows.Text = dgw.Rows.Count.ToString();
        }

        private void dgw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount();
        }

        private void dgw_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount();
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
            string stat = "";

            frmRegisterUser frm = (frmRegisterUser)Owner;
            if (dgw.Rows.Count > 0)
            {
                frm.userId = Convert.ToInt32(dgw.CurrentRow.Cells[1].Value.ToString());
                frm.txtName.Text = dgw.CurrentRow.Cells[2].Value.ToString();
                frm.txtUn.Text = dgw.CurrentRow.Cells[3].Value.ToString();
                frm.txtPw.Text = dgw.CurrentRow.Cells[4].Value.ToString();
                frm.cmbAl.Text = dgw.CurrentRow.Cells[5].Value.ToString();
                stat = dgw.CurrentRow.Cells[6].Value.ToString();
                if (stat == "Active")
                {
                    frm.rbtnActive.Checked = true;
                }
                else if (stat == "Inactive")
                {
                    frm.rbtnInactive.Checked = true;
                }
                this.Dispose();
            }
            else
            {
                //no action
            }
        }
    }
}
