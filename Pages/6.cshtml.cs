using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyBook.Pages
{
    public class room6Model : PageModel
    {
        public Room Room { get; set; }

        public void OnGet()
        {
            // Initialize the Room object here
            Room = new Room
            {
                Id = 1,
                IsAvailable = true,
                // Other properties
            };
        }

        public IActionResult OnPostToggleAvailability(int id)
        {
            // Handle the form submission and toggle room availability
            // Update the Room object accordingly
            return RedirectToPage();
        }
    }

    public class Room
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        // Other properties
    }
}
