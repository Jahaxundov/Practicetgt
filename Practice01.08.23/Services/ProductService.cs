using Practice01._08._23.Models;
using Practice01._08._23.Services.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01._08._23.Services
{
    internal class ProductService : IProductService
    {
        public List<Product> GetProduct()
        {
            List<Product> list = new()
            {
                new Product{Id=1,Name="Cola",Salary=2},
                new Product{Id=2,Name="Fanta",Salary=4},
                new Product{Id=3,Name="Sprite",Salary=6}
            };
            return list;
        }


        public string Search(string searchText)
        {
            var products = GetProduct();
            foreach (var product in products)
            {

            }
            
        }
    }

       
 }

