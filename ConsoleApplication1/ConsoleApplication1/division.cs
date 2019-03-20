using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Class1
    {
  
        private double val1,val2, multiplicacion;

        public void setvalor1(double a) {
            val1  = a;
        }

        public void setvalor2(double b) {
            val2 = b;
        }

        public double getmulti() {
           multiplicacion = val1  * val2;
            return multiplicacion ;
        }

        public void Lineas() {
            Console.WriteLine("-------------------------");
        }
    }
}
