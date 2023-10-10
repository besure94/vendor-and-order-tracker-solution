using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
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
  }
}