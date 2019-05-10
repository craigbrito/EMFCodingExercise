using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using emfCodingExercise.Models;

namespace emfCodingExercise.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmfCodingExerciseContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
