using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Claim
    {
        public string ClaimId { get; set;  }
        public decimal Premium { get; set; }
        public string ClaimName { get; set;  }
        public Client Client { get; set; }
        public Policy Policy { get; set; }
    }
}