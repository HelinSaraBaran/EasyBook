using System.Linq;
using System.Collections.Generic;
using EasyBook.Model;
using EasyBook;
using Amazon.DynamoDBv2.Model;
namespace EasyBook.Repository

{
    public class Repository
    {
        // vi opretter en liste af objekter. MeetingRooms er en liste der indeholder objektet MeetingRoom. 
        private List<MeetingRoom> meetingRooms = new List<MeetingRoom>
      {
       // Vi initialiserer vores liste af mødelokaler
      new MeetingRoom { Id = 1, Name = "Mødelokale A", Capacity = 10, IsAvailable= true },
      new MeetingRoom { Id = 2, Name = "Mødelokale B", Capacity = 20, IsAvailable= true }
    
      };
      private List<Booking> bookings = new List<Booking>();

      public List<MeetingRoom> GetAllMeetingRooms()
      {
             return meetingRooms;
      }
        // vi opretter en metode der hedder AddBooking, som tager et booking objekt som parameter
        public void AddBooking(Booking booking)
     {
      bookings.Add(booking);
     MeetingRoom room = meetingRooms.FirstOrDefault(m => m.Id == booking.MeetingRoomId);
     if (room != null)
        {
        room.IsAvailable = false;// Lokalet er ikke længere tilgængeligt 
        }
      }
    }
 }


