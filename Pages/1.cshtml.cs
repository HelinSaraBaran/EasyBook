using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EasyBook.Model;
using EasyBook.Repository;

namespace EasyBook.Pages
{
    public class room1Model : PageModel
    {
        // Vi laver en instans af vores repository, dette g�re at vi kan hente m�delokalerne 
        private readonly MeetingRoomRepository _repo = new MeetingRoomRepository();

        // nu g�re vi at s�dan s� vi kan gemme m�delokalerne p� siden
        public MeetingRoom Room { get; set; }

        // tilf�jer en OnGet() metode
        public void OnGet()
        {
            // vi henter alle vores m�delokaler fra vores repository ved hj�lp af en liste 
            List<MeetingRoom> allRooms = _repo.GetAll();
        
        // vi gennemg�r listen og finder vores m�delokale der har ID 1
        foreach (MeetingRoom r in allRooms)
         {
             if (r.Id == 1)
         {
           Room = r; // her  gemmer vi m�delokalet
            break; // loopen stopper n�r vi har fundet vores lokale
         }   
       }
     }
   } 
}