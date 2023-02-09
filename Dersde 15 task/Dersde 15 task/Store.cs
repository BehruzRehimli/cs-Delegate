using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_15_task
{
    internal class Store
    {
        private List<Product> products= new List<Product>();
        public void AddProduct(Product pr)
        {
            if (pr.Price>0)
            {
                products.Add(pr);
            }
        }
        public List<Product> GetDiscountedProducts(Func<byte,bool> percent) 
        {
            List<Product> products = new List<Product>();
            foreach (var item in this.products)
            {
                if (percent(item.DiscountPercent))
                {
                    products.Add(item);
                }
            }
            return products;
        }
        public List<Product> GetProductByPriceRange(double min,double max)
        {
            List<Product> products = new List<Product>();
            foreach (var item in this.products)
            {
                if (item.Price>=min&&item.Price<=max)
                {
                    products.Add(item);
                }
            }
            return products;
        }
    }
}
