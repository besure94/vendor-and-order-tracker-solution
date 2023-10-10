using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test description", 25, 10/10/2023);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Croissant Order";
      Order newOrder = new Order(title, "An order of 12 blueberry croissants.", 25, 10/10/2023);
      string result = newOrder.OrderTitle;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Croissant Order";
      Order newOrder = new Order(title, "An order of 12 blueberry croissants.", 25, 10/10/2023);
      string newTitle = "Bread Order";
      newOrder.OrderTitle = newTitle;
      string result = newOrder.OrderTitle;
      Assert.AreEqual(newTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "An order of 12 blueberry croissants.";
      Order newOrder = new Order("Croissant Order", description, 25, 10/10/2023);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "An order of 12 blueberry croissants.";
      Order newOrder = new Order("Croissant Order", description, 25, 10/10/2023);
      string newDescription = "An order of 6 plain croissants.";
      newOrder.OrderDescription = newDescription;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(newDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 25;
      Order newOrder = new Order("Croissant Order", "An order of 12 blueberry croissants", price, 10/10/2023);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      int price = 25;
      Order newOrder = new Order("Croissant Order", "An order of 12 blueberry croissants", price, 10/10/2023);
      int newPrice = 30;
      newOrder.Price = newPrice;
      int result = newOrder.Price;
      Assert.AreEqual(newPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_Int()
    {
      int date = 10/10/2023;
      Order newOrder = new Order("Croissant Order", "An order of 12 blueberry croissants", 25, date);
      int result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_Int()
    {
      int date = 10/10/2023;
      Order newOrder = new Order("Croissant Order", "An order of 12 blueberry croissants", 25, date);
      int newDate = 11/11/2023;
      newOrder.Date = newDate;
      int result = newOrder.Date;
      Assert.AreEqual(newDate, result);
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
      string orderTitle01 = "Croissant Order";
      string orderTitle02 = "Bread Order";
      string orderDescription01 = "Order of 12 croissants.";
      string orderDescription02 = "Order of 5 loaves of bread.";
      int price01 = 25;
      int price02 = 15;
      int date01 = 10/10/2023;
      int date02 = 11/11/2023;
      Order newOrder01 = new Order(orderTitle01, orderDescription01, price01, date01);
      Order newOrder02 = new Order(orderTitle02, orderDescription02, price02, date02);
      List<Order> newList = new List<Order> { newOrder01, newOrder02 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_RecordsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string orderTitle = "Croissant Order";
      string orderDescription = "Order of 12 croissants.";
      int price = 25;
      int date = 10/10/2023;
      Order newOrder = new Order(orderTitle, orderDescription, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle01 = "Croissant Order";
      string orderTitle02 = "Bread Order";
      string orderDescription01 = "Order of 12 croissants.";
      string orderDescription02 = "Order of 5 loaves of bread.";
      int price01 = 25;
      int price02 = 15;
      int date01 = 10/10/2023;
      int date02 = 11/11/2023;
      Order newOrder01 = new Order(orderTitle01, orderDescription01, price01, date01);
      Order newOrder02 = new Order(orderTitle02, orderDescription02, price02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder02, result);
    }
  }
}