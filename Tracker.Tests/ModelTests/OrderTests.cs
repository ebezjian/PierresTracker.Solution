using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]

  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
    Order newOrder = new Order("testTitle", "testDescription", 10, "13/12/2023");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

        [TestMethod]
    public void OrderConstructor_ReturnsOrderTitle_String()
    {
      string title = "TestTitle";
      Order newOrder = new Order(title, "testDescription", 10, "13/12/2023");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void OrderConstructor_ReturnsOrderDescription_String()
    {
      string title = "TestTitle";
      string description = "testDescription";
      Order newOrder = new Order(title, description, 10, "13/12/2023");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void OrderConstructor_ReturnsOrderPrice_Int()
    {
      string title = "TestOrder";
      string description = "testExample";
      int price = 8;
      Order newOrder = new Order(title, description, price, "13/12/2023");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }




  }
}