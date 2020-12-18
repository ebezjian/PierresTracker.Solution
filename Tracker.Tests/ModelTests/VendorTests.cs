using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
[TestClass]

public class VendorTest: IDisposable
{
  public void Dispose()
  {
    Vendor.ClearAll();
  }
}