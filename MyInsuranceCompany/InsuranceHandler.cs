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
        public void GetPrice(Client client, int productId )
        {

            ProductRepository  productRepository= new ProductRepository();
            var product = productRepository.GetProductById(productId);
            
            //Calculate price

            //Create a policy

            //Izveidot Polices repozitoriju un izmantot metodi 

            //Return a policy


        }


    }
}