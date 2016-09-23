using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Policy
    {
        //This will be used for automatic number generation 
        public string PolicyNumber { get; set; } 
        public decimal Version { get; set; }
        public decimal Premium { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
        public List<Claim> Claims { get; set; }

    }
}