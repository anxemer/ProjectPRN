using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public interface IUserRepository
    {
        User getUser(String username);
        void addUser(User user);
    }
}
