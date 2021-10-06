using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Lab5
    {
        public void problem1()
        {
            int t = int.Parse(Console.ReadLine());
            if (t >= 40 || t < 0)
            {
                Console.WriteLine("ichkarida o'yna");               
            }
            else
            {
                Console.WriteLine("tashqarida o'yna");
            }
        } 
        public void problem2()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int a = l[0], b = l[1];
            if(a > b)
            {
                (a, b) = (b, a);
            }
            if(a*a == b)
            {
                Console.WriteLine($"{a}*{a}={b}");
            }
            else
            {
                Console.WriteLine("none");
            }
        }   
        public void problem3()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (l[0] > l[1])
            {
                Console.WriteLine(l[0]);
            }
            else
            {
                Console.WriteLine(l[1]);
            }
        } 
        public void problem4()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine($"{l.Max()} {l.Min()}");
        }   
        public void problem5()
        {
            int a = int.Parse(Console.ReadLine());
            char j = 'N';
            if (a % 30 == 0)
            {
                j = 'A';
            }
            else if (a % 6 == 0)
            {
                j = 'B';
            }
            else if (a % 10 == 0)
            {
                j = 'C';
            }
            else if (a % 15 == 0)
            {
                j = 'D';
            }
            else if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0)
            {
                j = 'E';
            }
            Console.WriteLine(j);
        }
        public void problem6()
        {
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Normal year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Normal year");
            }
        }
        public void problem7()
        {
            int son = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                int tahmin = int.Parse(Console.ReadLine());
                if(tahmin == son)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                if (tahmin > son)
                {
                    Console.WriteLine("Down");
                }
                else
                {
                    Console.WriteLine("Up");
                }
            }
        }
        public void problem8()
        {
            char l = Convert.ToChar(Console.Read());
            if (l >= 'a' && l <= 'z')
            {
                Console.WriteLine(Convert.ToChar(l - 32));
            }
            else if (l >= 'A' && l <= 'Z')
            {
                Console.WriteLine(Convert.ToChar(l + 32));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
        public void problem9()
        {
            int s = 0, b = 0;
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var t = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if(t[0]==r[0])
            {
                s++;
            }
            else if(t[0]==r[1])
            {
                b++;
            }
            else if(t[0]==r[2])
            {
                b++;
            }
            if(t[1]==r[1])
            {
                s++;
            }
            else if(t[1]==r[0])
            {
                b++;
            }
            else if(t[1]==r[2])
            {
                b++;
            }
            if(t[2]==r[2])
            {
                s++;
            }
            else if(t[2]==r[0])
            {
                b++;    
            }
            else if(t[2]==r[1])
            {
                b++;
            }
            Console.WriteLine($"{s}S{b}B");
        }
        public void problem10()
        {
            var str = Console.ReadLine().Split(' ').ToList();
            if(Convert.ToChar(str[1]) == '+')
            {
                Console.WriteLine(int.Parse(str[0]) + int.Parse(str[2]));
            }
            else
            {
                Console.WriteLine(int.Parse(str[0]) - int.Parse(str[2]));
            }
        }
        public void problem11()
        {
            string[] d = {"Americano", "Caffe Latte", "Lemon Tea"};
            int[] c = {500, 400, 300};
            int dn = int.Parse(Console.ReadLine()) - 1;
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(d[dn] + "\n" + (m - c[dn])/500 + " " + ((m - c[dn])%500)/100);
        }
    }
}