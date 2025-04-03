using EasyBook.Model;
using System.Drawing;
using System.Xml.Linq;

namespace EasyBook.Model
{  // vi har oprettet en klasse der hedder Booking
    public class Booking
    { // vi opretter vores parameter
    public int Id {  get; set; }
    public int MeetingRoomId { get; set; }
    public int MeetingRoomID { get; internal set; }
    public DateTime BookingDate { get; set; }
    public string Comments { get; set; }
    public string EmployeeName { get; internal set; }
    }


}



