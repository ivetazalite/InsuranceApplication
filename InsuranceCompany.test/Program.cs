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
            //insuranceHandler.GetPrice(client: clientsClient, productId: 1 );

            //salīdzināt iegūto rezultātu
            decimal premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: 1);
            Console.WriteLine(premiumResult == 50);
            premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: 2);
            Console.WriteLine(premiumResult == 40);
            Console.ReadKey();
            // atrod polisi, kas tika izveidota GetPrice metodes lika
            //parbauda, vai stuss ir draft
            // izsauc metodi buyinsurance, 
            //atrod polisi, parbauda vai statuss ir active
            //pietrukst: 
            // 1. getprice metode jaatgriez policy tips
            // 2. test piemera cenu jaizgust no polises
            
        }
    }
}
