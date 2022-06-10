﻿namespace Reservation_App
{
    public class ReservationFactory2 : AbstractReservationFactory
    {
        public override ITransportation CreateUlasim()
        {
            return new Otobus();
        }

        public override IAccommodation CreateKonaklama()
        {
            return new Otel();
        }
    }
}