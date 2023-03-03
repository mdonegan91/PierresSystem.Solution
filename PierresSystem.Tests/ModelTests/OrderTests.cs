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
    public void SetDescription_SetDescription_String()
    {
      string description = "croissant";
      Order newOrder = new Order(description, "Prince Coffee", "Prince1", "five dollars", "march 2023");
      string updatedDescription = "croissants";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
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
      //Arrange
      string description = "croissants";
      Order newOrder = new Order(description, "Prince Coffee", "Prince1", "five dollars", "march 2023");
      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}