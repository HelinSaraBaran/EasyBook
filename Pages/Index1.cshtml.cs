using EasyBook.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace EasyBook.Pages
{// vi har oprettet en razor page/index1.cshtml
    public class Index1Model : PageModel
    {
        // Instanserer et objekt af MeetingRoomRepository, dette bruges til at hente m�delokalerne
        // vi g�re brug af readonly for at sikre at objektet ikke bliver �ndret
        private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();

        // vi opretter en liste til at holde m�delokaler
        public List<MeetingRoom> MeetingRooms { get; set; }

        // vi opretter en metode der hedder OnGet
        public void OnGet() 
        {
            // Vi henter alle m�delokalerne fra MeetingRoomRepository
            MeetingRooms = _meetingRoomRepo.GetAll();
        }
    }
}
