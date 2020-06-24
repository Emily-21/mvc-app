using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_APP.Controllers
{
    public class HelloController : Controller
    {
        //// GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        // GET: /Hello/
        //public string Index() //our home for the controller..
        //{
        //    return "This is my go to page for the controller.";
        //}

        //GET: /Hello/Wassup
        public string Wassup() //'Sub-view' of our hello controller.
        {
            return "Wassssup";
        }

        //GET: /Hello/Demo
        public string Demo(string name, int ID) //'sub-view' of our hello controller
        {
            //return "Demo";
            //name = "Jacob";
            //ID = 1;
            return HtmlEncoder.Default.Encode($"Hello, {name}. Your ID number is {ID}");
        }
    }
}
