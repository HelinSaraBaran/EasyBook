namespace EasyBook
{  // vi har oprettet en klasse der hedder Booking
    public class Booking
    {
        //parameter
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath {  get; set; }
        public string ID {  get; set; }
        public string Dato { get; set; }

        //constructer
        public Booking (int id, string name, string description, string imagepath)
        {

            Name = name;
            Description = description;
            ImagePath = imagepath;
        }

    }
}
