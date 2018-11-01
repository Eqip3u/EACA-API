﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EACA_API.Models.Institute;

namespace EACA_API.Models.Account
{
    public class Student
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string Gradebook { get; set; }
        public bool? Headman { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public string IdentityId { get; set; }
        public ApiUser Identity { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
