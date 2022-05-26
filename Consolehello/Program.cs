
using System;
namespace CalcSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Function calling
            Calc();
        }

        //Function definition
        static void Calc()
        {
            int i, j, res;
            Console.Write("Enter value 1 :");
            i = Int32.Parse(Console.ReadLine());

            Console.Write("Enter value 2 :");
            j = Int32.Parse(Console.ReadLine());

            res = i + j;
            Console.WriteLine(res);
        }
    }
}

