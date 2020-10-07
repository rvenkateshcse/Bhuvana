using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentsAttendenceManagementProj.Models
{
    public class StudentClass
    {
        [Required(ErrorMessage ="Please Enter Name")]
        [Display(Name = "UserName")]
         public string UserName { get; set; }
      
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
       
        [Required(ErrorMessage = "Please Enter Role")]
        [Display(Name = "Role")]
        public string Role { get; set; }

    }
}