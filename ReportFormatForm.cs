using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservation_App.ReservationInformations;

namespace Reservation_App
{
    public partial class ReportFormatForm : Form
    {
        private ReportManager manager;
        private string data;
        public ReportFormatForm(ReportManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void radio_G_D_T_CheckedChanged(object sender, EventArgs e)
        {
            data = manager.BuildGDT();

        }

        private void radio_D_G_T_CheckedChanged(object sender, EventArgs e)
        {
            data = manager.BuildDGT();

        }

        private void radio_T_G_D_CheckedChanged(object sender, EventArgs e)
        {
            data = manager.BuildTGD();

        }

        private void radio_D_T_G_CheckedChanged(object sender, EventArgs e)
        {
            data = manager.BuildDTG();

        }

        private void radio_G_T_D_CheckedChanged(object sender, EventArgs e)
        {
            data = manager.BuildGTD();

        }

        private void radio_T_D_G_CheckedChanged(object sender, EventArgs e)
        {
            data = manager.BuildTDG();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            manager.FileWriter(data);
        }
    }
}
