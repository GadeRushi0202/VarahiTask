namespace VarahiTask.Model
{
    public class User
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
    public class UserLogin
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }

    public class UserConstant
    {
        
        public static List<User> Users = new()
            {
                    new User(){ UserName="admin",Password="admin",Role="Admin"},
                    new User(){ UserName="user",Password="user",Role="Customer"}
            };
    }
}
