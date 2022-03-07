﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DoctorViewModel
    {
        [Key]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Enter doctor name")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Enter doctor ssn")]
        //[StringLength(14, ErrorMessage = "Length must be 14")]
        public long SSN { get; set; }

        //[Required(ErrorMessage = "Phone Is Required")]
        public string Phone { get; set; }

        //[Required(ErrorMessage = "Gender Is Required")]
        public string Gender { get; set; }

        //[Required(ErrorMessage = "Enter Your BirthDate")]
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string Degree { get; set; }
        //[Required(ErrorMessage = "Enter Your Date of WorkStarts")]
        public DateTime? WorkStartTime { get; set; }

        public int DepartmentId { get; set; }
        public IFormFile PhotoUrl { get; set; }
        public string Photo { get; set; }

    }
}
