using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInsuranceCompany;

namespace InsuranceCompany.test
{
    class Program
    {
        static void Main(string[] args)
        {

            //Izveidot Clientu objektu
            //Izvēlēties Produkta ID

            //izdomāt test piemēru , kā izsaukt getprice metodi 
            
            InsuranceHandler insuranceHandler = new InsuranceHandler();
            ClientRepository clientRepository = new ClientRepository();
            Client clientsClient = clientRepository.GetClientBySsn("121290-11233");
            insuranceHandler.GetPrice(client: clientsClient, productId: 1 );

          

            //salīdzināt iegūto rezultātu



        }
    }
}
