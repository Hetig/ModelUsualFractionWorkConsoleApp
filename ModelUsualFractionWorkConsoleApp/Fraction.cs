using System;

namespace ModelUsualFractionWorkConsoleApp
{
    public class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(int numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public void Print()
        {
            if (Denominator == 1)
            {
                Console.WriteLine($"{Numerator}");
            }
            else
            {
                Console.WriteLine($"{Numerator}/{Denominator}");
            }
        }

        public void Cut()
        {
            if (Numerator % Denominator == 0)
            {
                Numerator /= Denominator;
                Denominator = 1;
            }
            else if (Denominator % Numerator == 0)
            {               
                Denominator /= Numerator;
                Numerator = 1;
            }
            else
            {
                for (int i = Math.Max(Numerator, Denominator); i > 0; i--)
                {
                    if(Numerator % i == 0 && Denominator % i == 0)
                    {
                        Numerator /= i;
                        Denominator /= i;
                        break;
                    }
                }
            }
        }

        public Fraction Sum(Fraction otherFraction)
        {
            var commonDominator = Denominator * otherFraction.Denominator;
            var resultNumerator = Numerator * otherFraction.Denominator + otherFraction.Numerator * Denominator;
            var result = new Fraction(resultNumerator, commonDominator);
            result.Cut();
            return result;
        }

        public Fraction Difference(Fraction otherFraction)
        {
            var commonDominator = Denominator * otherFraction.Denominator;
            var resultNumerator = Numerator * otherFraction.Denominator - otherFraction.Numerator * Denominator;
            var result = new Fraction(resultNumerator, commonDominator);
            result.Cut();
            return result;
        }

        public Fraction Multiplication(Fraction otherFraction)
        {
            var result = new Fraction(Numerator * otherFraction.Numerator, Denominator * otherFraction.Denominator);
            result.Cut();
            return result;
        }

        public Fraction Divide(Fraction otherFraction)
        {
            var result = new Fraction(Numerator * otherFraction.Denominator, Denominator * otherFraction.Numerator);
            result.Cut();
            return result;
        }

        public Fraction Sum(int number)
        {
            var otherFraction = new Fraction(number);
            return Sum(otherFraction);
        }

        public Fraction Difference(int number)
        {
            var otherFraction = new Fraction(number);
            return Difference(otherFraction);
        }

        public Fraction Multiplication(int number)
        {
            var otherFraction = new Fraction(number);
            return Multiplication(otherFraction);
        }

        public Fraction Divide(int number)
        {
            var otherFraction = new Fraction(number);
            return Divide(otherFraction);
        }
    }
}
