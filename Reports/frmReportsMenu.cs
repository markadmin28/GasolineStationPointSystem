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
    public partial class frmReportsMenu : Form
    {
        public frmReportsMenu()
        {
            InitializeComponent();
        }

        private void btnTransRep_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.ShowDialog();
        }
    }
}
