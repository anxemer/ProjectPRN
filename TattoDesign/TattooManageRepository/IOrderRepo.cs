using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public interface IOrderRepo
    {
        void placeOrder(Order order);
        void deleteOrder(Order order);
        List<Order> findAll();
        List<Order> getOrerByUserId(int userid);
        List<Order> getOrerByArtistId(int artistid);
    }
}
