using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myFirstMVC.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public string Concatenare(string param1, string param2)
        {
            //return param1 + " " + param2;
            string result = param1 + " " + param2;
            return result;
        }
    }
}