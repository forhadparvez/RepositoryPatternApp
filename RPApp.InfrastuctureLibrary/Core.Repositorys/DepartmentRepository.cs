using RPApp.CoreLibrary.Core.Entities;
using RPApp.CoreLibrary.Core.Repositorys;
using RPApp.InfrastuctureLibrary.DbContexts;
using System.Data.Entity;

namespace RPApp.InfrastuctureLibrary.Core.Repositorys
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DbContext context)
            : base(context)
        {
        }

        public RpAppDbContext RpAppDbContext
        {
            get { return Context as RpAppDbContext; }
        }
    }
}
