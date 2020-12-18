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
  public void VendorConstructor_CreatesInstanceOfVendor_Category()
  {
    Vendor newVendor = new Vendor("test vendor");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  }

  [TestMethod]
  public void GetName_ReturnsName_String()
  {
    //Arrange 
    string name = "Test Vendor";
    Vendor newVendor = new Vendor(name);

    //Act
    string result = newVendor.Name;

    //Assert
    Assert.AreEqual(name, result);
  }
}
}