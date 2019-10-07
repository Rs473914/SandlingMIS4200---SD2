using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandlingMIS4200.Models
{
    public class course
    {
        public int courseID { get; set; }
        [Display(Name = "Course")]
        [Required(ErrorMessage = "Please enter a course name")]
        public string courseName { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter a course description")]
        public string courseDescription { get; set; }
        [Display(Name="Credit Hours")]
        public string creditHours { get; set; }
        

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Course
        // (the object name and the local name do not have to be the same)
        public ICollection<courseDetail> courseDetail { get; set; } // The I before collection means interface

    }
}