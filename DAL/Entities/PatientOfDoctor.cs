﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class PatientOfDoctor
    {
        public int Id { get; set; }
        public DateTime DateAndTime { get; set; }
        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
        public int? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
        public int? TreatmentId { get; set; }
        [ForeignKey("TreatmentId")]
        public Treatment Treatment { get; set; }
    }
}
