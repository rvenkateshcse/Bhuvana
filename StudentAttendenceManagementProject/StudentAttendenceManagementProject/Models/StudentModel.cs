﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAttendenceManagementProject.Models
{
    public  class StudentModel
    {
        public string StudentName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int AttendedDays { get; set; }


    }
}