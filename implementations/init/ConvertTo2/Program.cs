using System;

namespace ConvertTo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            string str = "3456";
            result = Convert.ToInt32(str);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
