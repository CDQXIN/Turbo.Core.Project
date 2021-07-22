using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ruanmou.Core.Utility.Filters;

namespace Ruanmou.Core.MVC6.Controllers
{
    public class TestResourceController : Controller
    {

        [CustomResourceFilter]
        public IActionResult Index()
        { 
            base.ViewBag.now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return View();
        }
    }
}