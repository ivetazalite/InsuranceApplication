using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace MyInsuranceCompany
{
    public class InsuranceHandler
    {
        public Policy BuyInsurance(Client client, Product productId)
        {
            ProductRepository productRepository = new ProductRepository();
            var product = productRepository.GetProductById(productId.ProductId);


            //Izveidot Polices repozitoriju un izmantot metodi 
            //Create a policy
            PolicyRepository policyRepository = new PolicyRepository();
            var policyNumber = policyRepository.CreateNewPolicy(product, client);

          //policyRepository.GetPolicyByNumber(policyNumber);

            policyRepository.SavePolicy(new Policy());

            return new Policy(); 

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


        public Policy GetPolicyData(Client client, Product productId)
        {

            ProductRepository productRepository = new ProductRepository();
            var product = productRepository.GetProductById(productId.ProductId);


            //Izveidot Polices repozitoriju un izmantot metodi 
            //Create a policy
            PolicyRepository policyRepository = new PolicyRepository();
            var policyNumber = policyRepository.CreateNewPolicy(product, client);

            //Return a policy number
            return
          policyRepository.GetPolicyByNumber(policyNumber);
            // policyRepository.GetPolicyByNumber(policyNumber).State;

        }

      
    }
}