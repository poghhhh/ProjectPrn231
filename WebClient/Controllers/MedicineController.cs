﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebClient.Controllers
{
    public class MedicineController : Controller
    {
        public IActionResult Index()
        {
            string active = "active";
            ViewBag.MedicineManage = active;
            string SessionFullname = HttpContext.Session.GetString("fullname");
            ViewData["fullname"] = SessionFullname;
            string SessionRole = HttpContext.Session.GetString("role");
            ViewData["role"] = SessionRole;
            if (!SessionRole.Equals("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
