using UserService.Domain.Entity;

namespace UserService.Infrastructure.Repository
{
    public abstract class AbstractUser : IRepository
    {
        public virtual string AddAsync(object entity)
        {
            throw new NotImplementedException();
        }

        public string DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public string GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public User GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateAsync(object entity)
        {
            throw new NotImplementedException();
        }
    }

    public interface IRepository
    {
        User GetByIdAsync(int id);
        string  GetAllAsync();
        string  AddAsync(Object entity);
        string  UpdateAsync(Object entity);
        string  DeleteAsync(int id);
    }
}
