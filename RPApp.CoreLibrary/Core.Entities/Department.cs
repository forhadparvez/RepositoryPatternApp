using System.Collections.Generic;

namespace RPApp.CoreLibrary.Core.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}
