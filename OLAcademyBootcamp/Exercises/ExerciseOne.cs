using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAcademyBootcamp.Exercises
{
    class ExerciseOne
    {
        private readonly string userName;
        private readonly string password;

        public ExerciseOne(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string credentialsChecker()
        {
            int attempts = 0;
            while (attempts < 5)
            {
                Console.WriteLine("Enter username:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string pass = Console.ReadLine();

                if (this.userName.Equals(name) && this.password.Equals(pass))
                {
                    return "Success";
                }
                attempts++;
            }
            return "Error";
        }
    }
}
