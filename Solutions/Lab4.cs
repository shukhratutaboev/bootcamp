using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Lab4
    {
        public void problem1()
        {
            var str = int.Parse(Console.ReadLine()).ToString("D5");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(str[i] + "!");
            }
            Console.WriteLine(str[4]);
        }
        public void problem2()
        {
            int sec = int.Parse(Console.ReadLine());
            int hours = sec / 3600;
            sec %= 3600;
            int minutes = sec / 60;
            sec %= 60;
            Console.WriteLine(hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + sec.ToString("D2"));
        }
        public void problem3()
        {
            int son = int.Parse(Console.ReadLine());
            Console.WriteLine((son / 100) % 10);
        }
        public void problem4()
        {
            int son = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(son / 100d, 0) * 100);
        }
        public void problem5()
        {
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToInt32(Math.Pow(l/2,2) / 3.14));
        }
        public void problem6()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 30 || n < 20)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
        public void problem7()
        {
            char h = Convert.ToChar(Console.Read());
            int t = Convert.ToInt32(h);
            if ((h >= 'a' && h <= 'z') || (h >= 'A' && h <= 'Z'))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        public void problem8()
        {
            int son = int.Parse(Console.ReadLine());
            if (son % 2 == 1)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }
        }
        public void problem9()
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (s[1] > s[0])
            {
                Console.WriteLine(s[1]);
            }
            else
            {
                Console.WriteLine(s[0]);
            }
        }
        public void problem10()
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (s[1] > s[0])
            {
                Console.WriteLine(s[1]/s[0] + "\n" + s[1]%s[0]);
            }
            else
            {
                Console.WriteLine(s[0]/s[1] + "\n" + s[0]%s[1]);
            }
        }
    }
}