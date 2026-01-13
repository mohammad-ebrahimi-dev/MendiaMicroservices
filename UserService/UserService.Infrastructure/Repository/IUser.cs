namespace UserService.Infrastructure.Repository
{
    public interface IUser
    {
        object Create(object data);
        object Get();
        object Update(object data);
        object Delete(object data);
    }
}
