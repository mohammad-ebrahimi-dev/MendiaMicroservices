namespace TaskService.Application.NewFolder
{
    public class CreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid AssignedUserId { get; set; }
        public string Group { get; set; }
    }
}
