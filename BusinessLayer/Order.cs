using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
          public DateTime OrderDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }

        public Status OrderStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public class OrderDetail
        {
            [Key]
            public int Id { get; set; }
            [ForeignKey("Order")]
            public int OrderId { get; set; }
            public Order Order { get; set; }

            public int Qty { get; set; }
            public Mixing Mixing { get; set; }

        }
       
        public class Mixing
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

        }
        public class Status
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

        }
    }
   
}
