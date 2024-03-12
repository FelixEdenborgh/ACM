using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId == 2 )
            {
                product.ProductName = "SunFlowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96m;
            }


            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
