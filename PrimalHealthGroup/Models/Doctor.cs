using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimalHealthGroup.Models
{
    public class Doctor
    {
        [Display(Name = "Id")]
        public int DoctorId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        public string Email { get; set; }

        [Display(Name = "Concentration Type")]
        public Concentration ConcentrationType { get; set; }
        
    }
}
