using YourPlatform.DBContext;
using YourPlatform.IServices;
using YourPlatform.Models;

namespace YourPlatform.Services
{
    public class UserRegistration : IUserRegistration
    {
        private readonly MyAppContext AppContext;
        public UserRegistration(MyAppContext _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public Users Login(Login login)
        {
            Users user = AppContext.Users.FirstOrDefault(u => u.UserName == login.Username && u.Password == login.Password);
            return user;
        }
        public void Register(UserRegister user)
        {
            Users User = new Users();
            User.UserName = user.UserName;
            User.Password = user.Password;
            User.FirstName = user.FirstName;    
            User.LastName = user.LastName;
            AppContext.Users.Add(User);
            AppContext.SaveChanges();
        }
    }
}
