using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskService.Infrastructure.DContexts;

namespace TaskService.Application.Queries
{
    // Command
    public class GetTaskByIdCommand : IRequest<TaskService.Domain.Entity.Task>
    {
        public Guid Id { get; set; }

        public GetTaskByIdCommand(Guid id)
        {
            Id = id;
        }
    }

    // CommandHandler
    public class GetTaskByIdCommandHandler : IRequestHandler<GetTaskByIdCommand, TaskService.Domain.Entity.Task>
    {
        private readonly ProgramDbContext _context;

        public GetTaskByIdCommandHandler(ProgramDbContext context)
        {
            _context = context;
        }

        public async Task<TaskService.Domain.Entity.Task> Handle(GetTaskByIdCommand request, CancellationToken cancellationToken)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

            return task;
        }
    }
}
