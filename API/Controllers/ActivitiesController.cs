using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using MediatR;
using Application.Activities;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {

        ///Moved the DataContext logic inside Application Layer

        // private readonly DataContext _context;

        // public ActivitiesController(DataContext context)
        // {
        //     _context = context;
        // }

        // [HttpGet] //localhost/api/activities
        // public async Task<ActionResult<List<Activity>>> GetActivities()
        // {
        //     return await _context.Activities.ToListAsync();
        // }

        // [HttpGet("{id}")] //api/activities/id
        // public async Task<ActionResult<Activity>> GetActivity(Guid id)
        // {
        //     return await _context.Activities.FindAsync(id);
        // }

        ///Moved the IMediator inside BaseApiController and make conroller Thinner

        //private readonly IMediator _mediator;
        // public ActivitiesController(IMediator mediator)
        // {
        //     this._mediator = mediator;
        // }

        // [HttpGet] //api/activities
        // public async Task<ActionResult<List<Activity>>> GetActivities()
        // {
        //     return await _mediator.Send(new List.Query());
        // }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/activities/id
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return Ok();
        }
    }
}