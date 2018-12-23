using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab6._2
{
    class myClass
    {
        public myClass(int param)
        {
            param_ = param;
        }

        private int param_;
        public int Name
        {
            get
            {
                return param_;
            }

            set
            {
                param_ = value;
            }
        }

        public int multiplication()
        {
            return param_ * param_;
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            myClass tmp = new myClass(3);
            Type t = tmp.GetType();
            Console.WriteLine("Constructors:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nMethods:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nPropeties:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
