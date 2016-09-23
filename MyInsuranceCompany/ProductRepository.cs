using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class ProductRepository
    {
        //This is were we are going to store all data 
        private List<Product> _products = CreateProducts();

        private static List<Product> CreateProducts()
        {
            return new List<Product>()
                   {
                       new Product()
                       {
                           ProductName = "MTPL",
                           CreatDateTime = new DateTime(2016, 9, 23),
                           ProductId = 1
                       },
                       new Product()
                       {
                           ProductName = "Health",
                           CreatDateTime = new DateTime(2016, 9, 23),
                           ProductId = 2
                       },
                       new Product ()
                       {
                       ProductName = "Property",
                       CreatDateTime = new DateTime(2016, 9, 23),
                       ProductId = 3
                      }
                   };
        }

        public Product GetProductById(int id)
        {
           
            //This one string possible to use instead of 
            // return _products.FirstOrDefault(x => x.ProductId == id);

            foreach (var product in _products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }
            return null;
        }



    }

}