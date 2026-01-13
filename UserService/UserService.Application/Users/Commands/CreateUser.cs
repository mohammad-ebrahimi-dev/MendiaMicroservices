namespace UserService.Application.User.Commands
{
    public class CreateUser : UserService.Application.Common.User
    {
        public override object Create(object data)
        {
            return "test";
        }
    }
}
