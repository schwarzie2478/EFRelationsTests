using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFRelationTests.Model;
using System.Collections.Generic;

namespace EFRelations.Test
{
    [TestClass]
    public class EFRelationTesting
    {
        [TestMethod]
        public void TestGetFromCustomerRepo()
        {
            var repo = Mocks.Factory.GetCustomerRepo();
            var result = repo.GetAll();
            Assert.IsInstanceOfType(result, typeof(List<Customer>));
        }
        [TestMethod]
        public void TestAddCustomerToRepo()
        {
            var repo = Mocks.Factory.GetCustomerRepo();
            var customer = Mocks.Factory.CreateCustomer();
            repo.Save(customer);

            repo.DbContext.SaveChanges();
            var result = repo.GetAll();
            Assert.IsInstanceOfType(result, typeof(List<Customer>));
            Assert.IsTrue(result.Count > 0);


        }

        [TestMethod]
        public void TestGetFromRepo()
        {
            var repo = Mocks.Factory.GetOrderRepo();
            var result = repo.GetAll();
            Assert.IsInstanceOfType(result, typeof(List<Order>));
        }
        [TestMethod]
        public void TestAddOrderToRepo()
        {
            var crepo = Mocks.Factory.GetCustomerRepo();
            var customer = Mocks.Factory.CreateCustomer();
            crepo.Save(customer);

            crepo.DbContext.SaveChanges();

            var orepo = Mocks.Factory.GetOrderRepo();
            var order = Mocks.Factory.CreateOrder();
            order.Customer = customer;
            orepo.Save(order);

            orepo.DbContext.SaveChanges();
            var result = orepo.GetAll();
            Assert.IsInstanceOfType(result, typeof(List<Order>));
            Assert.IsTrue(result.Count > 0);
            var newResult = Mocks.Factory.GetNewCustomerRepo().GetAll()[0].Orders;
            Assert.IsTrue(newResult.Count > 0);

        }
        [TestMethod]
        public void TestUpdateOrder()
        {
            var repo = Mocks.Factory.GetOrderRepo();
            var order = Mocks.Factory.CreateOrder();
            repo.Save(order);
            repo.DbContext.SaveChanges();
            var result = repo.GetAll();

            var updateOrder = result[0];

            updateOrder.OrderLines[0].Quantity = 2.0;
            var orderLine = Mocks.Factory.CreateOrderLine();
            orderLine.ProductType = "An other product";
            order.OrderLines.Add(orderLine);
            repo.DbContext.SaveChanges();

        }


    }
}
