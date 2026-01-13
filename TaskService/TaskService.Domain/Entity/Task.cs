namespace TaskService.Domain.Entity
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid GroupId { get; set; }
        public Guid AssignedUserId { get; set; }
        public Group Group { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate{ get; set;}
    }
}
