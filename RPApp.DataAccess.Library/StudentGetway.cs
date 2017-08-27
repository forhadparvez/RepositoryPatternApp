using RPApp.CoreLibrary.Core.Entities;
using RPApp.InfrastuctureLibrary.DbContexts;
using RPApp.InfrastuctureLibrary.UnitOfWork;
using System.Collections.Generic;

namespace RPApp.DataAccess.Library
{
    public class StudentGetway
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork(new RpAppDbContext());

        public Student Get(int id)
        {
            var aStudent = _unitOfWork.Students.Get(id);
            return aStudent;
        }

        public IEnumerable<Student> GetAll()
        {
            var students = _unitOfWork.Students.GetAll();
            return students;
        }

        public IEnumerable<Student> FindByName(string name)
        {
            var students = _unitOfWork.Students.Find(student => student.Name == name);
            return students;
        }

        public Student GetSingleStudent(string regNo)
        {
            var aStudent = _unitOfWork.Students.SingleOrDefault(student => student.RegNo == regNo);
            return aStudent;
        }

        public int Add(Student aStudent)
        {
            _unitOfWork.Students.Add(aStudent);
            return _unitOfWork.Complete();
        }

        public int AddRange(IEnumerable<Student> students)
        {
            _unitOfWork.Students.AddRange(students);
            return _unitOfWork.Complete();
        }

        public int Remove(Student aStudent)
        {
            _unitOfWork.Students.Remove(aStudent);
            return _unitOfWork.Complete();
        }

        public int RemoveRange(IEnumerable<Student> students)
        {
            _unitOfWork.Students.RemoveRange(students);
            return _unitOfWork.Complete();
        }
    }
}
