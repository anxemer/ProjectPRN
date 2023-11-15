using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject;
using TattooManagerObject.Models;

namespace TattooManagerDAO
{
    public class ArtistDao
    {
        public static ArtistDao instance = null;
        public ArtistDao() { }
        public static ArtistDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ArtistDao();
                }

                return instance;

            }
        }
        public List<Artist> getAllStaff()
        {
            var dbContect = new TattooshopContext();
            return dbContect.Artists.ToList();
        }
        public List <Artist> getStaffByName(string name) {
            var dbContect = new TattooshopContext();
            return dbContect.Artists.Where(n => n.Namestaff.Equals(name)).ToList();
        }
        public Artist getStaffById(int id)
        {
            var dbContect = new TattooshopContext();
            return dbContect.Artists.SingleOrDefault(a => a.Id.Equals(id));
        }
    }
}
