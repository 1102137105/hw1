using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW1.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        /// <summary>
        /// 訂單管理首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            Models.CodeService test = new Models.CodeService();
            ViewBag.EmpCodeData = test.GetEmp();
            Models.OrderService orderService = new Models.OrderService();
            //var data = orderService.GetOrderByIdCondtioin();
            ViewBag.selectResult = false;
            return View();
        }

        [HttpPost()]
        public ActionResult Index(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            //Models.CodeService test = new Models.CodeService();
            //ViewBag.EmpCodeData = test.GetEmp();
            //ViewBag.ProductCodeData = test.GetProduct();
            ViewBag.selectResult = true;
            var data = orderService.GetOrderByIdCondtioin(order);
            ViewBag.data = data;
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
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpPost()]
        public JsonResult DeleteOrder(string orderid)
        {
            try
            {
                Models.OrderService OrderService = new Models.OrderService();
                OrderService.DeleteOrderById(orderid);
                return this.Json(true);
            }
            catch (Exception)
            {

                return this.Json(false);
            }


        }
        
    }
}