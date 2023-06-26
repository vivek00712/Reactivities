using MediatR;
using Domain;
using Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> { }

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;

            public Handler(DataContext context, ILogger<List> logger)
            {
                _context = context;
                _logger = logger;

            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    //for delay and check it in terminal
                    // for (var i = 0; i < 10; i++)
                    // {
                    //     cancellationToken.ThrowIfCancellationRequested();
                    //     await Task.Delay(1000, cancellationToken);
                    //     _logger.LogInformation($"Task {i} has completed");
                    // }

                    cancellationToken.ThrowIfCancellationRequested();
                    await Task.Delay(1000, cancellationToken);
                    _logger.LogInformation($"Task has completed");

                }
                catch (System.Exception)
                {
                    _logger.LogInformation("Task was cancelled");
                }

                return await _context.Activities.ToListAsync();
            }

            // public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            // {
            //     return await _context.Activities.ToListAsync();
            // }
        }
    }
}