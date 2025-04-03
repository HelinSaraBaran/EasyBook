namespace EasyBook.Model
{ // vi har oprettet en klasse der hedder MeetingRoom
    public class MeetingRoom
    {
       // vi opretter vores parameter 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public bool Whiteboard { get; set; }
        public bool Projector { get; set; }
        public string ImagePath { get; set; }
        
        // vi tlføjer vores properties
        public DateTime? ReservationTime { get; set; }//Hvornår blev det reserveret?
        public string? RedservedBy { get; set; }// Hvem reserverer lokalet?
        public string ReservedBy { get; internal set; }



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
        

     
