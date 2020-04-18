using System;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //Methodname_condition_expectation
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShippmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1,order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
