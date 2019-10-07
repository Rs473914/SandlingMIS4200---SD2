using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandlingMIS4200.Models
{
    public class courseDetail
    {
        public int coursedetailId { get; set; }
        [Display(Name = "Grade")]
        [Required(ErrorMessage = "Please enter a grade")]
        public string courseGrade { get; set; }
        [Display(Name = "Semester")]
        [Required(ErrorMessage = "Please enter a semester date")]
        public DateTime courseDate { get; set; }

        // the next two properties link the orderDetail to the Order
        public int courseID { get; set; }
        public virtual course course { get; set; }

        // the next two properties link the orderDetail to the Product
        public int studentId { get; set; }
        public virtual student student { get; set; }

        public int instructorId { get; set; }
        public virtual instructor instructor { get; set; }
    }
}