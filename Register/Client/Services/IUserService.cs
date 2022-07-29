using Register.Shared;

namespace Register.Client.Services
{
    public interface IUserService
    {
        List<Users> User { get; set; }
        Task CreateHero(Users user);
        Task GetUser(Users user);
    }
}
