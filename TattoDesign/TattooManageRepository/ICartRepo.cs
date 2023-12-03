using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public interface ICartRepo
    {   
        List<Cart> getCartByUserId(int userId);
        void addCart(Cart cart);
        void deleteCart(Cart cart);
    }
}
