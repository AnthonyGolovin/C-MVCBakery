using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class VendorsController : Controller
  {
    [Route("/")]
    public ActionResult Index()
      { 
        return View(); 
      }
  }
}