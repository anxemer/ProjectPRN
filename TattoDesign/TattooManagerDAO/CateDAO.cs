
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattoDAO
{
    public class CateDAO
    {
        
        public static CateDAO instance = null;
        public CateDAO() { }
        public static CateDAO Instance
        {
            get
            {
                if (instance == null)
                {

                    instance = new CateDAO();

                }
                return instance;
            }
        }
        public List<CategoryTattoo> GetAllCate()
        {
            var dbcontext = new TattooshopContext();
            return dbcontext.CategoryTattoos.ToList();
        }
      
    }
}

