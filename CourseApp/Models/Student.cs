using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Student
    {
        //zorunlu alan. Validation controllers
       [Required (ErrorMessage ="Ad boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad boş geçilemez")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Mail boş geçilemez")]
        [EmailAddress(ErrorMessage ="Mail adresinizi düzgün giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bir seçenek seçiniz")]
        public bool? Confirm { get; set; }

    }
}
