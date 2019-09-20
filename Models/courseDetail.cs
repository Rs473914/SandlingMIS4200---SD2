using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandlingMIS4200.Models
{
    public class courseDetail
    {
        public int coursedetailId { get; set; }
        public DateTime courseDate { get; set; }

        // the next two properties link the orderDetail to the Order
        public int courseID { get; set; }
        public virtual course course { get; set; }

        // the next two properties link the orderDetail to the Product
        public int instructorId { get; set; }
        public virtual instructor instructor { get; set; }
    }
}