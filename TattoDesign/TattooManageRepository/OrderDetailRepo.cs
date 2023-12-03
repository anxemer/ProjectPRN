using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public class OrderDetailRepo : IOrderDetailrepo
    {
        public void addOrderDetail(OrderDetail orderDetail)=>OrderDetailDao.Instance.addOrderDetail(orderDetail);
        

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderid)=> OrderDetailDao.Instance.GetOrderDetailByOrderId(orderid);

    }
}
