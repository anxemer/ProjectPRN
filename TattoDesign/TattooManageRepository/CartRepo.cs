using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public class CartRepo : ICartRepo
    {
        public void addCart(Cart cart)=> CartDao.Instance.AddCart(cart);

        public void deleteCart(Cart cart)=>CartDao.Instance.removeCart(cart);
        

        public List<Cart> getCartByUserId(int userId)=>CartDao.Instance.getCartByUserId(userId);

    }
}
