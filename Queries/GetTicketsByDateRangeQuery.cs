using MediatR;
using TicketingSystem.Dtos;
using System.Collections.Generic;

namespace TicketingSystem.Queries
{
    public record GetTicketsByDateRangeQuery(DateTime StartDate, DateTime EndDate) : IRequest<List<TicketDto>>;
}