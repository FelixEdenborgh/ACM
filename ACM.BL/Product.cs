using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        private string _productName;

        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }


        public int ProductId { get; private set; }
        public string ProductName
        {
            get
            {
                //instance som lägger till space om det är upper case letter
                //var stringHandler = new StringHandler();
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductDescription { get; set;}
        public decimal? CurrentPrice { get; set; } // can be null

        public override string ToString() => ProductName;
        //public Product Retrieve(int productId)
        //{
        //    return new Product();
        //}

        //public bool Save()
        //{
        //    return true;
        //}

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if(CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
