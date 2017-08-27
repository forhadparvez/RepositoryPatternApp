using RPApp.BusinessLogicLibrary;
using RPApp.CoreLibrary.Core.Entities;

namespace RPApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManager();

            var aStudent = new Student();
            aStudent.Name = "Parvez";
            aStudent.RegNo = "1235";
            aStudent.Department = new Department()
            {
                Name = "CSE"
            };

            bool isNameExist = studentManager.IsRegNoExist(aStudent.RegNo);
            if (isNameExist)
            {
                System.Console.WriteLine("This {0} RegNo Alredy Exist", aStudent.RegNo);
            }
            else
            {
                var successCount = studentManager.Add(aStudent);

                if (successCount > 0)
                {
                    System.Console.WriteLine("Save Success");
                }
                else
                {
                    System.Console.WriteLine("Save Fail");
                }
            }

            System.Console.ReadLine();
        }
    }
}
