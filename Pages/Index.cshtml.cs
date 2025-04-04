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

        // vi laver en "offentlig" liste af m�delokaler
        public List<MeetingRoom> MeetingRooms { get; set; }

        // vi tilf�jer en BindProperty
        [BindProperty]
        public string ReservedBy { get; set; } // for at kunne modtage navnet fra formularen

        // Vi opretter en metode der hedder OnGet
        public void OnGet()
        {
            // vi henter alle m�delokalerne
            MeetingRooms = _roomservice.GetAll();
        }
        // Metoden kaldes, n�r der er en der der skal klikke p� ledig/ optaget knappen p� et m�delokale
        public IActionResult OnPostToggleAvailability(int id)
        {
            // vi henter alle m�delokalerne
            List<MeetingRoom> meetingRooms = _roomservice.GetAll();

            // vi finder det m�delokale der matcher det Id vi har f�et
            MeetingRoom room = null;
            foreach (MeetingRoom r in meetingRooms)
            {
                if (r.Id == id)
                {
                    room = r;
                    break;
                }
            }

            // hvis vi fandt rummet, s� �ndrer vi reservationstid
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

                // vi opdaterer m�delokalet
                _roomservice.UpdateMeetingRoom(room);
                
            }


            // genindl�s siden, s� vi ser den nye status
            return RedirectToPage();
        }




    }

}
    

