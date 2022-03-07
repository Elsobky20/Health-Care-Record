using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using BLL.Helper;
using DAL.Database;
using DAL.Entities;

namespace BLL.Services.ReservationServices
{
    public class ReservationServices : IReservationServices
    {
        private readonly AplicationDbContext context = new AplicationDbContext();
        public bool Add(DailyDetectionViewModel detec)
        {

             
                DailyDetection obj = new DailyDetection();
                //obj.DoctorId = detec.DoctorId;
                obj.DateAndTime = detec.DateAndTime;
                //obj.PatientId = detec.PatientId;
                obj.DepartmentId = detec.DepartmentId;
                context.DailyDetection.Add(obj);
                context.SaveChanges();
                return true;

        }
    }
}
