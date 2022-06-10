using System;

namespace Reservation_App.ReservationInformations
{
    public class ReservationGeneralInfo
    {
        public string WhereFrom;
        public string WhereTo;
        public DateTime DepartureDate;
        public DateTime ReturnDate;
        public Customer CustomerInfo { get; set; }

    }
}
