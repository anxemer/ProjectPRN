using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    public interface ITattoService
    {
        List<TattooImg> GetAllTattoo();
        List<TattooImg> GetTattooByCateId(int cateid);
        TattooImg GetTattooById(int id);
        List<TattooImg> GetTattooByName(string name);
        
    }
}
