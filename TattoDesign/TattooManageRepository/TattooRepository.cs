using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattoDAO;
using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public class TattooRepository : ITattooImageRepository
    {
        public List<TattooImg> getAllTattoo()=> TattooDao.Instance.getAllTattoo();
        public List<CategoryTattoo> GetAllCate() => CateDAO.Instance.GetAllCate();

        public List<TattooImg> geTattooByName(string name)=> TattooDao.Instance.GetTattooImgsByname(name);
       

        public List<TattooImg> getTattooByCateId(int cateid)=> TattooDao.Instance.GetTattooImgsByCateId(cateid);
       
        public TattooImg getTattooById(int id)=> TattooDao.Instance.GetTattooImgsById(id);
        public void RemoveTattoo(int id) => TattooDao.Instance.DeleteTattoo(id);



        public void UpdateTattoo(TattooImg tattoo, int id) => TattooDao.Instance.updateTattoo(tattoo, id);
        public void AddTattoo(TattooImg tattoo) => TattooDao.Instance.AddTattoo(tattoo);

    }
}
