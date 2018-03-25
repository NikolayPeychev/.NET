using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Fraction
    {
        private int chislitel;
        private int znamenatel;


        public Fraction(int chislitel, int znamenatel)
        {
            this.chislitel = chislitel;
            this.znamenatel = znamenatel;
        }


        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {

            if (lhs.znamenatel == rhs.znamenatel)
            {
                return new Fraction(lhs.chislitel + rhs.chislitel,
                    lhs.znamenatel);
            }

            int firstProduct = (lhs.chislitel * rhs.znamenatel) + (lhs.znamenatel * rhs.chislitel);
            int secondProduct = rhs.znamenatel * lhs.znamenatel;
            return new Fraction(
                (lhs.chislitel * rhs.znamenatel) + (lhs.znamenatel * rhs.chislitel),
                lhs.znamenatel * rhs.znamenatel
                );

        }
        public static Fraction operator -(Fraction lhs, Fraction rhs)
        {
            if (lhs.znamenatel == rhs.znamenatel)
            {
                return new Fraction(lhs.chislitel - rhs.chislitel,
                    lhs.znamenatel);
            }
            int firstProduct = (lhs.chislitel * rhs.znamenatel) - (lhs.znamenatel * rhs.chislitel);
            int secondProduct = rhs.znamenatel * lhs.znamenatel;
            return new Fraction(
                (lhs.chislitel * rhs.znamenatel) - (lhs.znamenatel * rhs.chislitel),
                lhs.znamenatel * rhs.znamenatel
                );
        }
        public static Fraction operator *(Fraction lhs, Fraction rhs)
        {
            if (lhs.znamenatel == rhs.znamenatel && lhs.chislitel == rhs.chislitel)
            {
                return new Fraction(lhs.chislitel * rhs.chislitel, lhs.znamenatel * rhs.znamenatel);
            }
            int firstProduct = lhs.chislitel * rhs.chislitel;
            int secondProduct = lhs.znamenatel * rhs.znamenatel;
            return new Fraction(

                lhs.chislitel * rhs.chislitel,
                lhs.znamenatel * rhs.znamenatel
                );
        }
        public static Fraction operator /(Fraction lhs, Fraction rhs)
        {

            int firstProduct = lhs.chislitel * rhs.znamenatel;
            int secondProduct = lhs.znamenatel * rhs.chislitel;
            return new Fraction(

                lhs.chislitel * rhs.znamenatel,
                lhs.znamenatel * rhs.chislitel
                );
        }

        public override string ToString()
        {
            String s = chislitel.ToString() + "/" +
                znamenatel.ToString();
            return s;
        }
    }


    public class TesterOverrideToString
    {
        static void Main()
        {
            Fraction f1 = new Fraction(5, 4);
            Console.WriteLine("f1: {0}", f1.ToString());

            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine("f2: {0}", f2.ToString());

            Fraction f3 = f1 + f2;
            Console.WriteLine("f1 + f2 = f3: {0}", f3.ToString());
            Fraction f4 = f1 - f2;
            Console.WriteLine("f1 - f2 = f4: {0}", f4.ToString());
            Fraction f5 = f1 * f2;
            Console.WriteLine("f1 * f2 = f5: {0}", f5.ToString());
            Fraction f6 = f1 / f2;
            Console.WriteLine("f1 / f2 = f6: {0}", f6.ToString());
        }
    }
}