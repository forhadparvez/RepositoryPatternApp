
using RPApp.CoreLibrary.Core.Entities;
using RPApp.CoreLibrary.Core.Repositorys;
using RPApp.InfrastuctureLibrary.DbContexts;
using System.Data.Entity;
using System.Linq;

namespace RPApp.InfrastuctureLibrary.Core.Repositorys
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(RpAppDbContext context)
            : base(context)
        {

        }

        public RpAppDbContext RpAppDbContext
        {
            get { return Context as RpAppDbContext; }
        }

        public Student GetStudentDepartment()
        {
            return RpAppDbContext.Students
                   .Include(c => c.Department)
                   .FirstOrDefault();
        }
    }
}
