using System;
using System.Windows.Forms;
using Reservation_App.ReservationInformations;

namespace Reservation_App
{
    public partial class ReportForm : Form
    {

        private ReservationGeneralInfo _generalInfo;
        private ReservationDetailInfo _detailInfo;
        private ReportInfo _reportInfo;
        private ReservationReportBuilderBase _builder;
        private ReportManager _manager;
        public ReportForm(ReservationGeneralInfo generalInfo, ReservationDetailInfo detailInfo)
        {
            InitializeComponent();
            this._generalInfo = generalInfo;
            this._detailInfo = detailInfo;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            _reportInfo = new ReportInfo
            {
                GeneralInfo = this._generalInfo,
                DetailInfo = this._detailInfo,
                TotalPrice = 13232
            };
            btn_Accommodation.Text = _detailInfo.AccommodationInfo + @" iptal et";
            btn_Transportation.Text = _detailInfo.TransportationInfo + @" iptal et";
        }

        private void btn_HtmlRapor_Click(object sender, EventArgs e)
        {
            _builder = new HTMLReportBuilder(_reportInfo);
            _manager = new ReportManager(_builder);
            var frm = new ReportFormatForm(_manager);
            frm.ShowDialog();

        }

        private void btn_XmlRapor_Click(object sender, EventArgs e)
        {
            _builder = new XMLReportBuilder(_reportInfo);
            _manager = new ReportManager(_builder);
            var frm = new ReportFormatForm(_manager);
            frm.ShowDialog();

        }
        private void btn_JsonRapor_Click(object sender, EventArgs e)
        {
            _builder = new JSONReportBuilder(_reportInfo);
            _manager = new ReportManager(_builder);
            var frm = new ReportFormatForm(_manager);
            frm.ShowDialog();

        }

        private void btn_Transportation_Click(object sender, EventArgs e)
        {
            var result1 = MessageBox.Show(_detailInfo.TransportationInfo + @" Iptal etmek istediğinize emin misiniz?", "Iptal Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result1 == DialogResult.Yes)
            {
                var result2 = MessageBox.Show(_detailInfo.AccommodationInfo+ @" Iptal etmek ister misiniz ?", "Iptal Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result2 == DialogResult.Yes)
                {
                    MessageBox.Show(_detailInfo.TransportationInfo + @" ve " + _detailInfo.AccommodationInfo + " iptal edilmiştir.");
                    this.Close();
                    return;
                }
                this.Close();
                MessageBox.Show(_detailInfo.TransportationInfo + @" iptal edilmiştir.");
            }
        }

        private void btn_Accommodation_Click(object sender, EventArgs e)
        {
            var result1 = MessageBox.Show(_detailInfo.AccommodationInfo + @" Iptal etmek istediğinize emin misiniz?", "Iptal Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result1 == DialogResult.Yes)
            {
                var result2 = MessageBox.Show(_detailInfo.TransportationInfo + @" Iptal etmek ister misiniz ?", "Iptal Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result2 == DialogResult.Yes)
                {
                    MessageBox.Show(_detailInfo.AccommodationInfo + @" ve " + _detailInfo.TransportationInfo + " iptal edilmiştir."); 
                    this.Close();
                    return;
                }
                MessageBox.Show(_detailInfo.AccommodationInfo + @" iptal edilmiştir.");
                this.Close();
            }
        }
    }
}
