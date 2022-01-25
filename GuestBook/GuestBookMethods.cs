using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class GuestBookMethods
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the Guest Book App!");
            Console.WriteLine("TM Mike Robards 2022");
            Console.WriteLine();
        }
        public static string AskUsersName()
        {
            Console.Write("What is the name of your party: ");
            string userName = Console.ReadLine();
            return userName;
        }


    }
}
