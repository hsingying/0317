using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0317.Areas.Order.Controllers
{
    public class OrderController : Controller
    { // GET: Order/Order
        /// <summary>
        /// 訂單管理系統
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            Models.OrderService orderservice = new Models.OrderService();
            var order = orderservice.GetOrderById("111");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            return View();
        }
        /// <summary>
        /// 新增訂單存檔的action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InsertOrder(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
        }
    }
}