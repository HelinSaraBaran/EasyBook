using EasyBook.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace EasyBook.Pages
{// vi har oprettet en razor page/index1.cshtml
    public class Index1Model : PageModel
    {
        // Instanserer et objekt af MeetingRoomRepository, dette bruges til at hente mødelokalerne
        // vi gøre brug af readonly for at sikre at objektet ikke bliver ændret
        private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();

        // vi opretter en liste til at holde mødelokaler
        public List<MeetingRoom> MeetingRooms { get; set; }

        // vi opretter en metode der hedder OnGet
        public void OnGet() 
        {
            // Vi henter alle mødelokalerne fra MeetingRoomRepository
            MeetingRooms = _meetingRoomRepo.GetAll();
        }
    }
}
