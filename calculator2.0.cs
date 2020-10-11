using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            String e;
            String d;
            Console.WriteLine("请输入两个整数：");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入两个字符串：");
            e = Console.ReadLine();
            d = Console.ReadLine();
            Console.Write("请输入要进行的操作:");
            String c = Console.ReadLine();
            switch (c)
            {
                case "+": Console.WriteLine("整数加法：" + Add.add(a, b)); Console.WriteLine("字符串加法：" + Add.add(e,d)); break;
                case "-": Console.WriteLine("整数减法：" + Minus.minus(a, b)); Console.WriteLine("字符串减法：" + Minus.minus(e, d)); break;
                case "*": Console.WriteLine(Multiplication.multiplication(a, b)); break;
                case "/": Console.WriteLine(Division.division(a, b)); break;
                case "=": Console.WriteLine(a.Equals(b)); break;
                default: Console.WriteLine("您输入的操作不存在"); break;
            }
            Console.Read();
        }
        public override bool Equals(Object a)
        {
            if (this == a)
            {
                return true;
            }
            else 
            {
                return false;   
            }
        }
    }
    class Add
    {
        public static int add(int a,int b)
        {
            return a+b;
        }
        public static String add(String e, String d)
        {
            return e + d;
        }
    }
    class Minus
    {
        public static int minus(int a, int b)
        {
            return a - b;
        }
        public static String minus(String e, String d)
        {

            if (e.Length < d.Length)
            { return e; }
            char[] a = e.ToCharArray();
            char[] b = d.ToCharArray();
            char[] c = e.ToCharArray();
            int j = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if ((a.Length - i) < b.Length)
                { break; }
                if (b[0] == a[i])
                {
                    for (j = 1; j < b.Length; j++)
                    {
                        if (b[j] != a[i + j])
                        {
                            break;
                        }
                    }
                    if (j == b.Length)
                    {
                        for (int t = i; t < i + b.Length; t++)
                            c[t] = ' ';
                    }
                }
            }
            String s = "";
            for (int y = 0; y < c.Length; y++)
            {
                s += c[y];
            }
            return s;
        }
    }
    class Multiplication
    {
        public static int multiplication(int a, int b)
        {
            return a * b;
        }
    }
    class Division
    {
        public static int division(int a, int b)
        {
            return a / b;
        }
    }
}
