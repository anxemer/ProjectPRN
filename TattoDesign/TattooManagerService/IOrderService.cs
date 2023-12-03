using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    public interface IOrderService
    {

        void deleteOrder(Order order);
        List<Order> findAll();
        List<Order> getOrerByArtistId(int artistid);
        List<Order> getOrerByUserId(int userid);
        void placeOrder(User user,List<Cart> cartItem,Artist artist);
    }
}
