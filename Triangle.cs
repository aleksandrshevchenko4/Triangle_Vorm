using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    class Triangl
    {
        public double a; 
        public double b; 
        public double c; 
        public double h; 
        public string answer;
        public Triangl(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangl(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public Triangl(double H, double B)
        {
            b = B;
            h = H;
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
        public double HeightOfTriangle()
        {
            double p;
            if (a < 0 || b < 0 || c < 0)
            {
                return h = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    p = 0.5 * (a + b + c);
                    h = Math.Round((2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a), 2);
                    return h;
                }
                else
                {
                    return h = 0;
                }
            }
        }

        internal object SemiPerimeter()
        {
            throw new NotImplementedException();
        }

        internal ListViewItem.ListViewSubItem TriangleType()
        {
            throw new NotImplementedException();
        }

        public double AreaOfTriangle()
        {

            double S;
            if (a < 0 || b < 0 || c < 0)
            {
                S = 0;
                return S;
            }
            else
            {
                if (ExistTriangle)
                {
                    S = 1 / 2 * b * HeightOfTriangle();
                    return S;
                }
                else
                {
                    return S = 0;
                }
            }

        }

        internal ListViewItem.ListViewSubItem TrianglType()
        {
            throw new NotImplementedException();
        }

        public double Perimeter() 
        {
            double p;
            if (a < 0 || b < 0 || c < 0)
            {
                return p = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    p = a + b + c; 
                    return p; 
                }
                else
                {
                    return p = 0;
                }
            }
        }
        public double HalfPerimeter()
        {
            return Perimeter() / 2;
        }
        public double Surface()
        {
            double s;
            double p;
            if (a < 0 || b < 0 || c < 0)
            {
                return s = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    p = Perimeter() / 2;
                    s = Math.Round(Math.Sqrt((p * (p - a) * (p - b) * (p - c))), 2);
                    return s;
                }
                else
                {
                    return s = 0;
                }
            }
        }
        public double GetSetA 
        {
            get
            { return a; }
            set 
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                {
                    return true;
                } 
                else if (a < 0 || b < 0 || c < 0)
                {
                    return false;
                }
                else return false;
            }
        }
        public bool EquilateralTriangle
        {

            get
            {
                if ((a == b) || (a == c) || (b == c))
                    return true;
                else return false;
            }
        }
        public string TypeOfTriangle()
        {
            if (a < 0 || b < 0 || c < 0)
            {
                answer = "";
                return answer;
            }
            else
            {
                if (ExistTriangle)
                {
                    if ((a * a == b * b + c * c) || (b * b == c * c + a * a) || (c * c == a * a + b * b))
                    {
                        answer = "прямоугольный";
                    }
                    else if ((a * a > b * b + c * c) || (c * c > a * a + b * b) || (b * b > a * a + c * c))
                    {
                        answer = "тупоугольный";
                    }
                    else
                    {
                        answer = "остроугольный";
                    }
                    return answer;
                }
                else
                {
                    return answer = "";
                }

            }
        }
        public string ImageType()
        {
            string image = "";
            if (answer == "Прямоугольный")
            {
                image = (@"..\image\prjam.png");
            }
            if (answer == "Остроугольный")
            {
                image = (@"..\image\ostr.png");
            }
            if (answer == "Тупоугольный")
            {
                image = (@"..\image\tup.png");
            }
            return image;
        }
    }
}
