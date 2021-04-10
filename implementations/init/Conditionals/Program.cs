﻿using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 20;

            if(hour > 0 && hour < 12) {
                Console.WriteLine("It's morning.");
            }
            else if(hour >= 12 && hour < 18) {
                Console.WriteLine("It's afternoon.");
            }
            else {
                Console.WriteLine("It's evening.");
            }
        }
    }
}
