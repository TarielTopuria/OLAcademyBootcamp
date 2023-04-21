using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAcademyBootcamp.Exercises
{
    class ExerciseTwo
    {
        public static string decimalToBinary()
        {
            Console.WriteLine("Enter a decimal number:");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryString = Convert.ToString(decimalNumber, 2);
            return $"Binary: {binaryString}";
        }
    }
}
