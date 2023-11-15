using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject;
using TattooManagerObject.Models;

namespace TattooManagerDAO
{
    public class UserDao
    {
        private List<User> users;
        public static UserDao instance = null ;
        public UserDao() { }
        public static UserDao Instance { get { 
                if(instance == null)
                {
                    instance = new UserDao();   
                }
                return instance ; } }
        public User getUser(String username)
        {
            var dbContext = new TattooshopContext();
            return dbContext.Users.SingleOrDefault(u => u.Username.Equals(username));
        }
        public void addUser(User newUser) {
            var dbContext = new TattooshopContext();
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();
        }
    }
}
