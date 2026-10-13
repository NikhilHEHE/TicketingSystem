using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TicketingSystem.Data;
using TicketingSystem.Dtos;

namespace TicketingSystem.Queries
{
    public class GetTicketsByDateRangeQueryHandler : IRequestHandler<GetTicketsByDateRangeQuery, List<TicketDto>>
    {
        private readonly ApplicationDbContext _context;

        public GetTicketsByDateRangeQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TicketDto>> Handle(GetTicketsByDateRangeQuery request, CancellationToken cancellationToken)
        {
            var tickets = await _context.Tickets
                .Where(t => t.DepartureDate >= request.StartDate && t.DepartureDate <= request.EndDate)
                .Select(t => new TicketDto
                {
                    Id = t.Id,
                    FlightNumber = t.FlightNumber,
                    Origin = t.Origin,
                    Destination = t.Destination,
                    DepartureDate = t.DepartureDate,
                    ArrivalDate = t.ArrivalDate,
                    Price = t.Price,
                    SeatClass = t.SeatClass,
                    PassengerName = t.PassengerName,
                    BookingDate = t.BookingDate
                })
                .ToListAsync(cancellationToken);

            return tickets;
        }
    }
}