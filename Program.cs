using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter real part of complex number");
            var real =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter imaginary part of complex number");
            var imaginary = double.Parse(Console.ReadLine());
            Comlexnumber newcomplex = new Comlexnumber(real, imaginary);
            
            Console.WriteLine("newcomplex:  {0}", newcomplex);

           
            double phase = newcomplex.Phase;
            Console.WriteLine("newcomplex-phase:  {0}", phase);
            Comlexnumber val1 = new Comlexnumber(1, 1);
            Comlexnumber val2 = new Comlexnumber(2, 6);

            Console.WriteLine("First:  {0}", val1);
            Console.WriteLine("Second: {0}", val2);

            // Add both of them
            Comlexnumber res = val1 + val2;
            Console.WriteLine("Result (Sum): {0}", res);
            res = Comlexnumber.Add(val1, val2);

            Console.WriteLine("Result (Sum-1): {0}", res);
            //Multiply 

            res = val1 * val2;
            Console.WriteLine("Result (Multiplay): {0}", res);
            res = Comlexnumber.Multiply(val1, val2);
            Console.WriteLine("Result (Multiplay-1): {0}", res);
            //Divide

            res = val1 / val2;
            Console.WriteLine("Result (Division): {0}", res);
            res = Comlexnumber.Divide(val1, val2);
            Console.WriteLine("Result (Division-1): {0}", res);
            //ABS
            double res1 = Comlexnumber.Abs(val1);
            Console.WriteLine("Result (ABS-res): {0}", res1);
           
            Console.WriteLine("Equal to Magnitude: {0}",

            Comlexnumber.Abs(val1).Equals(val1.Magnitude));

            //Subtract
            res = val1 -val2;
            Console.WriteLine("Result (Subtract): {0}", res);
            res = Comlexnumber.Subtract(val1, val2);
            Console.WriteLine("Result (Subtract-1): {0}", res);
            //Negate

            res = -val1;
            Console.WriteLine("Result (Negate): {0}", res);
            res = Comlexnumber.Negate(val1);
            Console.WriteLine("Result (Negate-1): {0}", res);

            Console.ReadLine();
        }

        
    }
}
