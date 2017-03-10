using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0310.Models
{
    public class OrderService
    {
        public void InsertOrder()
        {

        }
        public void DeleteOrderById()
        {

        }
        public void UpdateOrderById()
        {

        }
        public Models.Order GetOrderById()
        {
            Models.Order result = new Order();
            result.CustId = "Gss";
            result.CustName = "叡揚";
            return result;

        }

        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }
    }
}