using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NewAmsterdamHospital.ViewModels
{
    public class AppointmentView
    {
        [Required(ErrorMessage = "Select Doctor")]
        public int IdDoctorSpecialty { get; set; }
        [Required(ErrorMessage = "Select Date")]
        public int DateId { get; set; }
        [Required(ErrorMessage = "Select Time")]
        public int TimeId { get; set; }
    }
}