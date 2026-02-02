using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskService.Infrastructure.DContexts;

namespace TaskService.Application.Queries
{
    public class CreateTaskCommand : IRequest<TaskService.Domain.Entity.Task>
    {
        public Guid Id { get; set; }


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

            //var task = 

            return new TaskService.Domain.Entity.Task { };
        }
    }
}
