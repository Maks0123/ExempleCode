using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons1.Models
{
    public class Fract
    {
         #region fields

        private int _chislitel;
        private int _znamenatel;
        #endregion 

        #region properties

        public int Chislitel
        {
            get
            {
                return _chislitel;
            }
            set
            {
                _chislitel = value;
            }
        }
        public int Znamenatel
        {
            get
            {
                return _znamenatel;
            }
            set
            {
                if (value == 0) throw new DivideByZeroException("Знаменатель не может быть 0");
                _znamenatel = value;
            }
        }
        #endregion

        #region ctors
        public Fract(int chislitel)
        {
            _chislitel = chislitel;
            _znamenatel = 1;
        }
        public Fract(int chislitel = 0, int znamenatel = 1)
        {
            if (znamenatel == 0) throw new DivideByZeroException("Знаменатель не может быть 0");
            _chislitel = chislitel;
            _znamenatel = znamenatel;
        }

        #endregion

        #region overrides
        public override bool Equals(object obj)
        {
            return _chislitel * ((Fract)obj)._znamenatel == ((Fract)obj)._chislitel * _znamenatel;
        }
        public override string ToString()
        {
            if (_chislitel == _znamenatel)
            {
                return "1";
            }
            int nod = NOD(_chislitel, _znamenatel);
            if (_chislitel < _znamenatel)
            {
                return $"{_chislitel / nod}/{_znamenatel / nod}";
            }
            return $"{_chislitel / _znamenatel}+{_chislitel % _znamenatel / nod}/{_znamenatel / nod}";
        }
        #endregion

        #region utils
        public static int NOD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public Fract Uprostit()
        {
            int nod = NOD(_chislitel, _znamenatel);
            _chislitel /= nod;
            _znamenatel /= nod;
            return this;
        }
        #endregion

        #region operators
        public static Fract operator -(Fract a)
        {
            return new Fract(-a._chislitel, a._znamenatel).Uprostit();
        }
        public static Fract operator +(Fract a)
        {
            return new Fract(a._chislitel, a._znamenatel).Uprostit();
        }
        public static Fract operator +(Fract a, Fract b)
        {
            return new Fract(a._chislitel * b._znamenatel + b._chislitel * a._znamenatel, a._znamenatel * b._znamenatel).Uprostit();
        }
        public static Fract operator +(int b, Fract a)
        {
            return new Fract(a._chislitel + b * a._znamenatel, a._znamenatel).Uprostit();
        }
        public static Fract operator +(Fract a, int b)
        {
            return new Fract(a._chislitel + b * a._znamenatel, a._znamenatel).Uprostit();
        }
        public static Fract operator -(Fract a, Fract b)
        {
            return new Fract(a._chislitel * b._znamenatel - b._chislitel * a._znamenatel, a._znamenatel * b._znamenatel).Uprostit();
        }
        public static Fract operator -(int b, Fract a)
        {
            return new Fract(a._chislitel - b * a._znamenatel, a._znamenatel).Uprostit();
        }
        public static Fract operator -(Fract a, int b)
        {
            return new Fract(a._chislitel - b * a._znamenatel, a._znamenatel).Uprostit();
        }
        public static Fract operator *(Fract a, Fract b)
        {
            return new Fract(
                a._chislitel * b._chislitel,
                a._znamenatel * b._znamenatel
                ).Uprostit();
        }
        public static Fract operator /(Fract a, Fract b)
        {
            return new Fract(
               a._chislitel * b._znamenatel,
               a._znamenatel * b._chislitel
               ).Uprostit();
        }
        public static bool operator <(Fract a, Fract b)
        {
            return a._chislitel * b._znamenatel < b._chislitel * a._znamenatel;
        }
        public static bool operator >(Fract a, Fract b)
        {
            return a._chislitel * b._znamenatel > b._chislitel * a._znamenatel;
        }
        public static bool operator <=(Fract a, Fract b)
        {
            return a._chislitel * b._znamenatel <= b._chislitel * a._znamenatel;
        }
        public static bool operator >=(Fract a, Fract b)
        {
            return a._chislitel * b._znamenatel >= b._chislitel * a._znamenatel;
        }
        public static bool operator ==(Fract a, Fract b)
        {
            return a._chislitel * b._znamenatel == b._chislitel * a._znamenatel;
        }
        public static bool operator !=(Fract a, Fract b)
        {
            return a._chislitel * b._znamenatel != b._chislitel * a._znamenatel;
        }
        public static implicit operator double(Fract a)
        {
            return a._chislitel / (double)a._znamenatel;
        }
        public static explicit operator int(Fract a)
        {
            return a._chislitel / a._znamenatel;
        }
        #endregion
    }

}