using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public interface IArtisRepo
    {
        List<Artist> getAllStaff();
        List<Artist> getStaffByName(string name);
        Artist getStaffById(int id);
    }
}
