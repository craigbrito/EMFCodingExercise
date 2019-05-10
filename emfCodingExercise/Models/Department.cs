using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace emfCodingExercise.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}