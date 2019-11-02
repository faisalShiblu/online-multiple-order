using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlinePractice.Models
{
    public class Customer
    {
        [K]
        public Guid CustomerID { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}