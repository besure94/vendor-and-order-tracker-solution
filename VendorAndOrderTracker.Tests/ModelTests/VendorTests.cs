using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}