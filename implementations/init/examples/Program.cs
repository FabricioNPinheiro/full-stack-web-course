using System;

namespace examples
{
    class Program {
        public class Person {
            public DateTime _birthdate;

            // FORMA 1
            public void SetBirthdate(DateTime birthdate) {
                this._birthdate = birthdate;
            }
            public DateTime GetBirthdate() {
                return _birthdate;
            }

            // FORMA 2
             public DateTime Birthdate {
                get { return _birthdate; }
                set { _birthdate = value; }
            } 

            // FORMA 3
            // public DateTime Birthdate { get; set; }
        }
        static void Main(string[] args) {
            var person = new Person();
            person.Birthdate = new DateTime(1998, 10, 18);
            Console.WriteLine(person._birthdate);
        }
    }
}