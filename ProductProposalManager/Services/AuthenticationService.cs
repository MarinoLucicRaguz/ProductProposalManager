using ProductProposalManager.Models;

namespace ProductProposalManager.Services
{
    public class AuthenticationService
    {
        private User _user;

        public Task<User> GetCurrentUser()
        {
            return Task.FromResult(_user);
        }
        public Task<int> GetCurrentUserId()
        {
            return Task.FromResult(_user.Id);
        }

        public Task SetUserAsAuthenticated(User user)
        {
            _user = user;
            return Task.CompletedTask;
        }

        public Task Logout()
        {
            _user = null;
            return Task.CompletedTask;
        }

        public bool isUserAuthenticated()
        {
            return _user != null;
        }
    }
}
