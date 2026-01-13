using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskService.Infrastructure.DContexts;

namespace TaskService.Application.Commands
{
    public class UpdateTaskCommand : IRequest<TaskService.Domain.Entity.Task>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public UpdateTaskCommand(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }

    //public class UpdateTaskCommandHandler
    //    : IRequestHandler<UpdateTaskCommand, TaskService.Domain.Entity.Task>
    //{
    //    private readonly ProgramDbContext _context;

    //    public UpdateTaskCommandHandler(ProgramDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public async Task<TaskService.Domain.Entity.Task> Handle(
    //        UpdateTaskCommand request,
    //        CancellationToken cancellationToken)
    //    {
    //        var task = await _context.Tasks
    //            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

    //        if (task == null)
    //            return null;

    //        task.Title = request.Title;
    //        task.Description = request.Description;

    //        await _context.SaveChangesAsync(cancellationToken);

    //        return task;
    //    }
    //}
}
