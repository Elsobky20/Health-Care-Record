using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DAL.Models;
using BLL.Services.ReservationServices;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using BLL.Services;

namespace UI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IDoctorService Doctor;

        private readonly IReservationServices Reserve;
        public BookingController(IReservationServices Reserve , IDoctorService Doctor)
        {

            this.Reserve = Reserve;
            this.Doctor = Doctor;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DailyDetectionViewModel Detect)
        {
            var Data = Reserve.Add(Detect);
            return RedirectToAction("Index");
        }

        //------------------ajax----------------------------------------------
        [HttpPost]
        public JsonResult GetDoctorByDepartmentID(int DeptId)
        {
            var data = Doctor.GetAll().Where(x => x.DepartmentId == DeptId);
            return Json(data);
        }
    }
}
