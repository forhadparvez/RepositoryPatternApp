using RPApp.CoreLibrary.Core.Entities;

namespace RPApp.CoreLibrary.Core.Repositorys
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetStudentDepartment();
    }
}
