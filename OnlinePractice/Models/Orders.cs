using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlinePractice.Models
{
    public class Orders
    {
        [Key]
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }

        public Guid CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}