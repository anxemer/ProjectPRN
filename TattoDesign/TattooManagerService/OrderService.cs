using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManageRepository;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    public class OrderService : IOrderService
    {
        private ICartService cartService;
        private ITattoService tattoService;
        private IOrderDetailrepo orderDetailrepo;
        private IOrderRepo orderRepo;
        public OrderService() {
            cartService = new CartService();
            orderRepo = new OrderRepo();
            tattoService = new TattooService();
            orderDetailrepo = new OrderDetailRepo();
        }
        public void deleteOrder(Order order)
        {
            orderRepo.deleteOrder(order);
        }

        public List<Order> findAll()
        {
            return orderRepo.findAll();
        }

        public List<Order> getOrerByArtistId(int artistid)
        {
            return orderRepo.getOrerByArtistId((int) artistid);
        }

        public List<Order> getOrerByUserId(int userid)
        {
            return orderRepo.getOrerByUserId((int) userid);
        }

        public void placeOrder(User user, List<Cart> cartItems, Artist artist)
        {
            decimal totalPrice = 0;
            foreach (var cartItem in cartItems)
            {
                var tattoo = tattoService.GetTattooById(cartItem.TattooId);
                totalPrice += tattoo.Price; // Giả sử mỗi CartItem chỉ có một Tattoo
            }
            var order = new Order
            {
                UserId = user.Id,
                ArtistId = artist.Id,
                OrderDate = DateTime.Now,
                Status = "Pending",
                TotalPrice = totalPrice,
            };
            orderRepo.placeOrder(order);
            foreach (var cartItem in cartItems)
            {
                
                var orderDetail = new OrderDetail
                {

                    OrderId = order.Id,
                    TattooId = cartItem.TattooId,
                    
                    Price = cartItem.Tattoo.Price,
                    
                };

                orderDetailrepo.addOrderDetail(orderDetail);
                cartService.removeCart(cartItem);
            }
        }

        

       
    }
    }


