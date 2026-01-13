namespace UserService.Application.User.Commands
{
    public class DeleteUser : UserService.Application.Common.User
    {
        public override async Task<object> Delete(object data)
        {
            //var result = Task.Run(Loop);
            return "test data";
        }
        //public async Task<int> Loop()
        //{
        //    var result = 0;
        //    for(int i = 0; i>=5000; i++)
        //    {
        //        result = i;
        //    }
        //    return result;
        //}
    }
}
