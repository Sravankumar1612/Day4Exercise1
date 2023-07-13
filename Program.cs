using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int preMarks;
            Console.Write("Enter marks in Pre: ");
            preMarks = int.Parse(Console.ReadLine());

            if (preMarks > 60)
            {
                Console.Write("Enter marks in Final: ");
                int finalMarks = int.Parse(Console.ReadLine());

                if (finalMarks > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }

            Console.ReadLine();
        }
    }
}
