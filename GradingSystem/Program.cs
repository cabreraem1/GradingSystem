using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;

            Console.WriteLine("Please enter the student's Grade");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade >=90)
            {
                Console.WriteLine("Your grade is an A!");
            }
            else if (grade < 90 && grade >= 80)
            {
                Console.WriteLine("Your grade is a B!");
            }
            else if (grade < 80 && grade >= 70)
            {
                Console.WriteLine("Your grade is a C!");
            }
            else if (grade < 70 && grade >= 60)
            {
                Console.WriteLine("Your grade is a D!");
            }
            else
            {
                Console.WriteLine("Your grade is an F");
            }
            Console.ReadLine();
        }
    }
}
