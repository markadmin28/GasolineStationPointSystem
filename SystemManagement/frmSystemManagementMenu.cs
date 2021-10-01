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
    public partial class frmSystemManagementMenu : Form
    {
        public frmSystemManagementMenu()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmStation frm = new frmStation();
            frm.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmMachineInfo frm = new frmMachineInfo();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCompanyInfo frm = new frmCompanyInfo();
            frm.ShowDialog();
        }
    }
}
