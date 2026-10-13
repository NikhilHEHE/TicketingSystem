using MediatR;
using TicketingSystem.Dtos;
using System.Collections.Generic;

namespace TicketingSystem.Queries
{
    public record GetTicketsByDateRangeQuery(DateTime StartDate, DateTime EndDate) : IRequest<List<TicketDto>>
    {
        public void Deconstruct(out DateTime startDate, out DateTime endDate) => (startDate, endDate) = (StartDate, EndDate);

        public bool IsValid => StartDate <= EndDate;
    }
}