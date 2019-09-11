using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandlingMIS4200.Models
{
    public class order
    {
        public int orderID { get; set; }
        public int customerID { get; set; }
        public virtual customer customer { get; set; }  // adding this allows all of the customer information to be inserted into the order table
        public DateTime orderDate { get; set; }
    }
}