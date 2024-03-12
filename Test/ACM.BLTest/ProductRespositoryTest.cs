//using ACM.BL;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

//namespace ACM.BLTest
//{
//    [TestClass()]
//    public class ProductRespositoryTest
//    {
//        [TestMethod()]
//        public void RetrieveTest()
//        {
//            //-- Arrange
//            var productRepository = new ProductRepository();
//            var expected = new Product(2)
//            {
//                CurrentPrice = 15.96m,
//                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
//                ProductName = "SunFlowers"
//            };

//            //-- Act
//            var actual = productRepository.Retrieve(2);

//            //-- Assert
//            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
//            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
//            Assert.AreEqual(expected.ProductName, actual.ProductName);
//        }
//    }
//}
