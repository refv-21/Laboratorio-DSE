﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPersona.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string nombre, int numVeces = 1)
        {
            ViewBag.Mensaje = "Hola " + nombre;
            ViewBag.NumVeces = numVeces;
            return View();
        }
    }
}