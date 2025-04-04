using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EasyBook.Model;
using EasyBook.Repository;
using System.Collections.Generic;
using System.Linq;
using EasyBook.Services;

namespace EasyBook.Pages
{
    public class ReservedModel : PageModel // Klassen 
    {
        // Felt til m�delokale-data
        //private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();
        private readonly BookingServices _bookingservice;
        // Liste med alle vores reserverede m�delokaler
        public List<MeetingRoom> ReservedRooms { get; set; } = new List<MeetingRoom>();

        // Brugeren kan s�ge efter navn 
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        // Brugeren kan v�lge sortering �ldst til nyest
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        public ReservedModel(BookingServices bookingservice) 
        {
            _bookingservice = bookingservice;
        }

        // Vi g�re brug af get metode 
        public void OnGet()
        {
            // Vi henter alle m�delokaler
            List<MeetingRoom> allRooms = MeetingRoom.GetAll(Booking);

            // vi v�lger m�delokaler der er reserveret (IsAvailable == false)
            foreach (MeetingRoom room in allRooms)
            {
                if (!room.IsAvailable)
                {
                    ReservedRooms.Add(room);
                }
            }

            // hvem har skrevet noget i s�gefilteret 
            if (!string.IsNullOrEmpty(SearchName))
            {
                List<MeetingRoom> filteredList = new List<MeetingRoom>();

                foreach (MeetingRoom room in ReservedRooms)
                {
                    // matcher navne
                    if (!string.IsNullOrEmpty(room.ReservedBy) &&
                        room.ReservedBy.ToLower().Contains(SearchName.ToLower()))
                    {
                        filteredList.Add(room);
                    }
                }

                ReservedRooms = filteredList; // Opdater listen
            }

            // vi sorter listen efter reservationstidspunkt
            if (SortOrder == "asc")
            {
                ReservedRooms = ReservedRooms.OrderBy(r => r.ReservationTime).ToList();// �ldste f�rst
            }
            else
            {
                ReservedRooms = ReservedRooms.OrderByDescending(r => r.ReservedBy).ToList();//Nyeste f�rst
            }
        }
    }
}

