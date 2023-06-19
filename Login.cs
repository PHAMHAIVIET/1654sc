using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV0
{
    internal class Login
    {
        private string username;
        private string password;

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public virtual bool Authenticate()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("            Welcome to Login             ");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.WriteLine("Please enter your username:");
            string inputUsername = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string inputPassword = Console.ReadLine();

            Console.WriteLine();

            if (inputUsername == username && inputPassword == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login successful!");
                Console.ResetColor();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login failed. Invalid credentials.");
                Console.ResetColor();
                return false;
            }
        }
    }
}
