using UserService.Infrastructure.Repository;

namespace UserService.Application.Common
{
    public class UserRepository: AbstractUser
    {
        public override string AddAsync(object entity)
        {
            throw new NotImplementedException();
        }
    }
}
