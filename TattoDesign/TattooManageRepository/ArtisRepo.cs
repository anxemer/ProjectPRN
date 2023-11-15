using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public class ArtisRepo : IArtisRepo
    {
        public List<Artist> getAllStaff()=>ArtistDao.Instance.getAllStaff();

        public Artist getStaffById(int id)=>ArtistDao.Instance.getStaffById(id);
       

        public List<Artist> getStaffByName(string name)=>ArtistDao.Instance.getStaffByName(name);
        
    }
}
