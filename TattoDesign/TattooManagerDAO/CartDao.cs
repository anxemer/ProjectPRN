using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerDAO
{
    public class CartDao
    {
        private List<Cart> carts = new List<Cart>();
        public static CartDao instance = null;
        public CartDao() { }
        public static CartDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartDao();
                }
                return instance;

            }
        }
        public List<Cart> getCartByUserId(int id)
        {
            var dbContext = new TattooshopContext();
            return dbContext.Carts.Where(c => c.UserId == id).ToList();
        }
        public void AddCart(Cart cart)
        {
            var dbContext = new TattooshopContext();
            dbContext.Carts.Add(cart);
            dbContext.SaveChanges();
        }
    }
}
