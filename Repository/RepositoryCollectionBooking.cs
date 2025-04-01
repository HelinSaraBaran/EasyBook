namespace EasyBook.Repository
{
    public class RepositoryCollectionBooking :BookingRepository
    {

        //Create read update delete CRUD

        //ny collection(list) som vi kan smide booking i

        List<Booking> _booking = new List<Booking>();

        public void Add(Booking booking)
        {
            _booking.Add(booking);
        }

        //vi vil gerne lave en metode, som returer alle dyr i vores repository

        public List<Booking> Getall()
        {
            return _booking;
        }
        public Booking Get(int id)
        {
            foreach (Booking booking in _booking)
            {
               if (id == booking.ID)
                {
                    return booking;
                }
            }
            return null;
        }

        public RepositoryCollectionBooking()
        {
            _booking.Add(new Booking(101, "Mødelokale A", "Whiteboard", ""));

            _booking.Add(new Booking(102, "Mødelokale B", "Whiteboard", ""));

            _booking.Add(new Booking(103, "Mådelokale C", "Projector",""));

        }

    }
}
