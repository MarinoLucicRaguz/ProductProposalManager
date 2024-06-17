using ProductProposalManager.Models;
using ProductProposalManager.Repositories.Implementation;
using ProductProposalManager.Repositories.Interface;
using ProductProposalManager.Services.Interface;

namespace ProductProposalManager.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public Task<User> GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public async Task<User> AuthenticateUser(string username, string password)
        {
            var user = await _userRepository.GetUserByUsername(username);
            
            if (user != null && user.Password == password)
            {
                return user;
            }

            return null;
        }
    }
}
