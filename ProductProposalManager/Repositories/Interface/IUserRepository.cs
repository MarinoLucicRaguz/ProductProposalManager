using ProductProposalManager.Models;

namespace ProductProposalManager.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> GetUserByUsername(string username);
    }
}
