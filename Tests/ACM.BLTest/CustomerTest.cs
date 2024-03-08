using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;


namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            //-- Act

            //-- Assert


        }
    }
}
