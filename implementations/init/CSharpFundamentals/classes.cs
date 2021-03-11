using System;

namespace CSharpFundamentals {

    public class Person {
        public string FirstName;
        public string LastName;

        public void Introduce() {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    public class Veiculo{
        public string NameVeic;
        public string AnoVeic;

        public void Testando(){
            Console.WriteLine("My Car is " + NameVeic + " " + AnoVeic);
        }
    }
    /*
    class Program { 
        static void Main(string[] args) {
            var John = new Person();
            John.FirstName = "John";
            John.LastName = "Prince";
            John.Introduce();
            
        }
    }
    */
}
