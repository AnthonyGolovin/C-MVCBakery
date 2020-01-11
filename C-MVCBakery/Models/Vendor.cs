using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    public string VendorTitle { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> Orders { get; set; }

    public Vendor(string vendorTitle, string description)
    {
        VendorTitle = vendorTitle;
        Description = description;
        Id = _instances.Count;
        _instances.Add(this);
        Orders = new List<Order> {};
    }
     public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId];
    }
    public void AddingOrder(Order order)
    {
        Orders.Add(order);
    }
  }
}