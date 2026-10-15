using Microsoft.EntityFrameworkCore;
using TicketingSystem.Models;

namespace TicketingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickets => Set<Ticket>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Tickets");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.FlightNumber)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(t => t.Origin)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(t => t.Destination)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(t => t.DepartureDate)
                    .IsRequired();
                entity.Property(t => t.ArrivalDate)
                    .IsRequired();
                entity.Property(t => t.Price)
                    .HasColumnType("decimal(10,2)");
                entity.Property(t => t.SeatClass)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(t => t.PassengerName)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(t => t.BookingDate)
                    .IsRequired();

                // Seed data for testing - Simple airline ticket system
                entity.HasData(GetSeedTickets());
            });
        }

        private static IEnumerable<Ticket> GetSeedTickets()
        {
            var tickets = new List<Ticket>();
            var random = new Random(42); // Fixed seed for reproducible data

            var airlines = new[]
            {
                "Delta Air Lines", "American Airlines", "United Airlines", "Southwest Airlines",
                "JetBlue Airways", "Alaska Airlines"
            };

            var origins = new[]
            {
                "New York (JFK)", "Los Angeles (LAX)", "Chicago (ORD)", "Atlanta (ATL)",
                "Dallas/Fort Worth (DFW)", "Denver (DEN)"
            };

            var destinations = new[]
            {
                "London (LHR)", "Paris (CDG)", "Tokyo (NRT)", "Dubai (DXB)", "Sydney (SYD)",
                "Toronto (YYZ)", "Mexico City (MEX)", "Frankfurt (FRA)"
            };

            var seatClasses = new[]
            {
                "Economy", "Premium Economy", "Business", "First"
            };

            var startDate = new DateTime(2026, 1, 1);

            for (int i = 1; i <= 150; i++)
            {
                var airlineIndex = random.Next(airlines.Length);
                var originIndex = random.Next(origins.Length);
                var destIndex = random.Next(destinations.Length);
                var seatClassIndex = random.Next(seatClasses.Length);
                var daysOffset = random.Next(0, 365);
                var hoursOffset = random.Next(0, 24);
                var minutesOffset = random.Next(0, 60);

                var departureDate = startDate.AddDays(daysOffset).AddHours(hoursOffset).AddMinutes(minutesOffset);
                var flightDuration = random.Next(2, 16); // 2-16 hours flight
                var arrivalDate = departureDate.AddHours(flightDuration);

                // Generate a simple flight number
                var flightNumber = $"{airlines[airlineIndex].Substring(0, 2).ToUpper()}{i:D4}";

                // Price based on seat class and distance
                var basePrice = random.Next(200, 1500);
                var priceMultiplier = seatClassIndex switch
                {
                    0 => 1.0,   // Economy
                    1 => 1.5,   // Premium Economy
                    2 => 2.5,   // Business
                    3 => 4.0,   // First
                    _ => 1.0
                };
                var price = Math.Round((decimal)(basePrice * priceMultiplier), 2);

                tickets.Add(new Ticket
                {
                    Id = i,
                    FlightNumber = flightNumber,
                    Origin = origins[originIndex],
                    Destination = destinations[destIndex],
                    DepartureDate = departureDate,
                    ArrivalDate = arrivalDate,
                    Price = price,
                    SeatClass = seatClasses[seatClassIndex],
                    PassengerName = $"Passenger {i}",
                    BookingDate = departureDate.AddDays(-random.Next(1, 60)) // Booked 1-60 days before flight
                });
            }

            return tickets;
        }
    }
}