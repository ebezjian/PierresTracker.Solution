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

  }
}