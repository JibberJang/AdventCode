using AdventCode.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventCode
{
    public class Program
    {

        static void Main(string[] args)
        {
            var theExecutioner = new Executioner();
            Console.WriteLine("Welcome to the Advent of Code! =)");
            Console.WriteLine("Which day do you want the solution for:");
            theExecutioner.ExecuteOrder66(Console.ReadLine());
        }
    }
    public class Executioner
    {
        public void ExecuteOrder66(string input)
        {
            switch (input)
            {
                case "1":
                    new One().GetSolution();
                    break;
                case "2":
                    new Two().GetSolution();
                    break;
                default:
                    Console.WriteLine("Solution for this day doesn't exist. Make sure to use numbers instead of words");
                    break;
            }
        }
    }
}
