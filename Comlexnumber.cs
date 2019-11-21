using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Comlexnumber
    {
        private readonly double real;
        private double imaginary;
        //private double magnitude;

       
                
       
        public Comlexnumber(Double real, Double imaginary)/* Constructor to create a complex number with rectangular co-ordinates  */
        {
            this.real = real;
            this.imaginary = imaginary;
        }


        // --------------SECTION: Public Properties -------------- //

        public Double Real => real;

        public Double Imaginary => imaginary;

        public Double Magnitude => Comlexnumber.Abs((this));

        public Double Phase => Math.Atan2(Imaginary, real);
        // --------------SECTION: Attributes -------------- //

        public static readonly Comlexnumber Zero = new Comlexnumber (0.0, 0.0);
        public static readonly Comlexnumber One = new Comlexnumber (1.0, 0.0);
        public static readonly Comlexnumber ImaginaryOne = new Comlexnumber (0.0, 1.0);

        // --------------SECTION: Constructors and factory methods -------------- //




        public static Comlexnumber Negate(Comlexnumber value)
        {
            return -value;
        }

        public static Comlexnumber Add(Comlexnumber firts, Comlexnumber second)
        {
            return firts + second;
        }

        public static Comlexnumber Subtract(Comlexnumber firts, Comlexnumber second)
        {
            return firts - second;
        }

        public static Comlexnumber Multiply(Comlexnumber firts, Comlexnumber second)
        {
            return firts * second;
        }

        public static Comlexnumber Divide(Comlexnumber dividend, Comlexnumber divisor)
        {
            return dividend / divisor;
        }

        //// --------------SECTION: Arithmetic Operator(unary) Overloading -------------- //
        public static Comlexnumber operator -(Comlexnumber value)  /* Unary negation of a complex number */
        {

            return (new Comlexnumber((-value.real), (-value.imaginary)));
        }

        // --------------SECTION: Arithmetic Operator(binary) Overloading -------------- //       
        public static Comlexnumber operator +(Comlexnumber first, Comlexnumber second)
        {
            return (new Comlexnumber((first.real  + second.real), (first.imaginary + second.imaginary)));

        }

        public static Comlexnumber operator -(Comlexnumber first, Comlexnumber second)
        {
            return (new Comlexnumber((first.real - second.real), (first.imaginary - second.imaginary)));
        }

        public static Comlexnumber operator *(Comlexnumber first, Comlexnumber second)
        {
            // Multiplication:  (a + bi)(c + di) = (ac -bd) + (bc + ad)i
            Double result_Realpart = (first.real * second.real) - (first.imaginary * second.imaginary);
            Double result_Imaginarypart = (first.imaginary * second.real) + (first.real * second.imaginary);
            return (new Comlexnumber(result_Realpart, result_Imaginarypart));
        }

        public static Comlexnumber operator /(Comlexnumber first, Comlexnumber second)
        {
            // Division : Smith's formula.
            double a = first.real ;
            double b = first.imaginary;
            double c = second.real;
            double d = second.imaginary;

            if (Math.Abs(d) < Math.Abs(c))
            {
                int doc = (int)( d / c);
                return new Comlexnumber((int)((a + b * doc) / (c + d * doc)),(int)( (b - a * doc) / (c + d * doc)));
            }
            else
            {
                int cod = (int)(c / d);
                return new Comlexnumber((int)((b + a * cod) / (d + c * cod)),(int)( (-a + b * cod) / (d + c * cod)));
            }
        }


        // --------------SECTION: Other arithmetic operations  -------------- //

        public static Double Abs(Comlexnumber value)
        {

            if (Double.IsInfinity(value.real) || Double.IsInfinity(value.imaginary))
            {
                return double.PositiveInfinity;
            }

           
            double c = Math.Abs(value.real);
            double d = Math.Abs(value.imaginary);

            if (c > d)
            {
                double r = d / c;
                return c * Math.Sqrt(1.0 + r * r);
            }
            else if (d == 0.0)
            {
                return c;  // c is either 0.0 or NaN
            }
            else
            {
                double r = c / d;
                return d * Math.Sqrt(1.0 + r * r);
            }
        }
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }

    }
}
