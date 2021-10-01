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
    public partial class frmCompanyInfo : Form
    {
        ConnString cs = new ConnString();
        int compId = 0;

        public frmCompanyInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            CompanyInfoLoad();
        }
        private void CompanyInfoLoad()
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManCompanyInfoLoad");
            cs.disconMy();
            if (dt.Rows.Count > 0)
            {
                compId = Convert.ToInt32(dt.Rows[0][0].ToString());
                txtComName.Text = dt.Rows[0][1].ToString();
                txtProp.Text = dt.Rows[0][2].ToString();
                txtTin.Text = dt.Rows[0][3].ToString();
                txtAdd.Text = dt.Rows[0][4].ToString();
            }
            else
            {
                Clearfields();
            }
        }
        private void CompanyInfoInsertUpdate()
        {
            string insUpt = "";
            string comname = txtComName.Text;
            string prop = txtProp.Text;
            string tin = txtTin.Text;
            string add = txtAdd.Text;

            CompanyInfoGenId();// generate company information id

            cs.ConnDB();
            insUpt = "sp_SysManCompanyInfoInsertUpdate @compid = '" + compId + "',@compname = '" + comname + "',@prop = '" + prop + "',@tin = '" + tin + "',@add = '" + add + "',@dateadded = '" + DateTime.Now + "',@addedby = '" + UserID.userid + "'";
            cs.IUD(insUpt);
            cs.disconMy();
            MessageBox.Show("Company information successfully saved.", "Success message",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        private void CompanyInfoGenId()
        {
            DataTable dt = new DataTable();
            cs.ConnDB();
            dt = cs.DISPLAY("sp_SysManCompanyInfoGenId");
            cs.disconMy();
            compId = Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        private void Clearfields()
        {
            compId = 0;
            txtComName.Text = "";
            txtProp.Text = "";
            txtTin.Text = "";
            txtAdd.Text = "";
            txtComName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CompanyInfoInsertUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyInfoDelete();
        }
        private void CompanyInfoDelete()
        {
            if (compId == 0)
            {
                MessageBox.Show("No record to remove", "System message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to remove this record?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)

                {
                    string dlt = "";
                    cs.ConnDB();
                    dlt = "sp_SysManCompanyInfoDelete @compId = '" + compId + "'";
                    cs.IUD(dlt);
                    cs.disconMy();
                    MessageBox.Show("Company information successfully deleted.", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearfields();
                }
                else
                {
                    return;
                }
               
            }

           
        }
    }
}
