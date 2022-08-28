using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Login:");
            string login = Console.ReadLine();
            Console.WriteLine("Passowrd:");
            string password = Console.ReadLine();

            if (login == "adamoss")
            {
                if (password == "321")
                {
                    Console.Clear();
                    Console.WriteLine("Logged");
                }
                else
                {
                    Console.WriteLine("Incorrect password");
                    Console.WriteLine("Or can not find login ");
                }
            }
            else
            {
                Console.WriteLine("can not find");
            }

            Console.ReadKey();





        }
    }
}







//ctrl + k   ctrl + D
//tab+ tab po: //  cw  Console.WriteLine(); //  for for (int i = 0; i < length; i++) // while...
