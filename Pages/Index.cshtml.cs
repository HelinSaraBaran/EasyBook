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

        // vi tilføjer en BindProperty
        [BindProperty]
        public string ReservedBy { get; set; } // for at kunne modtage navnet fra formularen

        // Vi opretter en metode der hedder OnGet
        public void OnGet()
        {
            // vi henter alle mødelokalerne
            MeetingRooms = _meetingRoomRepo.GetAll();
        }
        // Metoden kaldes, når der er en der der skal klikke på ledig/ optaget knappen på et mødelokale
        public IActionResult OnPostToggleAvailability(int id)
        {
            // vi henter alle mødelokalerne
            List<MeetingRoom> meetingRooms = _meetingRoomRepo.GetAll();

            // vi finder det mødelokale der matcher det Id vi har fået
            MeetingRoom room = null;
            foreach (MeetingRoom r in meetingRooms)
            {
                if (r.Id == id)
                {
                    room = r;
                    break;
                }
            }

            // hvis vi fandt rummet, så ændrer vi reservationstid
            if (room != null)
            {
                room.IsAvailable = !room.IsAvailable;

                if (!room.IsAvailable)
                {
                    room.ReservationTime = DateTime.Now;
                    room.ReservedBy = ReservedBy;
                }
                else
                {
                    room.ReservationTime = null;
                    room.ReservedBy = null;
                }
            }


            // genindlæs siden, så vi ser den nye status
            return RedirectToPage();
        }




    }

}
    

