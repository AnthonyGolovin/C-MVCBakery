using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> listedVendors = Vendor.GetAll();
      return View(listedVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendor, string description)
    {
      Vendor myVendor = new Vendor(vendor, description);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrder = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrder);
      return View(model);
    }
    
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, int price, string date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor findVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, price, date);
      findVendor.AddingOrder(newOrder);
      List<Order> vendorOrders = findVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", findVendor);
      return View("Show", model);
    }
  }
}