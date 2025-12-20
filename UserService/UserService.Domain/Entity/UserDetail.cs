namespace UserService.Domain.Entity
{
    public class UserDetail
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime BirthDate { get; set; }

        public string NationalCode { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public User User { get; set; }
    }
}
