using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class Client
    {
        public string Name { get; set;}
        public string Surname { get; set; }
        public ClientType ClientType { get; set; }
        public string Address { get; set; }
        public string SocialSecurityNumber { get; set; }
        public Sex Sex { get; set; }

        public List<Policy> Policies { get; set; }
    }

    public enum ClientType
    {
        Private,
        Commercial
    }

    public enum Sex
    {
        Femail,
        Mail
    }
}