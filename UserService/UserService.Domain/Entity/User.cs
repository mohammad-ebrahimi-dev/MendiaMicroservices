namespace UserService.Domain.Entity
{
    public class User : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public string Email { get; set; }

        public Role? Role { get; set; }
        public UserDetail? UserDetail { get; set; }
        public Group? Group { get; set; }
    }
}
