//using Microsoft.AspNetCore.Mvc;
//using smtpEmail.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
////using System.Web.Mvc;
//using smtpEmail.Models;


using Microsoft.AspNetCore.Mvc;
using smtpEmail.Models;
using Microsoft.AspNetCore.Http;

namespace smtpEmail.Controllers
{
    public class LoginController : Controller
    {
        private readonly proContext _context;

        public LoginController(proContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Welcome()
        {
            if (HttpContext.Session.GetString("userseesion") != null)
            {
                ViewBag.session = HttpContext.Session.GetString("userseesion");
            }

            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("userseesion") != null)
            {
                return RedirectToAction("Welcome");
            }

            return View();
        }


        [HttpPost]
        public IActionResult Login(Register model)
        {
            var myuser = _context.Registers.Where(x => x.Remail == model.Remail && x.Rpass == model.Rpass).FirstOrDefault();
            if (myuser != null)
            {
                HttpContext.Session.SetString("userseesion", myuser.Runame);
                return RedirectToAction("Welcome");

            }
            else
            {
                ViewBag.message = "login failed";
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("userseesion") != null)
            {

                HttpContext.Session.Remove("userseesion");
                return RedirectToAction("Login");
            }

            return View();
        }


        //    [HttpGet]
        //    public IActionResult Welcome()
        //    {
        //        if (HttpContext.Session.GetString("usersession") != null)
        //        {
        //            ViewBag.session = HttpContext.Session.GetString("usersession");
        //        }
        //        else
        //        {
        //            return RedirectToAction("Login");
        //        }
        //        return View();
        //    }


        //    [HttpGet]
        //    public IActionResult Login()
        //    {
        //        if (HttpContext.Session.GetString("usersession") != null)
        //        {
        //            return RedirectToAction("Welcome");
        //        }
        //        return View();
        //    }

        //    [HttpPost]
        //    public IActionResult Login(Register model)
        //    {
        //        var myuser = _context.Registers.Where(u => u.Runame == model.Runame && u.Rpass == model.Rpass).FirstOrDefault();

        //        if (myuser != null )
        //        {

        //            HttpContext.Session.SetString("usersession", myuser.Runame);

        //            return RedirectToAction("Welcome"); 
        //        }
        //        else
        //        {
        //            ViewBag.error = "Invalid Account";

        //        }
        //        return View();
        //    }


        //    public ActionResult Logout()
        //    {
        //        if (HttpContext.Session.GetString("usersession")!=null)
        //        {
        //            HttpContext.Session.Remove("usersession");
        //            return RedirectToAction("Login");
        //        }
        //        return View();
        //    }
    }
}

