using System;

namespace CSharpStructureTutorial
{
    public struct Employee {
        public string empNumber;
        public string empName;
        public string position;

        public Employee(string empNumber, string empName, string position) {
            this.empNumber = empNumber;
            this.empName = empName;
            this.position = position;
        }

        /*
        public Employee(string empNumber, string empName) {
            this.empNumber = empNumber;
            this.empName = empName;
        }
        */

    }
    class Program { 
        static void Main(string[] args) {
            Employee one = new Employee("7", "fabs", "1");
            Console.WriteLine(one.empNumber);
            Console.WriteLine(one.empName);
            Console.WriteLine(one.position);
            Employee two = one;
            two.empNumber = "9";
            Console.WriteLine(two.empName);

        }
    }
}
