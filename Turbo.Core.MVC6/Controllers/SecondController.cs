using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ruanmou.Core.MVC6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ruanmou.Core.Interface;
using Ruanmou.Core.MVC6.Utility;
using Ruanmou.Core.Utility.Filters;

namespace Ruanmou.Core.MVC6.Controllers
{

    /// <summary>
    /// log4Net 在控制器中写日志 
    /// core 内置了容器
    /// </summary>
    public class SecondController : Controller
    {
        private ILoggerFactory _factory = null;
        private ILogger<SecondController> _ilogger = null;

        private ITestServiceA _testServiceA = null;
        private ITestServiceB _testServiceB = null;
        private ITestServiceC _testServiceC = null;
        private IEnumerable<ITestServiceD> _testServiceDs = null;
        private IA _a = null;

        public SecondController(ILoggerFactory factory, ILogger<SecondController> ilogger,
          ITestServiceA testServiceA,
          ITestServiceB testServiceB,
          ITestServiceC testServiceC,
          IEnumerable<ITestServiceD> testServiceDs,
          IA a)
        {
            _factory = factory;
            _ilogger = ilogger;
            _testServiceA = testServiceA;
            _testServiceB = testServiceB;
            _testServiceC = testServiceC;
            _testServiceDs = testServiceDs;
            _a = a;
        }


        //[CustomExceptionFilterAttribute()]
        public IActionResult Index()
        {


            foreach (var serviceD in _testServiceDs)
            {
                serviceD.Show();
            }


            _a.Show();

            _testServiceA.Show(); 
            var ifactorylogger = _factory.CreateLogger<SecondController>();
            ifactorylogger.LogDebug("this is ILoggerFactory logger");

            _ilogger.LogDebug("this is ILogger<SecondController> debugger ");
            return View();
        }


    }
}