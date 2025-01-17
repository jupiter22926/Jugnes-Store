﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JugnesStore.Models;
using JugnesStore.Models.ViewModels;

namespace JugnesStore.Controllers
{
    public class UserController : Controller
    {
        JugnesModel db = new JugnesModel();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User u = db.Users.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                if (u != null)
                {
                    Session["user"] = u;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
    }
}