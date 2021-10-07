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
        public void problem13()
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (s.Sum() > 100)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void problem14()
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += s[i] * s[i];
            }
            if(sum/(s[0]*s[0]) == 2 || sum/(s[1]*s[1]) == 2 || sum/(s[2]*s[2]) == 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void problem15()
        {
            var b = Convert.ToChar(Console.Read());
            if (b == '-' || b == '*' || b == '+' || b == '/' || b == '%')
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void problem16()
        {
            int son = int.Parse(Console.ReadLine());
            switch (son)
            {
                case 0:
                    Console.WriteLine("nol");
                    break;
                case 1:
                    Console.WriteLine("bir");
                    break;
                case 2:
                    Console.WriteLine("ikki");
                    break;
                case 3:
                    Console.WriteLine("uch");
                    break;
                case 4:
                    Console.WriteLine("to'rt");
                    break;
                case 5:
                    Console.WriteLine("besh");
                    break;
                case 6:
                    Console.WriteLine("olti");
                    break;
                case 7:
                    Console.WriteLine("yetti");
                    break;
                case 8:
                    Console.WriteLine("sakkiz");
                    break;
                case 9:
                    Console.WriteLine("to'qqiz");
                    break;
                default:
                    Console.WriteLine("boshqa");
                    break;
            };
        }
        public void problem17()
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (s[1] >= 45)
            {
                s[1] -= 45;
            }
            else if (s[0] > 0)
            {
                s[0]--;
                s[1] += 15;
            }
            else
            {
                s[0] += 23;
                s[1] += 15;
            }
            Console.WriteLine(s[0].ToString("D2") + " " + s[1].ToString("D2"));
        }
        public void problem18()
        {
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine( b switch
            {
                > 89 => "A",
                > 79 => "B",
                > 69 => "C",
                > 59 => "D",
                _ => "F"
            });
        }
        public void problem19()
        {
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(p % 1000 < 500 ? p / 1000 * 1000 : p / 1000 * 1000 + 1000);
        }
        public void problem20()
        {
            char l = Convert.ToChar(Console.Read());
            if ((l >= 'A' && l <= 'Z') || (l >= 'a' && l <= 'z'))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        public void problem21()
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
    }
}