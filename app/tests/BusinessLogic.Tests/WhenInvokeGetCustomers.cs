using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class WhenInvokeGetCustomers
    {
        [TestMethod]
        public void ThenShouldReturnAllCustomers()
        {
            var customerBl = new CustomerLogic();

            var allCustomers = customerBl.GetCustomers();

            Assert.IsTrue(allCustomers.Any());
        }
    }
}
