using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TrackerApp.Models;
using System;

namespace TrackerApp.Tests
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
      Vendor newVendor = new Vendor("test", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_string()
    {
      string name = "Major's";
      string description = "burger place";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
      public void SetDescription_SetDescription_String()
      {
        string name = "Major's";
        string description = "burger place";
        Vendor newVendor = new Vendor(name, description);

        string updatedDescription = "#1 Burger Place in town";
        newVendor.Description = updatedDescription;
        string result = newVendor.Description;

        Assert.AreEqual(updatedDescription, result);
      }
  }
}