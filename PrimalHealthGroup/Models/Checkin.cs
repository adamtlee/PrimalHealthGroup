using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimalHealthGroup.Models
{
    public class Checkin
    {
        public int CheckinId { get; set; }

        [Display(Name = "Date & Time")]
        public DateTime Checkindt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Temperature { get; set; }

        [Display(Name = "Q1")]
        public bool Question1 { get; set; }
        [Display(Name = "Q2")]
        public bool Question2 { get; set; }
        [Display(Name = "Q3")]
        public bool Question3 { get; set; }
        [Display(Name = "Q4")]
        public bool Question4 { get; set; }
        [Display(Name = "Q5")]
        public bool Question5 { get; set; }

    }
}
