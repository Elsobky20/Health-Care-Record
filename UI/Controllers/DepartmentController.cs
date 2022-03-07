﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.DepartmentServices;
using DAL.Models;
using DAL.Entities;

namespace UI.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentService dps = new DepartmentService();
        public IActionResult Index()
        {
            //IEnumerable<DepartmentViewModel> depts = dps.GetAll();
            var depts = dps.GetAll();
            return View(depts);
        }

        public IActionResult Create()
        {
             
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentViewModel dpt)
        {
            try
            {
                dps.Add(dpt);
                return RedirectToAction("Index", "Department");
            }
            catch (Exception)
            {

                return View(dpt);
            }
        }
    }
}
