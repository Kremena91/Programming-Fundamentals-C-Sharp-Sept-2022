﻿using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int course = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(course);
        }
    }
}