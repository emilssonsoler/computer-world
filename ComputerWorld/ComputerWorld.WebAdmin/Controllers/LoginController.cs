using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerWorld.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        //Post: Login
        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            return RedirectToAction("Index", "Home");
        }

    }
}