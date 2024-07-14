using Senior.Data.Models;

namespace Senior.Data.Storages
{
    public class UserStorage
    {
        public static User AdminUser = new User { Login = Environment.GetEnvironmentVariable("AdminLogin"), Password = Environment.GetEnvironmentVariable("AdminPassword") };
    }
}