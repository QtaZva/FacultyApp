using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FacultyApp.Classes
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Faculties> Faculties { get; set; }
        public DbSet<DeductionList> DeductionList { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }
    }
}
