namespace UserService.Domain.Entity
{
    public class Base
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
