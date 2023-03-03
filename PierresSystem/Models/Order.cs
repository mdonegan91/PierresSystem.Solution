using System.Collections.Generic;

namespace PierresSystem.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string VendorName { get; set; }

    public string Description { get; set; }

    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    public Order(string orderName, string vendorName, string description, string price, string date)
    {
      OrderName = orderName;
      VendorName = vendorName;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}