using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505part4q2
{

    class Rational
    {
        public int _numerator { get; private set; }
        public int _denominator { get; private set; }

        public Rational(int numerator, int denominator)
        {
            InitializeRationalNumber(numerator, denominator);
        }

        public bool InitializeRationalNumber(int numerator, int denominator)
        {
            if (numerator == denominator)
            {
                this._numerator = 1;
                this._denominator = 1;
                return true;
            }
            else if (denominator <= 0 || numerator < 0)
            {
                this._numerator = 0;
                this._denominator = 0;
                return false;
            }

            this._numerator = numerator;
            this._denominator = denominator;
            return true;

        }

        public bool GreaterThen(Rational other)
        {
            if (this._numerator * other._denominator > this._denominator * other._numerator)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is Rational == false)
                return false;
            Rational r = obj as Rational;
            return this._numerator * r._denominator == this._denominator * r._numerator;
        }

        public override int GetHashCode()
        {
            var hashCode = 1796543463;
            hashCode = hashCode * -1521134295 + _numerator.GetHashCode();
            hashCode = hashCode * -1521134295 + _denominator.GetHashCode();
            return hashCode;
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            Rational newRNumber = new Rational((r1._numerator * r2._denominator) + (r1._denominator * r2._numerator), r1._denominator * r2._denominator);
            return newRNumber;
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            Rational newRNumber = new Rational((r1._numerator * r2._denominator) - (r1._denominator * r2._numerator), r1._denominator * r2._denominator);
            if (newRNumber._numerator == 0)
                newRNumber._denominator = 0;
            return newRNumber;
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            Rational newRNumber = new Rational(r1._numerator * r2._numerator, r1._denominator * r2._denominator);
            return newRNumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    }
