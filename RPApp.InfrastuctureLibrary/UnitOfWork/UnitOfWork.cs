using RPApp.CoreLibrary.Core.Repositorys;
using RPApp.CoreLibrary.UnitOfWork;
using RPApp.InfrastuctureLibrary.Core.Repositorys;
using RPApp.InfrastuctureLibrary.DbContexts;

namespace RPApp.InfrastuctureLibrary.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RpAppDbContext _context;

        public UnitOfWork(RpAppDbContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);
            Departments = new DepartmentRepository(_context);
        }

        public IStudentRepository Students { get; set; }
        public IDepartmentRepository Departments { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
