using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    public interface IArtistService
    {
        List<Artist> getAllStaff();
        List<Artist> getStaffByName(string name);
        Artist getStaffById(int id);
    }
}
