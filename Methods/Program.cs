using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
          double  num1 = Convert.ToDouble(Console.ReadLine()) ;

            Console.WriteLine("Enter first Number");
           double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(GetMax(num1,num2));
            Console.ReadLine();


        }

        static double GetMax(double num1, double num2) {

            if (num1 > num2)
            {
                return num1;
            }
            else {

                return num2;
            }

            
        }
    }
}
