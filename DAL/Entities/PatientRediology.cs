﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class PatientRediology
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Photo { get; set; }
        public bool State { get; set; }
        public DateTime DateAndTime { get; set; }
        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
        public int? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
        public int? RadiologyId { get; set; }
        [ForeignKey("RadiologyId")]
        public Radiology Radiology { get; set; }
    }
}
