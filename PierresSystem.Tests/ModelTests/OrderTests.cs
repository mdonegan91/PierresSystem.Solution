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
      Order newOrder = new Order("Prince1", "Prince Coffee", "croissants", "five dollars", "march 2023");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsOrderName_String()
    {
      string orderName = "Prince1";
      Order newOrder = new Order(orderName, "Prince Coffee", "croissants", "five dollars", "march 2023");
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "Princ1";
      Order newOrder = new Order("Prince Coffee", orderName, "croissants", "five dollars", "march 2023");
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
      string orderName2 = "Cathedral1";
      Order newOrder1 = new Order(orderName1, "Prince Coffee", "croissants", "five dollars", "march 2023");
      Order newOrder2 = new Order(orderName2, "Cathedral Coffee", "scones", "four dollars", "february 2023");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string orderName = "Prince1";
      Order newOrder = new Order(orderName, "Prince Coffee", "croissants", "five dollars", "march 2023");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderName01 = "Prince1";
      string orderName02 = "Prince2";
      Order newOrder1 = new Order(orderName01, "Prince Coffee", "croissants", "five dollars", "march 2023");
      Order newOrder2 = new Order(orderName02, "Cathedral Coffee", "scones", "four dollars", "february 2023");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}