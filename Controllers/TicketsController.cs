using MediatR;
using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Queries;
using TicketingSystem.Dtos;
using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("date-range")]
        public async Task<ActionResult<List<TicketDto>>> GetTicketsByDateRange([Required] DateTime startDate, [Required] DateTime endDate)
        {
            if (startDate > endDate)
            {
                return BadRequest("StartDate cannot be greater than EndDate");
            }

            var query = new GetTicketsByDateRangeQuery(startDate, endDate);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDto>> GetTicketById([Required] int id)
        {
            var query = new GetTicketByIdQuery(id);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}