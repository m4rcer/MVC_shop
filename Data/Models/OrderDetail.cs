 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopStuding.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int carId { get; set; }
        public ushort price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order order { get; set; }
    }
}
