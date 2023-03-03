using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresSystem.Models;
using System;

namespace PierresSystem.Tests
{
  [TestClass]
  public class OrderTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Prince1", "Prince Coffee");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsOrderName_String()
    {
      string orderName = "Prince1";
      Order newOrder = new Order(orderName, "Prince Coffee");
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetsOrderName_String()
    {
      string orderName = "Princ1";
      Order newOrder = new Order(orderName, "Prince Coffee");

      string updatedOrderName = "Prince1";
      newOrder.OrderName = updatedOrderName;
      string result = newOrder.OrderName;

      Assert.AreEqual(updatedOrderName, result);
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Prince Coffee";
      Order newOrder = new Order("Prince1", vendorName);
      string result = newOrder.VendorName;

      Assert.AreEqual(vendorName, result);
    }
  }
}