using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAcademyBootcamp.Exercises
{
    class ExerciseThree
    {
        /// <summary>
        /// ფართობის გამომთვლელი ფორმულა
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static double multiplicationMethod(double length, double width)
        {
            return length * width;
        }

        /// <summary>
        /// მოცულობის გამომთვლელი ფორმულა
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double multiplicationMethod(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
