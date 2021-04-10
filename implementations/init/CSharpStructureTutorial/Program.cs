using System;

namespace CSharpStructureTutorial
{
    struct Employee {
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

            Employee one = new Employee("10", "messi", "2");
            Console.WriteLine(one.empNumber);
            Console.WriteLine(one.empName);
            Console.WriteLine(one.position);
            
            Employee two = one;
            two.empNumber = "7";
            two.empName = "Cristiano";
            two.position = "3";
            Console.WriteLine(two.empNumber);
            Console.WriteLine(two.empName);
            Console.WriteLine(two.position);

        }
    }

}