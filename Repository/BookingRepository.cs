using EasyBook.Model;

namespace EasyBook.Repository
{
    public interface BookingRepository
    {
        public List<Booking> Getall();

        //metode signatur til at tilføje til repository. Add er fx en metode

        //tilføjer parameter
        public void Add(Booking booking);

        public Booking Get(int id);
    }
}
