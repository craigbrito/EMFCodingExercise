using Microsoft.EntityFrameworkCore;
using emfCodingExercise.Models;

namespace emfCodingExercise.Data
{
    public class EmfCodingExerciseContext : DbContext
    {
        public EmfCodingExerciseContext(DbContextOptions<EmfCodingExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<emfCodingExercise.Models.Department> Department { get; set; }
        public DbSet<emfCodingExercise.Models.Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
