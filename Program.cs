using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    internal class Program
    {
        public delegate float OperationDelegate(float x, float y);
        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float Subtract(float x, float y)
        {
            return x - y;
        }
        public static float Multiply(float x, float y)
        {
            return x * y;
        }
        public static float Divide(float x, float y)
        {
            return x / y;
        }
        public static float Apply(OperationDelegate ODP, float x, float y)   //Apply methodu void kimi nece istifade etmek olar?
        {
            return ODP.Invoke(x, y);
        }
        static void Main(string[] args)
        {

            float a = Apply(Add, 60, 15);
            Console.WriteLine(a);
            Console.WriteLine(Apply(Subtract, 55, 12));
            Console.WriteLine(Apply(Multiply, 12, 5));
            Console.WriteLine(Apply(Divide, 60, 4));



            Console.Read();
        }
    }
}
