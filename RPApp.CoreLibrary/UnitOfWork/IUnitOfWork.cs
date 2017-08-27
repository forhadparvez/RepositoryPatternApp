using RPApp.CoreLibrary.Core.Repositorys;
using System;

namespace RPApp.CoreLibrary.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; set; }
        IDepartmentRepository Departments { get; set; }
        int Complete();
    }
}
