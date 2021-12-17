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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "title";
      string description01 = "description";
      int price01 = 10;
      string date01 = "01-01-2011";
      string title02 = "title1";
      string description02 = "description1";
      int price02 = 11;
      string date02 = "01-01-2012";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title01 = "title";
      string description01 = "description";
      int price01 = 10;
      string date01 = "01-01-2011";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      int result = newOrder1.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "title";
      string description01 = "description";
      int price01 = 10;
      string date01 = "01-01-2011";
      string title02 = "title1";
      string description02 = "description1";
      int price02 = 11;
      string date02 = "01-01-2012";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      Order result = Order.Find(1);
      Assert.AreEqual(newOrder1, result);
    }
  }
}