using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerDAO
{
    public class OrderDao
    {
        public static OrderDao instance = null;
        private OrderDao() { }
        public static OrderDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDao();
                }
                return instance;
            }
        }
        public void placeOrder(Order order)
        {
            var dbContext = new TattooshopContext();
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }
        public Order getOrderById(int id)
        {

            var dbContext = new TattooshopContext();
            return dbContext.Orders.SingleOrDefault(o => o.Id.Equals(id));
        }
        public void deleteOrder(Order order)
        {
            var dbContext = new TattooshopContext();
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
        }
        public List<Order> GetAllOrders()
        {
            var dbContext = new TattooshopContext();
            return dbContext.Orders.ToList();
        }
        public List<Order> GetOrderByUserId(int userid) {
            var dbContext = new TattooshopContext();
            return dbContext.Orders.Where(o => o.UserId.Equals(userid)).ToList();

        }
        public List<Order> GetOrdersByArtistId(int artistId)
        {
            var dbContext = new TattooshopContext();
            return dbContext.Orders.Where(o => o.ArtistId.Equals(artistId)).ToList();
        }

    }
}
