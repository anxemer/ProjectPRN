using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public class UserRepository : IUserRepository
    {
        public void addUser(User user)=> UserDao.Instance.addUser(user);
        

        public User getUser(string username)=> UserDao.Instance.getUser(username);
        
    }
}