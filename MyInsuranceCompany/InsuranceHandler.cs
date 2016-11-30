using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace MyInsuranceCompany
{
    public class InsuranceHandler
    {
        public Policy BuyInsurance(Client client, Product productid )
        {
            ProductRepository productRepository = new ProductRepository();
            PolicyRepository policyRepository = new PolicyRepository();
            //atrodam policy number ar Get Policy palīdzību pēc client and product id 
            
            string policyNumber = GetPolicy(client, productid);
            Console.WriteLine(policyNumber);

           
            // nomainīt vērtību pie State uz active -> policyRepository.SavePolicy( )
            //    Policy policy =



            //  policyRepository.SavePolicy(policy)

            //atgriezt jaunizveidoto polisi 

            decimal policyPremium = policyRepository.GetPolicyPriceByNumber(policyNumber);

            Console.WriteLine(policyPremium);

            Policy policy = policyRepository.GetPolicyByNumber(policyNumber);//productRepository.GetProductById(id: id);

            Console.WriteLine("Policy number {0}, start date - {1}, end date - {2}, premium - {3}, state - {4}", policy.PolicyNumber, policy.StartDate,policy.EndDate, policy.Premium,policy.State 
                );
         

          
          // Policy policyNewPolicy = policyRepository.GetPolicyByNumber(policyNumber: policyNumber);

            return new Policy();
            //   policyRepository.SavePolicy( );

        }

        /// <summary>
        /// Products
        /// Client data
        /// 
        /// </summary>
        public decimal GetPrice(Client client, Product productId)
        {

            ProductRepository  productRepository= new ProductRepository();
            var product = productRepository.GetProductById(productId.ProductId);
            
            
            //Izveidot Polices repozitoriju un izmantot metodi 
            //Create a policy
            PolicyRepository policyRepository = new PolicyRepository();
            var policyNumber = policyRepository.CreateNewPolicy(product, client);

            //Return a policy price 
            return policyRepository.GetPolicyPriceByNumber(policyNumber);
            
        }

        public string GetPolicy(Client client, Product productId)
        {

            ProductRepository productRepository = new ProductRepository();
            var product = productRepository.GetProductById(productId.ProductId);


            //Izveidot Polices repozitoriju un izmantot metodi 
            //Create a policy
            PolicyRepository policyRepository = new PolicyRepository();
            var policyNumber = policyRepository.CreateNewPolicy(product, client);
            
            //Return a policy number
            return
          policyRepository.GetPolicyByNumber(policyNumber).PolicyNumber;
        // policyRepository.GetPolicyByNumber(policyNumber).State;

        }


    }
}