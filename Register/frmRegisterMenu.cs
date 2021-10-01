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
    public partial class frmRegisterMenu : Form
    {
        public frmRegisterMenu()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmRegisterCustomer frm = new frmRegisterCustomer();
            frm.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser frm = new frmRegisterUser();
            frm.ShowDialog();
        }
    }
}
