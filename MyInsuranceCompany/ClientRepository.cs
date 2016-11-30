using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class ClientRepository
    {
        //This is were we are going to store all data 
        private readonly List<Client> _clients = CreateClient();

        private static List<Client> CreateClient()
        {
            return new List<Client>()
                   {
                       new Client()
                       {
                           Name = "Anna",
                           Surname = "Liepa",
                           Sex = Sex.Femail,
                           SocialSecurityNumber = "121290-11233",
                           Address = "Liepu iela 3-3",
                           ClientType = ClientType.Private

                       },
                       new Client()
                       {
                           Name = "Juris",
                           Surname = "Liepa",
                           Sex = Sex.Mail,
                           SocialSecurityNumber = "221291-14444",
                           Address = "Liepu iela 3-4",
                           ClientType = ClientType.Private
                       },
                       new Client()
                       {
                           Name = "Zinta",
                           Surname = "Zeme",
                           Sex = Sex.Femail,
                           SocialSecurityNumber = "121256-16233",
                           Address = "Zušu iela 44",
                           ClientType = ClientType.Private
                       }
                   };
        }
        public Client GetClientBySsn(string clientSsn)
        {
            return _clients.FirstOrDefault(x => x.SocialSecurityNumber == clientSsn);
        }

        public Client GetClientByName(string clientName)
        {
            return _clients.FirstOrDefault(x => x.Name == clientName);
        }
    }
}