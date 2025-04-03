using EasyBook.Model;
using EasyBook.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyBook.Pages
{
    public class IndexModel : PageModel
    {
        // vi opretter en instans af MeetingRoomRepository til at hente m�delokalerne
        private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();

        // vi laver en "offentlig" liste af m�delokaler
        public List<MeetingRoom> MeetingRooms { get; set; }

        // Vi opretter en metode der hedder OnGet
        public void OnGet()
        {
            // vi henter alle m�delokalerne
            MeetingRooms = _meetingRoomRepo.GetAll();
        }
        // Metoden kaldes, n�r der er en der der skal klikke p� ledig/ optaget knappen p� et m�delokale
        public IActionResult OnPostToggleAvailability(int Id)
        {
            // vi opretter en liste og henter alle m�delokalerne fra vores repository
            List<MeetingRoom> meetingRooms = _meetingRoomRepo.GetAll();

            // vi opretter en variabel for at kunne gemme det m�delokale der skal �ndres
            MeetingRoom room = null;

            // Her kan vi finde m�delokalet med det �nskede Id
            foreach (MeetingRoom r in meetingRooms)
            {
                if (r.Id == Id)
                {
                    room = r;
                    break; // vores loop stopper n�r vi har fundet det �nskede m�delokale
                }
            }
            if (room != null)// hvis vi har fundet et m�delokale
            {
                // vi skifter v�rsien 
                room.IsAvailable = !room.IsAvailable;

                // vi g�re brug af Javascript og retuner et json svar med en ny status
                return new JsonResult(new { success = true, isAvailable = room.IsAvailable });

            }
            // hvis vores m�delokale ikke bbliver fundet, retuneres fejlen 
            return new JsonResult(new { success = false });
        }
    }
}
