namespace EasyBook.Model
{ // vi har oprettet en klasse der hedder MeetingRoom
    public class MeetingRoom
    {
        internal bool IsAvailable;

        // vi opretter vores parameter 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsAvaliable { get; set; }
        public bool Whiteboard { get; set; }
        public bool Projector { get; set; }
        public string ImagePath { get; set; }

        //constructer
        public MeetingRoom(int id, string name, int capacity, bool isavailable, bool whiteboard, bool projector, string imagepath)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            IsAvailable = isavailable;
            Whiteboard = whiteboard;
            Projector = projector;
            ImagePath = imagepath;
        }
    }
}
        

     
