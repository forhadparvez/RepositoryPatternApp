﻿
namespace RPApp.CoreLibrary.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
