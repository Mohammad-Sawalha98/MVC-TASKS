using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Task_9.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public int coursePrice { get; set; }
        public int studentId { get; set; }
        [ForeignKey("studentId")]
        public Student Student { get; set; }
    }
}