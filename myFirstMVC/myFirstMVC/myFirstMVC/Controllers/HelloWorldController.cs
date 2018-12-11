using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myFirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index(string name, int? id)
        {
            string response = "Hello" + name + "!";
            if(id != null)
            {
                response += "; ID = " + id.ToString();
            }

            return response;            
            //return View();
        }
    }
}