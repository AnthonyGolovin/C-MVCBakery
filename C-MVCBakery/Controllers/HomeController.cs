using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
      { 
        return View(); 
      }
  }
}