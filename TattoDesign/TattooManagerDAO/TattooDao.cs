using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject;
using TattooManagerObject.Models;

namespace TattooManagerDAO
{
    public class TattooDao
    {
        public static TattooDao instance = null;
        public TattooDao() { }
       public static TattooDao Instance { get { 
                if(instance == null)
                {
                    instance = new TattooDao();
                }
                
                return instance; } }
        public List<TattooImg> getAllTattoo()
        {
            try
            {
                var dbContext = new TattooshopContext();
                return dbContext.TattooImgs.ToList();
            }catch(Exception ex) { throw new Exception(ex.Message); }
           
        }
        public List<TattooImg> GetTattooImgsByname(string name)
        {
            var dbContext = new TattooshopContext();
            return dbContext.TattooImgs.Where(t => t.Name.Contains(name)).ToList();
        }
        public TattooImg GetTattooImgsById(int id)
        {
            var dbContext = new TattooshopContext();
            return dbContext.TattooImgs.SingleOrDefault(t => t.Id.Equals(id));
        }
        public List<TattooImg> GetTattooImgsByCateId(int cateid)
        {
            var dbContext = new TattooshopContext();
            return dbContext.TattooImgs.Where(t => t.CateId == cateid).ToList();
        }

    }
}
