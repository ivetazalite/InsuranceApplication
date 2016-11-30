using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MyInsuranceCompany;

namespace InsuranceCompany.test
{
    class Program_UnitTests
    {
        static void Main(string[] args)
        {

            //Izveidot Clientu objektu
            //Izvēlēties Produkta ID

            //izdomāt test piemēru , kā izsaukt getprice metodi 
            
            InsuranceHandler insuranceHandler = new InsuranceHandler();
            ClientRepository clientRepository = new ClientRepository();
            ProductRepository productRepository = new ProductRepository();
            // Read client Name 
           // string name;
            Console.WriteLine("Please enter one of clients names -> Anna or Juris or Zinta");
            string name = Console.ReadLine();
            // Console.WriteLine(name);
           // Console.WriteLine("Please enter product id -> 1 or 2 or 3");
    


            Client clientsClient = clientRepository.GetClientByName(name);
          

            //  Product product = productRepository.GetProductById(id: 1);
            //if (clientsClient != null)
            //{
            //    return clientsClient;
            //    Console.WriteLine(" Your seleted clients name is {0} and surname is {1}", clientsClient.Name, clientsClient.Surname);
            //}
            //else
            //{
            //    // throw new ApplicationException("Policy with "+ policyNumber +" not found");
            //    throw new ApplicationException($"Client with  {name} not found");
            //}


            Console.WriteLine(" Your seleted client's name - '{0}' and surname - '{1}' and SSN - '{2}' and Address -'{3}'", clientsClient.Name, clientsClient.Surname,clientsClient.SocialSecurityNumber, clientsClient.Address);
           Console.WriteLine("************************************************************************************************ ");


            Console.WriteLine("Please add Product id -> 1 or 2 or 3");
            string id = Console.ReadLine();
            Product product = productRepository.GetProductById(id: id);

            // Client clientsClient = clientRepository.GetClientBySsn("121290-11233");
            //insuranceHandler.GetPrice(client: clientsClient, productId: 1 );

            //salīdzināt iegūto rezultātu

            decimal premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: product);

            if (product.ProductId == "1")
               {

                //   decimal premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: product);

                //product = productRepository.GetProductById(id: "1");

             
                Console.WriteLine("                  ************** Unit Test Nr 1 ********************                   ");
                Console.WriteLine("Verify that Client with SSN = {0} price for product {2} is 20 -> {1}", clientsClient.SocialSecurityNumber, premiumResult == 20, product.ProductName);
               
                }
            if (product.ProductId == "2")
            {
                //Product product2 = productRepository.GetProductById(id: "2");
                Console.WriteLine("                  ************** Unit Test Nr 2 ********************                    ");
                Console.WriteLine("Verify that Client with SSN = {0} price for product {2} is 100 -> {1}", clientsClient.SocialSecurityNumber, premiumResult == 100, product.ProductName);
            }
            if (product.ProductId == "3")
            {
                Console.WriteLine("                  ************** Unit Test Nr 3 ********************                    ");
                Console.WriteLine("Verify that Client with SSN = {0} price for product {2} is 300 -> {1}", clientsClient.SocialSecurityNumber, premiumResult == 300, product.ProductName);

            }

     
            premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: product);

            //product = productRepository.GetProductById(id: "1");
           // Console.WriteLine("                  ************** Unit Test Nr 1 ********************                   ");
           // Console.WriteLine("Verify that Client with SSN = {0} price for product {2} is 20 -> {1}",clientsClient.SocialSecurityNumber, premiumResult == 20, product.ProductName);


            //premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: "2");
            //Product product2 = productRepository.GetProductById(id: "2");
            //Console.WriteLine("                  ************** Unit Test Nr 2 ********************                    ");
            //Console.WriteLine("Verify that Client with SSN = {0} price for product {2} is 100 -> {1}", clientsClient.SocialSecurityNumber, premiumResult == 100, product2.ProductName);


            //premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: "3");
            //Product product1 = productRepository.GetProductById(id: "3");
            //Console.WriteLine("                  ************** Unit Test Nr 3 ********************                    ");
            //Console.WriteLine("Verify that Client with SSN = {0} price for product {2} is 300 -> {1}", clientsClient.SocialSecurityNumber, premiumResult == 300, product1.ProductName);

           
           
            
            // atrod polisi, kas tika izveidota GetPrice metodes lika

            string policyNumber = insuranceHandler.GetPolicy(client: clientsClient, productId: product);
            Console.WriteLine(" Policy Number is {0} " , policyNumber);

          



            Console.ReadKey();

            //parbauda, vai statuss ir draft

            


            // izsauc metodi buyinsurance, 
            //atrod polisi, parbauda vai statuss ir active
            //pietrukst: 
            // 1. getprice metode jaatgriez policy tips
            // 2. test piemera cenu jaizgust no polises





        }
    }
}
