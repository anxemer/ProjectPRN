using TattooManageRepository;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService() {
            userRepository = new UserRepository();
        }

        public void addUser(User user)
        {
             userRepository.addUser(user);
        }

        public User getUser(string username)
        {
          return  userRepository.getUser(username);
        }
    }
}