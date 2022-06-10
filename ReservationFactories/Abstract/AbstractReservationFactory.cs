namespace Reservation_App
{
    public abstract class AbstractReservationFactory
    {
        public abstract ITransportation CreateUlasim();
        public abstract IAccommodation CreateKonaklama();
    }
}