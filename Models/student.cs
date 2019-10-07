using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SandlingMIS4200.Models
{
    public class student
    {
        [Key]
        public int studentID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a first name")]
        [StringLength(25)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]      
        [Required(ErrorMessage = "Please enter a last name")]
        [StringLength(25)]
        public string lastName { get; set; }

        [Display(Name = "Email Address")]
        
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage ="Phone numbers must be in the format (xxx) xxx xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Current Address")]
        public string address { get; set; }
        [Display(Name = "Enrollment Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="{0:MM/DD/YYYY", ApplyFormatInEditMode =true)]
        public DateTime studentSince { get; set; }
        [Display(Name = "Student")]
        public string fullName { get { return lastName + ", " + firstName; } }
        

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