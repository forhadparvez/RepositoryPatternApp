using RPApp.CoreLibrary.Core.Entities;
using RPApp.DataAccess.Library;
using System.Collections.Generic;

namespace RPApp.BusinessLogicLibrary
{
    public class StudentManager
    {
        private readonly StudentGetway _studentGetway = new StudentGetway();

        public bool IsRegNoExist(string regNo)
        {
            bool isRegNoExist = false;
            var aStudent = GetSingleStudent(regNo);
            if (aStudent != null)
            {
                isRegNoExist = true;
            }
            return isRegNoExist;
        }

        public Student Get(int id)
        {
            return _studentGetway.Get(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentGetway.GetAll();
        }

        public IEnumerable<Student> FindByName(string name)
        {
            return _studentGetway.FindByName(name);
        }

        public Student GetSingleStudent(string regNo)
        {
            return _studentGetway.GetSingleStudent(regNo);
        }

        public int Add(Student aStudent)
        {
            return _studentGetway.Add(aStudent);
        }

        public int AddRange(IEnumerable<Student> students)
        {
            return _studentGetway.AddRange(students);
        }

    }
}
