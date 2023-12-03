using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManageRepository;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    
    public class CartService : ICartService
    {
        private ICartRepo cartRepo;
        public CartService()
        {
            cartRepo = new CartRepo();
        }

        public void addCart(int userId, int tattooId)
        {
            var cartItem = new Cart
            {
                UserId = userId,
                TattooId = tattooId

            };
            cartRepo.addCart(cartItem);
        }

        public List<Cart> getCartByUserId(int userId)
        {
            return cartRepo.getCartByUserId(userId);
        }

        public void removeCart(Cart cart)
        {
            cartRepo.deleteCart(cart);
        }
    }
}
