using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 10, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrder_ReturnsOrder_String()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "01-01-2011";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(price, newOrder.Price);
      Assert.AreEqual(date, newOrder.Date);
    }
  }
}