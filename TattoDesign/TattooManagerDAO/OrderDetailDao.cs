using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManagerDAO
{
    public class OrderDetailDao
    {
        private static OrderDetailDao instance = null;
        public OrderDetailDao() { }
        public static OrderDetailDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDao();
                }
                return instance;
            }
        }
        public void addOrderDetail(OrderDetail orderDetail)
        {
            var dbContext = new TattooshopContext();
             dbContext.OrderDetails.Add(orderDetail);
            dbContext.SaveChanges();
        }
        public List<OrderDetail> GetOrderDetailByOrderId(int orderId) {
            var dbContext = new TattooshopContext();
            return dbContext.OrderDetails.Where(od => od.OrderId.Equals(orderId)).ToList();
        }
    }
}
