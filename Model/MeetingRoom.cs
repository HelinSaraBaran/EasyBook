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
        public string Equipment { get; set; }

        public string ImagePath { get; set; }

        //constructer
        public MeetingRoom(int id, string name, int capacity, bool isavailable,string equipment, string imagepath)
        {
            ID = id;
            Name = name;
            Description = description;
            ImagePath = imagepath;
            Size = size;
        }


}
