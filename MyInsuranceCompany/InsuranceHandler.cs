using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class InsuranceHandler
    {
        public void BuyInsurance()
        {
            
        }

        /// <summary>
        /// Products
        /// Client data
        /// 
        /// </summary>
        public decimal GetPrice(Client client, int productId)
        {

            ProductRepository  productRepository= new ProductRepository();
            var product = productRepository.GetProductById(productId);
            
            
            //Izveidot Polices repozitoriju un izmantot metodi 
            //Create a policy
            PolicyRepository policyRepository = new PolicyRepository();
            var policyNumber = policyRepository.CreateNewPolicy(product, client);

            //Return a policy
            return policyRepository.GetPolicyPriceByNumber(policyNumber);

            
        }


    }
}