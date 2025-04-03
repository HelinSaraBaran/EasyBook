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

//    }
}


//parameter
// public string Name { get; set; }
//public string Description { get; set; }
//public string ImagePath { get; set; }
//public int ID { get; set; }

//public int Size { get; set; }

//constructer
//public Booking(int id, string name, string description, int size, string imagepath)
//{
  //  ID = id;
    //Name = name;
    //Description = description;
    //ImagePath = imagepath;
    //Size = size;
