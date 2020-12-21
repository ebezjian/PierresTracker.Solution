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
      string title = "TestTitle";
      string description = "testDescription";
      int price = 10;
      Order newOrder = new Order(title, description, price, "13/12/2023");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void OrderConstructor_ReturnsOrderDate_String()
    {
      string title = "TestTitle";
      string description = "testDescription";
      int price = 10;
      string date = "13/12/2023";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual (date, result);
    }

        [TestMethod]
    public void GetOrders_ReturnsListofOrderObjects_OrderList()
    {
      string title1 = "TestTitle1";
      string description1 = "testDescription1";
      int price1 = 10;
      string date1 = "13/12/2023";
      string title2 = "TestOrder2";
      string description2 = "testDescription2";
      int price2 = 10;
      string date2 = "13/12/2023";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, result);
    }




  }
}