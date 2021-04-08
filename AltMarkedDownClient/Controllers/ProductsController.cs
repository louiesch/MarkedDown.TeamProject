using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AltMarkedDownClient.Models;

namespace AltMarkedDownClient.Controllers
{
  public class ProductsController : Controller
  {
    public IActionResult Index()
    {
      var allProducts = Product.GetProducts();
      return View(allProducts);
    }

  }
}