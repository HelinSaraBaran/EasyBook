using EasyBook.Model;

namespace EasyBook.Repository
{
    // vi har oprettet en klasse der hedder MeetingRoom
    public class MeetingRoomRepository
    {
        /// <summary>
        /// Initialisere en liste a mødelokaler med predefinerede værdier
        /// </summary>
        private List<MeetingRoom> meetingRooms = new List<MeetingRoom>
        {
            new MeetingRoom(1, "Mødelokale A", 20, true, true, false, "../photos/lokal1.jpg"),
            new MeetingRoom(2, "Mødelokale B", 25, false, true, true, "../photos/lokal2.jpg"),
            new MeetingRoom(3, "Mødelokale C", 10, true, true, false, "../photos/lokal3.jpg"),
            new MeetingRoom(4, "Mødelokale D", 15, false, false, true, "../photos/lokal4.jpg"),
            new MeetingRoom(5, "Mødelokale E", 20, true, false, true, "../photos/lokal5.jpg"),
            new MeetingRoom(6, "Mødelokale F", 30, true, true, true, "../photos/lokal6.jpg"),
        };
        
        // metode til at hente alle mødelokalerne
        public List<MeetingRoom> GetAll() => meetingRooms;
    }
}

