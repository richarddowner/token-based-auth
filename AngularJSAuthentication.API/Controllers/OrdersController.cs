using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AngularJSAuthentication.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }

        public static List<Order> CreateOrders()
        {
            List<Order> OrderList = new List<Order>
            {
                new Order { OrderId = 10248, CustomerName = "Taiseer Joudeh", ShipperCity = "Amman", IsShipped = true },
                new Order { OrderId = 10249, CustomerName = "Richard Downer", ShipperCity = "Auckland", IsShipped = false },
                new Order { OrderId = 10250, CustomerName = "Another Person", ShipperCity = "Hamilton", IsShipped = true }
            };

            return OrderList;
        }
    }
}