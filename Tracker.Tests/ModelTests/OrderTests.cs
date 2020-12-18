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
    public void OrderConstructor_CreatesInstancesofOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Coffee beans.";

      //Act
      Order newOrder = new Order(description);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Cofee Beans.";
      Order newOrder = new Order(description);

      //Act
      string updatedDescription = "Coffee Mugs.";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order> { };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange 
      string description01 = "Coffee Beans";
      string description02 = "Coffee Mugs";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};
      //Act 
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange 
      string description = "Cofee Beans";
      Order newOrder = new Order(description);
      //Act
      int result = newOrder.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
  }
} 