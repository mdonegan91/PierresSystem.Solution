using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresSystem.Models;
using System.Collections.Generic;
using System;

namespace PierresSystem.Tests
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
      Vendor newVendor = new Vendor("Prince Coffee");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "Prince Coffee";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetID_ReturnsVendorID_Int()
    {
      string name = "Prince Coffee";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Prince Coffee";
      string name02 = "Cathedral Coffee";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Prince Coffee";
      string name02 = "Cathedral Coffee";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string desciprtion = "Croissants";
      Order newOrder = new Order(desciprtion, "Prince Coffee", "croissants", "five dollars,", "today");
      List<Order> newList = new List<Order> { newOrder };
      string vendor = "Prince Coffee";
      Vendor newVendor = new Vendor(vendor);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}