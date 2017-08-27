using RPApp.BusinessLogicLibrary;
using RPApp.CoreLibrary.Core.Entities;

namespace RPApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            string name, regNo;

            var studentManager = new StudentManager();
            System.Console.WriteLine("Enter Studet Name and Reg No:\n");
            // get input from console
            System.Console.Write("Name: ");
            name = System.Console.ReadLine();
            System.Console.Write("Reg No: ");
            regNo = System.Console.ReadLine();

            bool isNameExist = studentManager.IsRegNoExist(regNo);
            if (isNameExist)
            {
                System.Console.WriteLine("\nThis {0} RegNo Alredy Exist", regNo);
            }
            else
            {
                var aStudent = new Student();
                aStudent.Name = name;
                aStudent.RegNo = regNo;
                aStudent.DepartmentId = 1;
                //aStudent.Department = new Department()
                //{
                //    Name = "CSE"
                //};
                var successCount = studentManager.Add(aStudent);

                if (successCount > 0)
                {
                    System.Console.WriteLine("\nSave Success");
                }
                else
                {
                    System.Console.WriteLine("\nSave Fail");
                }
            }

            System.Console.ReadLine();
        }
    }
}
