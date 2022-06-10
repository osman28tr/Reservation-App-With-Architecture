using System;
using System.Windows.Forms;
using Reservation_App.ReservationInformations;

namespace Reservation_App
{
    public partial class Form1 : Form
    {
        private Client client;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = textName.Text,
                Address = textAdress.Text,
                IdentificationNo = textID.Text,
                PhoneNumber = textPhoneNum.Text
            };
            
            var generalinfo = new ReservationGeneralInfo()
            {
                CustomerInfo = customer,
                DepartureDate = Convert.ToDateTime(DepartureDate.Text),
                ReturnDate = Convert.ToDateTime(returndate.Text),
                WhereFrom = textWhereFrom.Text,
                WhereTo = textWhereTo.Text,
            };
            
            if (client != null)
            {
                var detailinfo = new ReservationDetailInfo()
                {
                    AccommodationInfo = client.BuildReservationAccommodation(),
                    TransportationInfo = client.BuildReservationTransportation()
                };
                var frm = new ReportForm(generalinfo,detailinfo);
                frm.ShowDialog();
            }
        }

        private void radio_Otobus_Otel_CheckedChanged(object sender, EventArgs e)
        {
            client = new Client(new ReservationFactory2());
            
        }

        private void radio_Otobus_Cadir_CheckedChanged(object sender, EventArgs e)
        {
            client = new Client(new ReservationFactory1());

        }

        private void radio_Ucak_Cadir_CheckedChanged(object sender, EventArgs e)
        {
            client = new Client(new ReservationFactory3());

        }

        private void radio_Ucak_Otel_CheckedChanged(object sender, EventArgs e)
        {
            client = new Client(new ReservationFactory4());

        }
    }
}
