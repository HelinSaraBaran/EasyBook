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
    }
}
