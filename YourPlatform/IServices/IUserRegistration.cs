using YourPlatform.Models;

namespace YourPlatform.IServices
{
    public interface IUserRegistration
    {
        public Users Login(Login login);
        public void Register(UserRegister login);
    }
}
