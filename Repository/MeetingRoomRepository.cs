using EasyBook.Model;

namespace EasyBook.Repository
{
    // vi har oprettet en klasse der hedder MeetingRoom
    public class MeetingRoomRepository
    {
        // vi opretter en liste af mødelokaler
        private List<MeetingRoom> meetingRooms = new List<MeetingRoom>
        {
        new MeetingRoom {Id = 1, Name = "Mødelokale A", Capacity = 10, IsAvailable = true, Whiteboard = true, Projector = true, ImagePath = "" },

        new MeetingRoom {Id = 2, Name = "Mødelokale B", Capacity = 20, IsAvailable = true, Whiteboard = true, Projector = true, ImagePath = "" },

        new MeetingRoom {Id = 3, Name = "Mødelokale C", Capacity = 30, IsAvailable = true, Whiteboard = true, Projector = true, ImagePath = "" }
        };
        // metode til at hente alle mødelokalerne
        public List<MeetingRoom> GetAll() => meetingRooms;


    }
}

