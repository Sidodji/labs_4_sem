using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lab_13.Model
{
    public partial class Lab13_Context : DbContext
    {
        public Lab13_Context()
            : base("name=Lab13_DB")
        {
        }

        public virtual DbSet<Ñourses> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
