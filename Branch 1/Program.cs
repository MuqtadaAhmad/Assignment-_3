using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_1
{
    internal class Program
    {
        static void Main(string[] args)
        {ArrayList account = new ArrayList();
            Account acc1 = new Account("muqtada", "009848");

            account.Add(acc1);
            Account acc2 = new Account(acc1);
            account.Add(acc2);
            Console.WriteLine("your username ?");
            string user = Console.ReadLine();
            Console.WriteLine("your password ?");
            string password = Console.ReadLine();
            for (int i = 0; i < account.Count; i++)
            {
                Account acc = (Account)account[i];
                if (acc.userName == user && acc.password == password)
                {
                    Console.WriteLine("yor email is correct ");
                    Console.WriteLine($"the user name is {user} and your password is\n {password}");
                    break;
                }
                else if (acc.userName == user && acc.password != password)
                {
                    Console.WriteLine("your password is incorrect ");
                    break;
                }
                else if (acc.userName != user && acc.password == password)
                {
                    Console.WriteLine("your username is incorrect ");
                }
                break;           

            }
            Console.WriteLine("yor email is incorrect");
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
