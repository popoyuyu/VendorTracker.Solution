using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreateInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendor_ReturnsVendor_String()
    {
      string name = "test vendor";
      string vendorDescription = "test description";
      Vendor newVendor = new Vendor(name, vendorDescription);
      string result = newVendor.Name;
      string result1 = newVendor.VendorDescription;
      Assert.AreEqual(name, result);
      Assert.AreEqual(vendorDescription, result1);
    }
  }
}