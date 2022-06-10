namespace Reservation_App
{
    public class ReservationFactory3 : AbstractReservationFactory
    {
        public override ITransportation CreateUlasim()
        {
            return new Ucak();
        }

        public override IAccommodation CreateKonaklama()
        {
            return new Cadir();
        }
    }
}