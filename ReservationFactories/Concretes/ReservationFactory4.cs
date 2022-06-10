namespace Reservation_App
{
    public class ReservationFactory4 : AbstractReservationFactory
    {
        public override ITransportation CreateUlasim()
        {
            return new Ucak();
        }

        public override IAccommodation CreateKonaklama()
        {
            return new Otel();
        }
    }
}