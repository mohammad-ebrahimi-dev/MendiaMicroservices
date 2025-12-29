using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskService.Infrastructure.DContexts;
namespace TaskService.Application.Queries
{
    public class GetTaskCommand : IRequest<IEnumerable<TaskService.Domain.Entity.Task>>
    {
        public GetTaskCommand()
        {
            
        }
    }

    public class GetTaskCommandHandler : IRequestHandler<GetTaskCommand, IEnumerable<TaskService.Domain.Entity.Task>>
    {
        private readonly ProgramDbContext _context;
        public GetTaskCommandHandler(ProgramDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TaskService.Domain.Entity.Task>> Handle(GetTaskCommand request, CancellationToken cancellationToken)
        {
            var tasks = await _context.Tasks.ToListAsync();
            return tasks;
        }
    }
}
