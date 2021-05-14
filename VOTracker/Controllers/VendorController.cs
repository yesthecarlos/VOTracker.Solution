using Microsoft.AspNetCore.Mvc;
using TrackerApp.Models;
using System.Collections.Generic;

namespace TrackerApp.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors=Vendor.GetAll();
      return View(allVendors);
    }
  }
}