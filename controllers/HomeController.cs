using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Index")]
        public String Index()
        {
            return "Hello From Home";
        }

        [Route("AboutUs")]
        public String About()
        {
            return "Hello from About";
        }
    }
}
