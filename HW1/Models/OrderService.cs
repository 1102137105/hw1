using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderService
    {   
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrder(Models.Order order)
        {

        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrder(string id)
        {

        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder(Models.Order order)
        {

        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Models.Order GetOrder(string id)
        {
            Models.Order result = new Order();
            result.CustId = "gss";
            result.CustName = "加一";
            return result;
        }
        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }

    }
}
