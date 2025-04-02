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
    }
}
