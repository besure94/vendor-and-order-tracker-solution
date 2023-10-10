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
      Order newOrder = new Order("test", "test description", 25);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Croissant Order";
      Order newOrder = new Order(title, "An order of 12 blueberry croissants.", 25);
      string result = newOrder.OrderTitle;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Croissant Order";
      Order newOrder = new Order(title, "An order of 12 blueberry croissants.", 25);
      string newTitle = "Bread Order";
      newOrder.OrderTitle = newTitle;
      string result = newOrder.OrderTitle;
      Assert.AreEqual(newTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "An order of 12 blueberry croissants.";
      Order newOrder = new Order("Croissant Order", description, 25);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "An order of 12 blueberry croissants.";
      Order newOrder = new Order("Croissant Order", description, 25);
      string newDescription = "An order of 6 plain croissants.";
      newOrder.OrderDescription = newDescription;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(newDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 25;
      Order newOrder = new Order("Croissant Order", "An order of 12 blueberry croissants", price);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
  }
}