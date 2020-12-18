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
    Assert.AreEqual(typeof(int), newVendor.GetType());
  }
}
}