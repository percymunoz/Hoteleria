﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using HotelBahia.BussinesLogic.Servicios;
//using HotelBahia.DataAccess.Models;

namespace HotelBahia.Presentacion.Web.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}