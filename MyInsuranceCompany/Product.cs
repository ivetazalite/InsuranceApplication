using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Product
    {
        public string ProductName { get; set; }

        public DateTime CreatDateTime { get; set; }
        public string ProductId { get; set; }
        public decimal Premium { get; set; }
        public Policy Policy { get; set; }
    }
}