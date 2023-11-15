using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManageRepository;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    
    public class ArtistService : IArtistService
    {
        private IArtisRepo staffRepo;
        public ArtistService() { 
        staffRepo = new ArtisRepo();
                }
        public List<Artist> getAllStaff()
        {
           return staffRepo.getAllStaff();
        }

        public Artist getStaffById(int id)
        {
            return staffRepo.getStaffById(id);
        }

        public List<Artist> getStaffByName(string name)
        {
           return staffRepo.getStaffByName(name);
        }
    }
}
