using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string employeeId, string name, int age)
        {
            Id = employeeId;
            Name = name;
            Age = age;
        }
    }
}
