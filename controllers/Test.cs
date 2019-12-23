using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.controllers
{
    //[Controller]
    public class Test: Controller
    {
        public ActionResult Index()
        {
            return Content("Hello From Test index");
        }

        public String About()
        {
            return "Hello from Test About";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
