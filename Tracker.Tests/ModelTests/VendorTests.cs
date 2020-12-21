using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
{
[TestClass]

  public class VendorTest: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
    Vendor newVendor = new Vendor("test", "test");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ReturnsVendorName_String()
    {
      string vendorName = "TestVendor";
      Vendor newVendor = new Vendor(vendorName, "test");
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void VendorConstructor_ReturnsVendorDescription_String()
    {
      string vendorName = "TestVendor";
      string vendorDescription = "testDescription";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string result = newVendor.VDescription;
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void GetVendors_ReturnsListofVendorObjects_VendorList()
    {
      string vendorName1 = "TestVendor1";
      string vendorDescription1 = "testDescription1";
      string vendorName2 = "TestVendor2";
      string vendorDescription2 = "testDescription2";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      List<Vendor> newVendorList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "TestVendor";
      string vendorDescription = "testDescription";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderObjectInListWithinVendorObject_OrderList()
    {
    string vendorName = "TestVendor";
    string vendorDescription = "testDescription";
    string title = "TestOrder1";
    string description = "testDescription";
    int price = 8;
    string date = "12/18/2020";
    Vendor newVendor = new Vendor(vendorName, vendorDescription);
    Order newOrder = new Order(title, description, price, date);
    List<Order> newList = new List<Order> { newOrder };
    newVendor.AddOrder(newOrder);
    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "Test Vendor";
      string vendor2 = "Test Vendor 2";
      string vendorDescription1 = "Test Description";
      string vendorDescription2 = "Test Description 2";
      Vendor newVendor1 = new Vendor(vendor1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendor2, vendorDescription2);

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

  }
}