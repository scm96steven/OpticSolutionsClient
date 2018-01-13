using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpticSolutionsClient.Repositories.Entitys
{
    public class Appointment
    {
        public int Id { get; set; }
        public string DoctorUsername { get; set; }
        public string DoctorFullname { get; set; }

        public int Status { get; set; }

        [Required(ErrorMessage = "El campo nombres es requerido")]
        public string Names { get; set; }

        [Required(ErrorMessage = "El campo apellidos es requerido")]
        public string Last_Names { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo telefono es requerido")]
        public string Phone { get; set; }


        public string IdentificationCard { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "El campo hora es requerido")]
        public string StartHourStr { get; set; }

        [Required(ErrorMessage = "El campo fecha es requerido")]
        [DisplayFormat(DataFormatString = "{0:yyyy-dd-mm}", ApplyFormatInEditMode = true)]
        public string StartDateStr { get; set; }
        public string EndDateStr { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int StartHour { get; set; }
        public int StartMinute { get; set; }

        public int EndHour { get; set; }
        public int EndMinute { get; set; }




        public int NumberOfAppointments { get; set; }
    }
}
