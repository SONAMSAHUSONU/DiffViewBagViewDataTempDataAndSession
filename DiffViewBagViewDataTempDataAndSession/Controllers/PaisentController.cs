using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiffViewBagViewDataTempDataAndSession.Controllers
{
    public class PaisentController : Controller
    {
        // GET: Paisent
        public ActionResult Index()
        {
            ViewData["Fname"] = "Sonam";//view data object given key n value name
            ViewBag.Lname = "Sahu";
             //it is dynamic property type so that u will pass some value that will work like the property
            return View();
        }
        //TempSession
        public ActionResult TempSession()
        {
            ViewData["Fname"] = "Sonam";
            ViewBag.Lname = "Sahu";
            TempData["CompleteName"] = "Sonam Sahu";//when we pass the value to one controller method to another controller action method the you have to use tempdata and session 
            Session["Address"] = "Vidisha";
            return RedirectToAction("Message");//here i am return some value to redirect page
        }
        public ActionResult Message()
        {
            TempData.Keep();
            return View();//this view i retrive all the value in message
        }
    }
}