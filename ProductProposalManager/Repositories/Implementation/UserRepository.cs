using ProductProposalManager.Models;
using ProductProposalManager.Repositories.Interface;

namespace ProductProposalManager.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            _users = new List<User>
            {
                new User { Id = 1, Username = "user1", Password = "password1", Role = Enums.UserRole.USER },
                new User { Id = 2, Username = "user2", Password = "password2", Role = Enums.UserRole.USER },
                new User { Id = 3, Username = "user3", Password = "password3", Role = Enums.UserRole.USER }
            };
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            return Task.FromResult(_users.AsEnumerable());
        }

        public Task<User> GetUserById(int id)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Id == id));
        }

        public Task<User> GetUserByUsername(string username)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Username == username));
        }
    }
}
