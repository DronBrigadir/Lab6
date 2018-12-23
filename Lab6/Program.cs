using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
  class Program
  {

    delegate double myDelegate(int x, int y);
    static double lengthToCoordinatesBegin(int x, int y)
    {
        return Math.Sqrt(x * x + y * y);
    }

    static void printLength(int x, int y, myDelegate myDelegateParam)
    {
        Console.WriteLine("Length = {0}", myDelegateParam(x, y));
    }

    static void printLengthFunc(int x, int y, Func<int, int, double> myFuncParam)
    {
        Console.WriteLine("Length = {0}", myFuncParam(x, y));
    }

    static void Main(string[] args)
    {
        int x = 4;
        int y = 7;
        myDelegate func = new myDelegate(lengthToCoordinatesBegin);
        printLength(x, y, func);
        printLength(x, y, (int first, int second) =>
            {
                return (first * first + second * second) / 2;
            }
        );

        printLengthFunc(x, y, (int first, int second) =>
            {
                return (first + second) / 3.0;
            }
        );
        Console.ReadKey();
    }
  }
}
