using EasyBook.Model;

namespace EasyBook.Repository
{// vi har oprettet en klasse der hedder BookingRepository
    public class BookingRepository
    {  // vi opretter vore liste til at gemme vores bookinger
        private List <Booking> _bookings = new List<Booking> ();

        //metode til at tilføje booking til repository
        public void AddBooking(Booking booking) => _bookings.Add(booking);

        //metode til at hente alle bookinger
        public List<Booking> GetAll() => _bookings;
        public Booking Get(int id)
        {
            foreach (Booking b in _bookings)
            {
                if (id == b.Id)
                {
                    return b;
                }
            }
            return null;
        }
    }


}
