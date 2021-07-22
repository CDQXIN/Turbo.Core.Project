using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ruanmou.Core.Interface;
using Ruanmou.Core.MVC6.Models;

namespace Ruanmou.Core.MVC6.Controllers
{
    public class HomeController : Controller
    {

        private ITestServiceA _testServiceA = null;
        private IEnumerable<ITestServiceD> _testServiceDs = null;
        
        public HomeController(ITestServiceA testServiceA, IEnumerable<ITestServiceD> testServiceDs)
        {
            _testServiceA = testServiceA;
            _testServiceDs = testServiceDs;
        }
        public IActionResult Index()
        { 
            _testServiceA.Show();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
