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
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName01 = "test vendor 1";
      string description01 = "test description 1";
      string vendorName02 = "test vendor 2";
      string description02 = "test description 2";
      Vendor newVendor1 = new Vendor(vendorName01, description01);
      Vendor newVendor2 = new Vendor(vendorName02, description02);
      List<Vendor> vendorList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorList, result);
    }
  }
}