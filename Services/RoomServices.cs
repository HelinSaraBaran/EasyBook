using EasyBook.Model;
using EasyBook.Repository;

namespace EasyBook.Services
{
    public class RoomServices
    {
        private BookingRepository _bookingREPO = null;

        public RoomServices(BookingRepository bookingREPO)
        {
            _bookingREPO = bookingREPO;
        }
        public void Add(Booking booking)
        {
            _bookingREPO.AddBooking(booking);
        }
        public List<Booking> GetAll()
        {
            return _bookingREPO.GetAll();
        }
        public Booking Get(int id)
        {
            return _bookingREPO.Get(id);
        }


    }
}


