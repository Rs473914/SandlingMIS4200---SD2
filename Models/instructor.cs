using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandlingMIS4200.Models
{
    public class instructor
    {
        public int instructorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string officeNumber { get; set; }
        public DateTime instructorSince { get; set; }


        public ICollection<courseDetail> courseDetail { get; set; }
    }
}