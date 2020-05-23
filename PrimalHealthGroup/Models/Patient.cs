using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimalHealthGroup.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        [Display(Name = "Insurance")]
        public Insurance InsuranceType { get; set; }

        [Display(Name = "Issue Type")]
        public Concentration IssueType { get; set; }
    }
}
