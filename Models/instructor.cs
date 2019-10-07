using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandlingMIS4200.Models
{
    public class instructor
    {
        public int instructorID { get; set; }
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
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone numbers must be in the format (xxx) xxx xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Office")]
        public string officeNumber { get; set; }
        [Display(Name = "Began Employment")]
        public DateTime instructorSince { get; set; }


        public ICollection<course> course { get; set; }
    }
}