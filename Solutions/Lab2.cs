using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Lab2
    {
        public void problem1()
        {
            Console.WriteLine("222222\n2    2\n2    2\n222222");
        }

        public void problem2()
        {
            Console.WriteLine("  A\n A A\nAAAAA");
        }

        public void problem3()
        {
            Console.Write("Birhdate\nEnter month: ");
            var month = Console.ReadLine();
            Console.Write("Enter date: ");
            var date = Console.ReadLine();
            Console.WriteLine("Birthday is " + int.Parse(month).ToString("D2") + "-" + int.Parse(date).ToString("D2"));
        }

        public void problem4()
        {
            Console.Write("Birhdate\nEnter month and date: ");
            var birthday = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Birthday is " + int.Parse(birthday[0]).ToString("D2") + "-" + int.Parse(birthday[1]).ToString("D2"));
        }

        public void problem5()
        {
            Console.Write("Enter integer: ");
            var son = Console.ReadLine();
            Console.WriteLine(son + son + son + son + son + son);
            Console.WriteLine(son + "    " + son);
            Console.WriteLine(son + "    " + son);
            foreach (int i in Enumerable.Range(0,6))
            {
                Console.Write(son);
            }
            Console.WriteLine();
        }

        public void problem6()
        {
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            foreach (int i in Enumerable.Range(3, 7))
            {
                Console.Write("  " + i + " ");
            }
        }

        public void problem7()
        {
            Console.Write("Enter number: ");
            var son = Console.ReadLine();
            int num = int.Parse(son);
            foreach (int i in Enumerable.Range(1, 9))
            {
                Console.WriteLine(num + "*" + i + "=" + i*num);
            }
        }

        public void problem8()
        {
            int faktorial = 1;
            foreach (int i in Enumerable.Range(1, 5))
            {
                faktorial *= i;
                Console.WriteLine(i + "!=" + faktorial);
            }
        }

        public void problem9()
        {
            int f1 = 0, f2 = 1, sum;
            Console.Write(f1 + " " + f2 + " ");
            foreach (int i in Enumerable.Range(1, 8))
            {
                sum = f1 + f2;
                f1 = f2;
                f2 = sum;
                Console.Write(sum + " ");
            }
        }
    }
}