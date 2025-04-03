using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EasyBook.Model;
using EasyBook.Repository;

namespace EasyBook.Pages
{
    public class ReservedModel : PageModel // klasse
    {
        // felt og propperty. 
        private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();

        // der oprettes en instans af MeetingRoomRepository 
        public List<MeetingRoom> ReservedRooms { get; set; }

        // vi tilføjer en OnGet() metode
        public void OnGet()
        {
            ReservedRooms = _meetingRoomRepo.GetAll()
            .Where(r => !r.IsAvailable)
            .ToList();

        }

    }
}
