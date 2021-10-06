using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Lab3
    {
        public void problem1()
        {
            Console.Write("Sonni kiriting: ");
            int son = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija (int): " + son);
            Console.WriteLine("Natija (char): " + Convert.ToChar(son));
        }
        public void problem2()
        {
            Console.Write("Enter width: ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Enter length: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is " + l * w);
        }
        public void problem3()
        {
            Console.Write("Enter width: ");
            float w = float.Parse(Console.ReadLine());
            Console.Write("Enter length: ");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("Area is " +(w * l).ToString("0.00"));
        }
        public void problem4()
        {
            Console.Write("Enter real number: ");
            float kasr = float.Parse(Console.ReadLine());
            Console.WriteLine("Round off: " + kasr.ToString("0"));
        }
        public void problem5()
        {
            Console.Write("Enter lower case: ");
            char low = Convert.ToChar(Console.Read());
            int son = Convert.ToInt32(low);
            Console.WriteLine("Upper case: " + Convert.ToChar(low - 32));
        }
        public void problem6()
        {
            Console.Write("Enter upper case: ");
            char upper = Convert.ToChar(Console.Read());
            int son = Convert.ToInt32(upper);
            Console.WriteLine("Upper case: " + Convert.ToChar(upper + 32));
        }
    }
}