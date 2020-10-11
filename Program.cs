using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work2_8
{
    class Program
    {
        public int x;
        public int y;
        static void Main(string[] args)
        {
            int a, b;
            string c;
            string e, f;
            Console.WriteLine("请输入您要进行的操作:");
            c = Console.ReadLine();
            switch (c)
            {
                case "+": Add add = new Add();
                          Console.WriteLine("请输入两个字符串:");
                          e = Console.ReadLine();
                          f = Console.ReadLine();
                          Console.Write("和结果为:");
                          Console.WriteLine(add.add(e, f));break;
                case "-": Minus minus = new Minus();
                          Console.WriteLine("请输入两个字符串:");
                          e = Console.ReadLine();
                          f = Console.ReadLine();
                          Console.Write("差结果为:");
                          minus.minus(e, f);break;
                case "*": Mutiply mutiply = new Mutiply();
                          Console.WriteLine("请输入两个数:");
                          a = int.Parse(Console.ReadLine());
                          b = int.Parse(Console.ReadLine());
                          Program.Equals(a, b);
                          Console.WriteLine(a + "*" + b + "=" + mutiply.mutiply(a, b));break;
                case "/": Divide divide = new Divide();
                          Console.WriteLine("请输入两个数:");
                          a = int.Parse(Console.ReadLine());
                          b = int.Parse(Console.ReadLine());
                          Program.Equals(a, b);
                          Console.WriteLine(a + "/" + b + "=" + divide.divide(a, b));break;
                default: Console.WriteLine("您输入的符号有误!"); break;
            }
        }
        public static void Equals(int x, int y)
        {
            if (x == y)
                Console.WriteLine("您输入的两个数相等!");
        }
    }
}
