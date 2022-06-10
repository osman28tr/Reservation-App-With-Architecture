namespace Reservation_App
{
    public class Client
    {
        private AbstractReservationFactory _abstractReservationFactory;
        private ITransportation _ulasim;
        private IAccommodation _konaklama;

        public Client(AbstractReservationFactory abstractReservationFactory)
        {
            _abstractReservationFactory = abstractReservationFactory;
            _ulasim = _abstractReservationFactory.CreateUlasim();
            _konaklama = _abstractReservationFactory.CreateKonaklama();
        }

        public string BuildReservationTransportation()
        {
            return _ulasim.Ulasim();
        }

        public string BuildReservationAccommodation()
        {
           return _konaklama.Konaklama();
        }

    }
}