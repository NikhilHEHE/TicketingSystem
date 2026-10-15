using MediatR;
using TicketingSystem.Dtos;

namespace TicketingSystem.Queries
{
    public record GetTicketsByDateRangeQuery(DateTime StartDate, DateTime EndDate) : IRequest<List<TicketDto>>;
}