using EasyBook.Model;
using EasyBook.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;   
using System.Collections.Generic;

namespace EasyBook.Pages
{
    public class Create
    {
        // Vi opretter vores instanser der skal repræsenterer oprettelsen af bookingerne
        private readonly MeetingRoomRepository _meetingRoomRepo = new MeetingRoomRepository();

        private readonly BookingRepository _bookingRepo = new BookingRepository();

        // vi opretter vores properties og binder dem til vores razor page
        [BindProperty]
        public string EmployeeName { get; set; }
        [BindProperty]
        public string MeetingRoomID { get; set; }
        [BindProperty]
        public DateTime BookingDate { get; set; }
        [BindProperty]
        public string Comments { get; set; }

        // vi opretter en liste til at holde mødelokaler 
        public List<MeetingRoom> MeetingRooms { get; set; }

        // vi opretter en metode der hedder OnGet
        public void OnGet()
        {
            MeetingRooms = _meetingRoomRepo.GetAll();
        }

        public IActionResult OnPost()
        {
        // vi opretter en ny booking
            Booking booking = new Booking
            {
                EmployeeName = EmployeeName,
                MeetingRoomID = Convert.ToInt32(MeetingRoomID),
                BookingDate = BookingDate,
                Comments = Comments
            };
            // vi tilføjer bookingen til vores repository
            _bookingRepo.AddBooking(booking);
            // vi returnere til vores index1 side
            return RedirectToPage("Index1");
        }

        private IActionResult RedirectToPage(string v)
        {
            throw new NotImplementedException();
        }
    }
}
