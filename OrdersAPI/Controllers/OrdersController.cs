using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace OrdersAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class OrdersController : ControllerBase
  {
    [HttpGet("{id}")]
    public IEnumerable<Order> Get(int id)
    {
      return new List<Order>() {
        new Order() { OrderId = 1, OrderAmount = 250, OrderData = DateTime.Now.AddDays(-2) },
        new Order() { OrderId = 2, OrderAmount = 450, OrderData = DateTime.Now.AddDays(-1) }
      };

    }
  }
}
