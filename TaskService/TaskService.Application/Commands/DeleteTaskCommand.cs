//using MediatR;
//using Microsoft.EntityFrameworkCore;
//using TaskService.Infrastructure.DContexts;

//namespace TaskService.Application.Commands
//{
//    public class DeleteTaskCommand : IRequest<bool>
//    {
//        public int Id { get; set; }

//        public DeleteTaskCommand(int id)
//        {
//            Id = id;
//        }
//    }

//    public class DeleteTaskCommandHandler
//        : IRequestHandler<DeleteTaskCommand, bool>
//    {
//        private readonly ProgramDbContext _context;

//        public DeleteTaskCommandHandler(ProgramDbContext context)
//        {
//            _context = context;
//        }

//        public async Task<bool> Handle(
//            DeleteTaskCommand request,
//            CancellationToken cancellationToken)
//        {
//            var task = await _context.Tasks
//                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

//            if (task == null)
//                return false;

//            _context.Tasks.Remove(task);
//            await _context.SaveChangesAsync(cancellationToken);

//            return true;
//        }
//    }
//}
