using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Lab6
    {
        public void problem1()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(n);
        }
        public void problem2()
        {
            int n = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            if (n > t)
            {
                Console.WriteLine($"{t}<");
            }
            else if (n == t)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine($"{t}>");
            }
        }
        public void problem3()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(nums.Sum());
        }
        public void problem4()
        {
            int f = 1;
            foreach (int i in Enumerable.Range(1, 10))
            {
                Console.Write($"{i}!=1");
                for (int j = 2; j <= i; j++)
                {
                    Console.Write($"*{j}");
                }
                f *= i;
                Console.WriteLine($"={f}");
            }
        }
        public void problem5()
        {
            var sonlar = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int a = sonlar[0] > sonlar[1] ? sonlar[0] : sonlar[1];
            int b = sonlar[0] < sonlar[1] ? sonlar[0] : sonlar[1];
            while(a % b != 0)
            {
                a %= b;
                (a, b) = (b, a); 
            }
            Console.WriteLine(b);
        }
        public void problem6()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4 - i; j > 0; j--)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 4 - i; j > 0; j--)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
        }
        public void problem7()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((j + i) % 10 + " ");
                }
                Console.WriteLine("");
            }
        }
        public void problem8()
        {

        }
        public void problem9()
        {
            int n = int.Parse(Console.ReadLine());
            int p = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1 - i; j > 0; j--)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write(p % 10 + " ");
                    p++;
                }
                Console.Write("\n");
            }
        }
        public void problem10()
        {
            int n = int.Parse(Console.ReadLine());
            int sum;
            int x;
            while(n > 9)
            {
                x = n;
                sum = 0;
                while (x >= 1)
                {
                    sum += x % 10;
                    x /= 10;
                }
                n = sum;
            }
            Console.WriteLine(n);
        }
        public void problem11()
        {

        }
        public void problem12()
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            int sum = 0;
            while(true)
            {
                sum += x;
                if(x == n)
                {
                    break;
                }
                x++;
            }
            Console.WriteLine(sum);
        }
        public void problem13()
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            float sum = 0, a;
            int n = 0;
            foreach (int i in s)
            {
                sum += i;
                n++;
            }
            a = (sum) / (n - 1);

            Console.WriteLine(sum + " " + a.ToString("0.00") + " " + (n-1));
        }
    }
}