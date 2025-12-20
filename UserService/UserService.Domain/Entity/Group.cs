namespace UserService.Domain.Entity
{
    public class Group : Base
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId {  get; set; }
        public User User { get; set; }
    }
}
