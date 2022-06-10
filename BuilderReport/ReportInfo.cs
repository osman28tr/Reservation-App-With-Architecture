using Reservation_App.ReservationInformations;

namespace Reservation_App
{
    public class ReportInfo
    {
        
        public ReservationGeneralInfo GeneralInfo { get; set; }
        public ReservationDetailInfo DetailInfo { get; set; }
        
        public decimal TotalPrice;
    }
}