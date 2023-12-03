using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    public interface ICartService
    {
        List<Cart> getCartByUserId(int userId);
        void addCart(int userId,int tattooId);
        void removeCart(Cart cart);
    }
}
