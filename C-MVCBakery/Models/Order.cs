using Microsoft.AspNetCore.Mvc;

namespace PierresBakery.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, double price, string date)
    {
        Title = title;
        Description = description;
        Price = price;
        Date = date;
        Id = _instances.Count;
        _instances.Add(this);
    }
    //Here we have the constructors that will be passed into our route then to our main page
  }
}