using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBookStore.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            //var obj = new { Id = 1, Name = "Nitish" };
            //return View("../../TempView/Nitish");
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
