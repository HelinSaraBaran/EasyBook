using EasyBook.Model;
using System.Drawing;
using System.Xml.Linq;

namespace EasyBook.Model
{  // vi har oprettet en klasse der hedder Booking
    public class Booking
    {
    public int Id {  get; set; }
    public int MeetingRoomId { get; set; }
    public DateTime BookingDate { get; set; }
    public string Comment { get; set; }

    }

    }
}


//parameter
// public string Name { get; set; }
//public string Description { get; set; }
//public string ImagePath { get; set; }
//public int ID { get; set; }

//public int Size { get; set; }

/*/constructer
public Booking(int id, string name, string description, int size, string imagepath)
{
    ID = id;
    Name = name;
    Description = description;
    ImagePath = imagepath;
    Size = size;
