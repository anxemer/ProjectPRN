using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public class TattooRepository : ITattooImageRepository
    {
        public List<TattooImg> getAllTattoo()=> TattooDao.Instance.getAllTattoo();
       

        public List<TattooImg> geTattooByName(string name)=> TattooDao.Instance.GetTattooImgsByname(name);
       

        public List<TattooImg> getTattooByCateId(int cateid)=> TattooDao.Instance.GetTattooImgsByCateId(cateid);
       
        public TattooImg getTattooById(int id)=> TattooDao.Instance.GetTattooImgsById(id);
       
    }
}
