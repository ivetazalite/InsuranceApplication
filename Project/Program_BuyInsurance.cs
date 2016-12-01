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
     
            Console.WriteLine("Please enter one of client's names -> Anna or Juris or Zinta");
            Console.WriteLine(" ");
            string name = Console.ReadLine();
            Client clientsClient = clientRepository.GetClientByName(name);
            Console.WriteLine($"You selected Client is -> {clientsClient.Name}, {clientsClient.Surname}, {clientsClient.SocialSecurityNumber}, {clientsClient.Sex}, {clientsClient.Address}");
            Console.WriteLine(" ");
            Console.WriteLine("Please enter product id  -> 1 or 2 or 3");
            Console.WriteLine(" ");
            string id = Console.ReadLine();
            Product product = productRepository.GetProductById(id: id);
            Console.WriteLine($"Your selected Product is {product.ProductName}, cost -> {product.Premium}");
            Console.WriteLine(" ");
            

            decimal premiumResult = insuranceHandler.GetPrice(client: clientsClient, productId: product);
            //Console.WriteLine("Your selected Product Premium is  -> {0}", premiumResult);

            string policyNumber = insuranceHandler.GetPolicy(client: clientsClient, productId: product);
            //Console.WriteLine("Your Policy number is  -> {0}", policyNumber);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            Console.WriteLine("OFFER: ->  {0}'s {1} Policy Premium will be {2} ", name, product.ProductName, premiumResult );
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            Console.WriteLine(" ");

            Policy policy = insuranceHandler.GetPolicyData(client: clientsClient, productId: product);
           //Console.WriteLine($"Policy start date = {policy.StartDate}, end date = {policy.EndDate}, state = {policy.State}, client = {policy.Client}");

           Console.WriteLine("If you would like to buy this Policy , then write  -> Y ");
           Console.WriteLine(" ");
           string answer = Console.ReadLine();
            if (answer == "Y")
            {
              //BuyInsurance will change state to Active and call SavePolicy method  
                Policy policy1 = insuranceHandler.BuyInsurance(client: clientsClient, productId: product);

                //Policy presentation
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
                Console.WriteLine($"Your client '{clientsClient.Name.ToUpper()} {clientsClient.Surname.ToUpper()}' bought '{product.ProductName}' Policy and Policy details are:");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
                Console.WriteLine($"Policy Number = {policy1.PolicyNumber}, ");
                Console.WriteLine($"Start date = {policy1.StartDate}");
                Console.WriteLine($"End date = {policy1.EndDate}");
                Console.WriteLine($"client name = {policy1.Client}");
                Console.WriteLine($"State = {policy1.State.ToUpper()}");
                // Console.WriteLine($"client = {policy1.Client}, State = {policy1.State}, Start date = {policy1.StartDate}, End date = {policy1.EndDate}");
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
