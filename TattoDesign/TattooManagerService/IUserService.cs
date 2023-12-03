using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    public interface IUserService
    {
        User getUser(string username);

        void addUser(User user);
    }
}
