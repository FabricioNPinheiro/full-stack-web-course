using System;

namespace ConvertTo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 result;
            string str = "3456";
            result = Convert.ToInt32(str);
            Console.WriteLine(result);
            Console.ReadLine();

            string res; 
            Single temp = 3.5f;
            res = Convert.ToString(temp);
            Console.WriteLine(res);
            Console.ReadLine();
            
            int num = 4;
            int numb = 4;
            Console.WriteLine(num + numb);
            Console.WriteLine(num - numb);
            Console.WriteLine(num * numb);
            Console.WriteLine(num / numb);
            Console.WriteLine(num % numb);
        }
    }
}
