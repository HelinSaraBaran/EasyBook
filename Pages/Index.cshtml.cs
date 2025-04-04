using EasyBook.Model;
using EasyBook.Repository;
using EasyBook.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyBook.Pages
{
    public class IndexModel : PageModel
    {
       // vi laver en konstruktor 
        private readonly RoomServices _roomservice;

        // vi opretter en constructor
        public IndexModel(RoomServices bs) { _roomservice = bs; }

        // vi laver en "offentlig" liste af mødelokaler
        public List<MeetingRoom> MeetingRooms { get; set; }

        // vi tilføjer en BindProperty
        [BindProperty]
        public string ReservedBy { get; set; } // for at kunne modtage navnet fra formularen

        // Vi opretter en metode der hedder OnGet
        public void OnGet()
        {
            // vi henter alle mødelokalerne
            MeetingRooms = _roomservice.GetAll();
        }
        // Metoden kaldes, når der er en der der skal klikke på ledig/ optaget knappen på et mødelokale
        public IActionResult OnPostToggleAvailability(int id)
        {
            // vi henter alle mødelokalerne
            List<MeetingRoom> meetingRooms = _roomservice.GetAll();

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

                // vi opdaterer mødelokalet
                _roomservice.UpdateMeetingRoom(room);
                
            }


            // genindlæs siden, så vi ser den nye status
            return RedirectToPage();
        }




    }

}
    

