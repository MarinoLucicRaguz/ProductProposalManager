using ProductProposalManager.Models;

namespace ProductProposalManager.Services.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> AuthenticateUser(string userName, string password);
    }
}
