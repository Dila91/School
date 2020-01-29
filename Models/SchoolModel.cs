using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace School.Models
{
    public class Student

    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
    }
    public class Teacher
    {
        [Key]
        public int TeatcherId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public List<Course> Courses { get; set; }
    }
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
   
}