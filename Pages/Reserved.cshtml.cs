using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EasyBook.Model;
using EasyBook.Repository;
using System.Collections.Generic;
using System.Linq;

namespace EasyBook.Pages
{
    public class ReservedModel : PageModel // Klassen til din Razor Page
    {
        // Felt til at håndtere mødelokale-data
        private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();

        // Liste med alle reserverede mødelokaler
        public List<MeetingRoom> ReservedRooms { get; set; } = new List<MeetingRoom>();

        // Brugeren kan søge efter navn (via URL eller formular)
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        // Brugeren kan vælge sortering (asc = ældste først, desc = nyeste først)
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        // Denne metode kaldes når siden loades (GET-request)
        public void OnGet()
        {
            // Trin 1: Hent alle mødelokaler
            List<MeetingRoom> allRooms = _meetingRoomRepo.GetAll();

            // Trin 2: Udvælg kun de mødelokaler der er reserveret (IsAvailable == false)
            foreach (MeetingRoom room in allRooms)
            {
                if (!room.IsAvailable)
                {
                    ReservedRooms.Add(room);
                }
            }

            // Trin 3: Hvis der er skrevet noget i søgefeltet, filter på hvem der har reserveret
            if (!string.IsNullOrEmpty(SearchName))
            {
                List<MeetingRoom> filteredList = new List<MeetingRoom>();

                foreach (MeetingRoom room in ReservedRooms)
                {
                    // Tjek om navnet matcher det brugeren har skrevet
                    if (!string.IsNullOrEmpty(room.ReservedBy) &&
                        room.ReservedBy.ToLower().Contains(SearchName.ToLower()))
                    {
                        filteredList.Add(room);
                    }
                }

                ReservedRooms = filteredList; // Opdater listen
            }

            // Trin 4: Sorter listen efter reservationstidspunkt
            if (SortOrder == "asc")
            {
                ReservedRooms = ReservedRooms.OrderBy(r => r.ReservationTime).ToList();// ældste først
            }
            else
            {
                ReservedRooms = ReservedRooms.OrderByDescending(r => r.ReservedBy).ToList();//Nyeste først
            }
        }
    }
}

