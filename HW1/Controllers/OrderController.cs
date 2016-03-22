using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0317.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            var order = orderService.GetOrder("111");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;
            Console.WriteLine(ViewBag.CustName);
            return View();
        }
    }
}