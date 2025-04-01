using EasyBook.Model;
using EasyBook.Repository;

namespace EasyBook.Services
{
    public class BookingServices
    {
        private BookingRepository _bookingREPO;

        public BookingServices(BookingRepository bookingREPO) 
        {
            _bookingREPO = bookingREPO;
        }
        public void add(Booking booking) 
        {
            _bookingREPO.Add(booking);
        }
        public List<Booking> GetAll()
        {
            return _bookingREPO.Getall();
        }
        public Booking Get(int id)
        {
            return _bookingREPO.Get(id);
        }



    }
}
