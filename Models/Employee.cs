using System;
using System.ComponentModel.DataAnnotations;

namespace emfCodingExercise.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string NickName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PhysicalAddress { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
