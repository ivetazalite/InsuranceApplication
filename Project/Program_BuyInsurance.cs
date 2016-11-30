using System;
using MyInsuranceCompany;

namespace Project
{
    class Program_BuyInsurance
    {
        static void Main(string[] args)
        {
            
            InsuranceHandler insuranceHandler = new InsuranceHandler();
            ClientRepository clientRepository = new ClientRepository();
            ProductRepository productRepository = new ProductRepository();
            PolicyRepository policyRepository = new PolicyRepository();

            Console.WriteLine("Please enter one of client's names -> Anna or Juris or Zinta");
            string name = Console.ReadLine();
            Client clientsClient = clientRepository.GetClientByName(name);

            Console.WriteLine("Please enter product id  -> 1 or 2 or 3");
            string id = Console.ReadLine();
            Product product = productRepository.GetProductById(id: id);

            //insuranceHandler.GetPrice(client: clientsClient, productId: 1 );

            decimal premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: product);


         
            Policy policy = policyRepository.GetPolicyByClient(clientsClient);

            Console.WriteLine("Policy is {0}" , policy);

            Console.WriteLine("{0}'s {1} Policy Premium will be {2} ", name, product.ProductName, premiumResult );
            Console.WriteLine("If you want to buy this Policy , then write  -> Yes ");
            string answer = Console.ReadLine();


            if (answer == "Yes")
            {
                Console.WriteLine("Buy Insurance method should be used here");
                Console.ReadKey();
               insuranceHandler.BuyInsurance(client: clientsClient, productid: product) ; 
             }
            else
            {
                Console.WriteLine("See you next time!");
            }


            Console.ReadKey();

            //parbauda, vai stuss ir draft
            // izsauc metodi buyinsurance, 
            //atrod polisi, parbauda vai statuss ir active
            //pietrukst: 
            // 1. getprice metode jaatgriez policy tips
            // 2. test piemera cenu jaizgust no polises

        }
    }
}
