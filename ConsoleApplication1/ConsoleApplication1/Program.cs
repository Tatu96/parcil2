using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1  mts = new Class1();

            mts.Lineas();
            Console.Write("Ingrese primer valor : ");
            double a = double.Parse(Console.ReadLine());
            mts.setvalor1(a);
            mts.Lineas();

            Console.Write("Ingrese segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            mts.setvalor2(b);
            mts.Lineas();

            
	
            Console.WriteLine("la multiplicacion de los numeros es  " + mts.getmulti());
            
            mts.Lineas();

            Console.ReadKey();

        }
    }
}