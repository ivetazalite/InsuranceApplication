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
            

            // var obj = myList.FirstOrDefault(x => x.MyProperty == myValue);
            // if (obj != null) obj.OtherProperty = newValue;
            // http://stackoverflow.com/questions/7190016/how-to-update-an-object-in-a-list-in-c-sharp


            Policy policy = policyRepository.UpdatePolicyState(policyNumber);

            policyRepository.SavePolicy(policy);

            return policy; // policyRepository.UpdatePolicyState(policyNumber);

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