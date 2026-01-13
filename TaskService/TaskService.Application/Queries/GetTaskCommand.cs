using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskService.Application.Common;
using TaskService.Infrastructure.DContexts;
namespace TaskService.Application.Queries
{
    public class GetTaskCommand : IRequest<string>
    {
    }

    public class GetTaskCommandHandler : IRequestHandler<GetTaskCommand, string>
    {
        private readonly ProgramDbContext _context;
        public GetTaskCommandHandler(ProgramDbContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(GetTaskCommand request, CancellationToken cancellationToken)
        {
            var tasks = await _context.Tasks.ToListAsync(cancellationToken);
            //return Result<List<TaskService.Domain.Entity.Task>>.Success(tasks, "Tasks fetched successfully")        };
            return "test";
        }
    }
}
