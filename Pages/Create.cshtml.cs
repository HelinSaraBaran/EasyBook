using EasyBook.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyBook.Pages
{
    public class CreateModel : PageModel
    {
        public List<MeetingRoom> MeetingRooms { get; set; } = new List<MeetingRoom>();

        public void OnGet()
        {
        }
    }
}
//a