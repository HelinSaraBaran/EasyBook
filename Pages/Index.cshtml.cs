using EasyBook.Model;
using EasyBook.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyBook.Pages
{
    public class IndexModel : PageModel
    {
        // vi opretter en instans af MeetingRoomRepository til at hente mødelokalerne
        private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();

        // vi laver en "offentlig" liste af mødelokaler
        public List<MeetingRoom> MeetingRooms { get; set; }

        // Vi opretter en metode der hedder OnGet
        public void OnGet()
        {
            // vi henter alle mødelokalerne
            MeetingRooms = _meetingRoomRepo.GetAll();
        }
        // Metoden kaldes, når der er en der der skal klikke på ledig/ optaget knappen på et mødelokale
        public IActionResult OnPostToggleAvailability(int Id)
        {
            // vi opretter en liste og henter alle mødelokalerne fra vores repository
            List<MeetingRoom> meetingRooms = _meetingRoomRepo.GetAll();

            // vi opretter en variabel for at kunne gemme det mødelokale der skal ændres
            MeetingRoom room = null;

            // Her kan vi finde mødelokalet med det ønskede Id
            foreach (MeetingRoom r in meetingRooms)
            {
                if (r.Id == Id)
                {
                    room = r;
                    break; // vores loop stopper når vi har fundet det ønskede mødelokale
                }
            }
            if (room != null)// hvis vi har fundet et mødelokale
            {
                // vi skifter værsien 
                room.IsAvailable = !room.IsAvailable;

                // vi gøre brug af Javascript og retuner et json svar med en ny status
                return new JsonResult(new { success = true, isAvailable = room.IsAvailable });

            }
            // hvis vores mødelokale ikke bbliver fundet, retuneres fejlen 
            return new JsonResult(new { success = false });
        }
    }
}
