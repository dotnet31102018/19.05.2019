using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {

        // method void which accpets String
        public delegate void SignatureGetStringReturnVoid(string message);

        static SignatureGetStringReturnVoid method1;

        // void which accepts String
        static void MyPrinter(string message)
        {
            Console.WriteLine(message);
        }

        static void Imposter(int x)
        {

        }

        static void Execute1(SignatureGetStringReturnVoid func)
        {
            if (func != null)
            {
                func.Invoke("Hello Again!");
            }
        }

        static void Main(string[] args)
        {
            // Employee e1 = new Employee();
            // Emplopyee e = e1;
            method1 = MyPrinter;

            //method1 = Imposter; -- wrong!

            method1.Invoke("Hello World!");
            Execute1(method1);
        }
    }
}
