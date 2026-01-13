using MediatR;
using TaskService.Infrastructure.DContexts;
namespace TaskService.Application.Commands
{
    public class CreateTaskCommand : IRequest<TaskService.Domain.Entity.Task>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public CreateTaskCommand(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
        }
    }
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, TaskService.Domain.Entity.Task>
    {
        private readonly ProgramDbContext _context;

        public CreateTaskCommandHandler(ProgramDbContext context)
        {
            _context = context;
        }

        public async Task<TaskService.Domain.Entity.Task> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskService.Domain.Entity.Task
            {
                Title = request.Title,
                Description = request.Description,
                CreatedDate = request.DueDate,
            };

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync(cancellationToken);

            return task;
        }
    }
}
