using EasyBook.Model;

namespace EasyBook.Repository
{
    // vi har oprettet en klasse der hedder MeetingRoom
    public class MeetingRoomRepository
    {
        // vi opretter en liste af mødelokaler
        private List<MeetingRoom> meetingRooms = new List<MeetingRoom>
        {
        new MeetingRoom {Id = 1, Name = "Mødelokale A", Capacity = 10, Equipment = "Projektor",
        IsAvailable = true },

        new MeetingRoom {Id = 2, Name = "Mødelokale B", Capacity = 20, Equipment = "Whiteboard",
        IsAvailable = true },

        new MeetingRoom { Id = 3, Name = "Mødelokale C", Capacity = 30, Equipment = "Projektor",
            IsAvailable = true }
        };
        // metode til at hente alle mødelokalerne
        public List<MeetingRoom> GetAll() => meetingRooms;


    }
}

