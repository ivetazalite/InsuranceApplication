using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInsuranceCompany
{
    public class ProductRepository
    {
        //This is were we are going to store all data 
        private readonly List<Product> _products = CreateProducts();

        private static List<Product> CreateProducts()
        {
            return new List<Product>()
                   {
                       new Product()
                       {
                           ProductName = "MTPL",
                           CreatDateTime = new DateTime(2016, 9, 23),
                           ProductId = "1",
                           Premium = 20
                       },
                       new Product()
                       {
                           ProductName = "Health",
                           CreatDateTime = new DateTime(2016, 9, 23),
                           ProductId = "2",
                           Premium =100
                       },
                       new Product ()
                       {
                       ProductName = "Property",
                       CreatDateTime = new DateTime(2016, 9, 23),
                       ProductId = "3",
                       Premium = 300
                      }
                   };
        }

        public Product GetProductById(string id)
        {
           
            //This one string possible to use instead of next peace of code 
             return _products.FirstOrDefault(x => x.ProductId == id);


            //foreach (var product in _products)
            //{
            //    if (product.ProductId == id)
            //    {
            //        return product;
            //    }
            //}
            //return null;
        }

        public Product GetProductByName(string name)
        {

         return _products.FirstOrDefault(x => x.ProductName == name);

        }

    }

}