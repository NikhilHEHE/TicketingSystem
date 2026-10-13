using System;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public decimal Price { get; set; }
        public string SeatClass { get; set; } = string.Empty;
        public string PassengerName { get; set; } = string.Empty;
        public DateTime BookingDate { get; set; }
    }
}