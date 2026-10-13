using MediatR;
using TicketingSystem.Dtos;

namespace TicketingSystem.Queries
{
    public record GetTicketByIdQuery(int Id) : IRequest<TicketDto>;
}