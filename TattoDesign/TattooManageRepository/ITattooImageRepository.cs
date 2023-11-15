using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public interface ITattooImageRepository
    {
        List<TattooImg> getAllTattoo();
        TattooImg getTattooById(int id);
        List<TattooImg> geTattooByName(string name);
        List<TattooImg> getTattooByCateId(int cateid);
    }
}
