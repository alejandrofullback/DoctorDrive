﻿using System.Web.Mvc;

namespace DoctorDrive.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}