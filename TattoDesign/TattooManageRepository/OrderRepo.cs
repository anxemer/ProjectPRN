using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManagerDAO;
using TattooManagerObject.Models;

namespace TattooManageRepository
{
    public class OrderRepo : IOrderRepo
    {
        public void deleteOrder(Order order)=>OrderDao.Instance.deleteOrder(order);
        

        public List<Order> findAll()=>OrderDao.Instance.GetAllOrders();
      

        public List<Order> getOrerByArtistId(int artistid)=>OrderDao.Instance.GetOrdersByArtistId(artistid);
        

        public List<Order> getOrerByUserId(int userid)=> OrderDao.Instance.GetOrderByUserId(userid);
        

        public void placeOrder(Order order)=> OrderDao.Instance.placeOrder(order);
        
    }
}
