using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int EM = 10000;
            int sum = 0;
            int OMi = 0;
            int pass = 0029;
            Console.WriteLine("Hallo sir,please put ur card and inter ur pass");
            start:
            pass = Convert.ToInt32(Console.ReadLine());
            if (pass == 0029)
            {
                Console.WriteLine("please inter the number of the operation that u want");
                thired:
                Console.WriteLine("1-Withdraw 2-Deposit 3-Enquiry");
                OMi = Convert.ToInt32(Console.ReadLine());
                if (OMi == 3)
                {
                    Console.WriteLine("u have in ur account " + EM);
                    Console.WriteLine("for other services input {0} and for end input {1}");
                    m = Convert.ToInt32(Console.ReadLine());
                    if (m == 0)
                    { goto thired; }
                    else Console.WriteLine("thank u for using our service");
                }
                else if (OMi == 2)
                {
                Console.WriteLine("1-Withdraw 2-Deposit 3-Enquiry");
                    Console.WriteLine("please Enter the amount you want to Deposit and put it in the right place");
                    OMi = Convert.ToInt32(Console.ReadLine());
                    sum = OMi + EM;
                    Console.WriteLine("ur money become " + sum + " , thank u for using our service");
                    EM = sum;
                }
                else if (OMi == 1)
                {
                    Console.WriteLine("please Enter the amount you want to withdraw");
                    secound:
                    OMi = Convert.ToInt32(Console.ReadLine());
                    sum = EM - OMi;
                    if (sum < 500)
                    { Console.WriteLine("You can not leave your account under $ 500 , please try again"); goto secound; }
                    else
                        Console.WriteLine("please put ur hand in the right place,ur money become " + sum + " , thank u for using our service");
                    EM = sum;

                }
                else { Console.WriteLine("invailed number please try again"); goto thired; }

            }
            else { Console.WriteLine("pass in not correct ,please try again"); goto start; }

        }
    }
}

