using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Orlando's Espresso";
      Vendor newVendor = new Vendor(name, "A coffee shop");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Orlando's Espresso";
      Vendor newVendor = new Vendor(name, "A coffee shop");
      string newName = "Ben's Bistro";
      newVendor.Name = newName;
      string result = newVendor.Name;
      Assert.AreEqual(newName, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string vendorDescription = "A coffee shop.";
      Vendor newVendor = new Vendor("Orlando's Espresso", vendorDescription);
      string result = newVendor.VendorDescription;
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void SetVendorDescription_SetVendorDescription_String()
    {
      string vendorDescription = "A coffee shop.";
      Vendor newVendor = new Vendor("Carlo's Bistro", vendorDescription);
      string newVendorDescription = "A family-owned bistro.";
      newVendor.VendorDescription = newVendorDescription;
      string result = newVendor.VendorDescription;
      Assert.AreEqual(newVendorDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Orlando's Espresso";
      string name02 = "Carlo's Bistro";
      string vendorDescription01 = "A coffee shop.";
      string vendorDescription02 = "A family-owned bistro.";
      Vendor newVendor01 = new Vendor(name01, vendorDescription01);
      Vendor newVendor02 = new Vendor(name02, vendorDescription02);
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Orlando's Espresso";
      string vendorDescription = "A coffee shop.";
      Vendor newVendor = new Vendor(name, vendorDescription);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Orlando's Espresso";
      string name02 = "Carlo's Bistro";
      string vendorDescription01 = "A coffee shop.";
      string vendorDescription02 = "A family-owned bistro.";
      Vendor newVendor01 = new Vendor(name01, vendorDescription01);
      Vendor newVendor02 = new Vendor(name02, vendorDescription02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor02, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderTitle = "Croissant Order";
      string orderDescription = "An order for 12 croissants.";
      int price = 25;
      string date = "10/10/2023";
      Order newOrder = new Order(orderTitle, orderDescription, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Orlando's Espresso";
      string vendorDescription = "A coffee shop.";
      Vendor newVendor = new Vendor(name, vendorDescription);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}