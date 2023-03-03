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
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}