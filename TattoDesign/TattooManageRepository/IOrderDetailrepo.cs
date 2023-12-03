using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public interface IOrderDetailrepo
    {
        void addOrderDetail(OrderDetail orderDetail);
        List<OrderDetail> GetOrderDetailsByOrderId(int orderid);
    }
}
