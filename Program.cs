using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Random random = new Random();
            //for (int i = 1; i <= 10; i++)
            //{
            //    int x = random.Next(-40, 40);
            //    Console.WriteLine(x);
            //    Console.Read();

            //Задание 2
            //int count = 0;
            //Random random = new Random();
            //for(int i = 1; i <= 15; i++)
            //{
            //    double x = -20 + 50 * random.NextDouble();
            //    Console.WriteLine(x);
            //    if (x>0)
            //    { count++;}
            //    Console.WriteLine($"кол-во полученных чисел={count}");
            //    Console.Read();

            {
                //Задание 3
                int count = 0;
                Random random = new Random();
                for (int i = 1; i <= 12; i++)
                {
                    double x = -5 + 10 * random.NextDouble();
                    Console.WriteLine(x);
                    if(x>0)
                    Console.Read();
                }
                //Задание 4
                //Random random = new Random();
                //for (int i = 1; i <= 8; i++)
                //{
                //    int x = random.Next(-30, 30);
                //    Console.WriteLine(x);
                //    Console.Read();

                //Задание 5
                //Random random = new Random();
                //for (int i = 1; i <= 10; i++)
                //{
                //    int x = random.Next(-20, 20);
                //    Console.WriteLine(x);
                //    Console.Read();
            }
        }
    }
}
