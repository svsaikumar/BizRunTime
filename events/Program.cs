using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate void MyDelegate(int x);


        class Program
        {
            public static event MyDelegate MyEvent;

            public static void Notify(int x)
            {
                if (MyEvent != null)
                {
                    MyEvent(x);
                }
            }
            public static void Square(int x)
            {
                Console.WriteLine(x * x);
            }
            public static void Cube(int x)
            {
                Console.WriteLine(x * x * x);
            }
            static void Main(string[] args)
            {
                Program p1 = new Program();
                Console.WriteLine("please enter a number");
                int i = int.Parse(Console.ReadLine());
                MyDelegate md = Square;
                           md += Cube;
                           md.Invoke(i);

                MyEvent += User1.Xhandler;
                MyEvent += User2.Xhandler;
                MyEvent += User3.Xhandler;
                MyEvent += User4.Xhandler;
                Notify(i);

            }
        }  
        class User1
        {
            public static void Xhandler(int x)
            {
                Console.WriteLine("user-1");
            }
        }
        class User2
        {
            public static void Xhandler(int x)
            {
                Console.WriteLine("user-2");
            }
        }
        class User3
        {
            public static void Xhandler(int x)
            {
                Console.WriteLine("user-3");
            }

        }
        class User4
        {
            public static void Xhandler(int x)
            {
                Console.WriteLine("user-4");
            }

        }
    }

