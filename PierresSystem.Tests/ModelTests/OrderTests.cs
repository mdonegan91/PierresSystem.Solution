using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresSystem.Models;
using System;

namespace PierresSystem.Tests
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
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Order> newOrder = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string orderName1 = "Prince1";
      string vendorName1 = "Prince Coffee";
      string orderName2 = "Cathedral1";
      string vendorName2 = "Cathedral Coffee";
      Order newOrder1 = new Order(orderName1, vendorName1);
      Order newOrder2 = new Order(orderName2, vendorName2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}