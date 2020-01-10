using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Template.Models;

namespace Template.Controllers
{
  public class HomeController : Controller
  {
      [Route("/template")]//First main user page;
      public ActionResult Template() { return View(); }

      [Route("/second")]//
      public ActionResult Second(string test1,string test2) 
      {
          Class newClass = new Class(test1, test2);
          //You can instantiate classes here to have them render on
         // your last page

           return View(newClass); }

  }
}