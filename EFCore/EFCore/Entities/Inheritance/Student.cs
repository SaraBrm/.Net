using System;

namespace Entities.Inheritance
{

    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Student:Person
    {
        public DateTime EnrollmentDate { get; set; }
    }

    public class Teacher:Person
    {
        public DateTime HireDate { get; set;}
    }
}
