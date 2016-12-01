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

            

            decimal premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: product);
            Console.WriteLine("Your selected Product Premium is  -> {0}", premiumResult);

            string policyNumber = insuranceHandler.GetPolicy(client: clientsClient, productId: product);

            Console.WriteLine("Your Policy number is  -> {0}", policyNumber);

       

           Console.WriteLine("{0}'s {1} Policy Premium will be {2} ", name, product.ProductName, premiumResult );

           Policy policy = insuranceHandler.GetPolicyData(client: clientsClient, productId: product);

           Console.WriteLine($"Policy start date = {policy.StartDate}, end date = {policy.EndDate}, state = {policy.State}, client = {policy.Client}");





            Console.WriteLine("If you want to buy this Policy , then write  -> Yes ");
           string answer = Console.ReadLine();


            if (answer == "Yes")
            {
                Console.WriteLine("Buy Insurance method should be used here");
              

                Policy policy1 = insuranceHandler.BuyInsurance(client: clientsClient, productId: product);
                Console.WriteLine($"Policy {policy1.PolicyNumber}, {policy1.State}");
                Console.ReadKey();
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
