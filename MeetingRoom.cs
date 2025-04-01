namespace EasyBook
{ // vi har oprettet en klasse der hedder MeetingRoom
    public class MeetingRoom
    {
        internal bool IsAvailable;

    // vi opretter vores parameter 
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public bool IsAvaiable { get; set; }
      public string Equipment { get; set; }
    }
}
