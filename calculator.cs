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
            Console.WriteLine("请输入两个整数：");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            Console.Write("请输入要进行的操作:");
            String c = Console.ReadLine();
            switch (c)
            {
                case "+": Console.WriteLine(Add.add(a,b)); break;
                case "-": Console.WriteLine(Minus.minus(a, b)); break;
                case "*": Console.WriteLine(Multiplication.multiplication(a, b)); break;
                case "/": Console.WriteLine(Division.division(a, b)); break;
                case "=": Console.WriteLine(a.Equals(b)); break;
                default: Console.WriteLine("您输入的操作不存在"); break;
            }
            Console.Read();
        }
        public bool Equals(Object a)
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
    }
    class Minus
    {
        public static int minus(int a, int b)
        {
            return a - b;
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