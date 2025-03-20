namespace TestApi3K.Requests
{
    public class CreateNewUser
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class LoginReq
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}