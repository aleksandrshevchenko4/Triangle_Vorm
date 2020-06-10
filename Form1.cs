using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
            h = 0;
        }
        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
            h = 0;
        }

        public string outputA() 
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b); 
        }
        public string outputC() 
        {
            return Convert.ToString(c);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public double Perimeter() 
        {
            double p = 0;
            p = a + b + c; 
            return p; 
        }
        public double SemiPerimeter()
        {
            double p = 0;
            p = (a + b + c) / 2;
            return p;
        }
        public double Height()
        {
            double p = SemiPerimeter();
            double h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a;
            return h;
        }

        public double Surface() 
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        public double GetSetA 
        {
            get 
            {return a;}
            set 
            {a = value;}
        }

        public double GetSetB 
        {
            get
            {return b;}
            set
            {b = value;}
        }

        public double GetSetC 
        {
            get
            {return c;}
            set
            {c = value;}
        }
        public double GetSetH
        {
            get
            { return h; }
            set
            { h = value; }
        }

        public bool ExistTriangle 
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return false;
                else return true;
            }
        }

        public string TypeOfTirangle
        {
            get
            {
                if ((a == b) || (b == c) || (a == c))
                {
                    return "Равнобедренный треугольник";
                }
                else if ((a == b) && (b == c) && (c == a))
                { 
                    return "Равносторонний треугольник";
                }
                else return "Разносторонний треугольник";
            }
        }

    }
}
