using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EasyBook.Model;
using EasyBook.Repository;

namespace EasyBook.Pages
{
    public class room1Model : PageModel
    {
        // Vi laver en instans af vores repository, dette gøre at vi kan hente mødelokalerne 
        private readonly MeetingRoomRepository _repo = new MeetingRoomRepository();

        // nu gøre vi at sådan så vi kan gemme mødelokalerne på siden
        public MeetingRoom Room { get; set; }

        // tilføjer en OnGet() metode
        public void OnGet()
        {
            // vi henter alle vores mødelokaler fra vores repository ved hjælp af en liste 
            List<MeetingRoom> allRooms = _repo.GetAll();
        
        // vi gennemgår listen og finder vores mødelokale der har ID 1
        foreach (MeetingRoom r in allRooms)
         {
             if (r.Id == 1)
         {
           Room = r; // her  gemmer vi mødelokalet
            break; // loopen stopper når vi har fundet vores lokale
         }   
       }
     }
   } 
}