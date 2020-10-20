using Assignment.Model;

namespace Assignment.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}