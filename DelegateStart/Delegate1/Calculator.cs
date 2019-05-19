using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {

        public delegate int OperationFunc(int x, int y);

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Divide(int x, int y)
        {
            return x / y;
        }

        private static int Calculator(OperationFunc func, int x, int y)
        {
            int result = func.Invoke(x, y);
            return result;
        }

        private static OperationFunc GetMethod(string operation)
        {
            switch (operation)
            {
                case "+": return Add;
                case "-": return Subtract;
                case "*": return Multiply;
                case "/": return Divide;
                    default:
                    return null;
            }
        }

        static void Main(string[] args)
        {
            int x = 4;
            int y = 8;
            Console.WriteLine( Calculator(Add, x, y) );
            Console.WriteLine(Calculator(Subtract, x, y));
            Console.WriteLine(Calculator(Multiply, x, y));
            Console.WriteLine(Calculator(Divide, x, y));

            OperationFunc myMethod = GetMethod("*");
            Console.WriteLine(  myMethod(2, 3) );
            Console.WriteLine(GetMethod("*")(2, 3));

            int twoPlusThree = GetMethod("+")(2, 3);
            int twoPlusThree_ = GetMethod("+").Invoke(2, 3);
        }
    }
}
