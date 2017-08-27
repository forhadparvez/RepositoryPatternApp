using RPApp.CoreLibrary.Core.Entities;
using System.Data.Entity;

namespace RPApp.InfrastuctureLibrary.DbContexts
{
    public class RpAppDbContext : DbContext
    {
        public RpAppDbContext()
            : base("name=RpAppDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }
}
