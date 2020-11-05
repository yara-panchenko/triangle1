using System;



namespace WindowsFormsApp1
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;
        public string answer;
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public Triangle(double H, double B)
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
                    p = 0.5 * Perimeter();
                    h = Math.Round((2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a), 2);
                    return h;
                }
                else
                {
                    return h = 0;
                }
            }
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
        public double PoluPerimeter()
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
                        answer = "Прямоугольный";
                    }
                    else if ((a * a > b * b + c * c) || (c * c > a * a + b * b) || (b * b > a * a + c * c))
                    {
                        answer = "Тупоугольный";
                    }
                    else
                    {
                        answer = "Остроугольный";
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
            if (answer == "Равносторонний") 
            {
                image = @"C:\Users\Yarik\source\repos\triangle1\image\ravno.png"; 
            }
            if (answer == "Равнобедренный")
            {
                image = @"C:\Users\Yarik\source\repos\triangle1\image\ravnobed.png"; 
            }
            if (answer == "Разносторонний")
            {
                image = @"C:\Users\Yarik\source\repos\triangle1\image\raznost.png"; 
            }
            return image;
        }
        public double mediana()
        {
            double m;
            if (a < 0 || b < 0 || c < 0)
            {
                m = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    m = Math.Round((Math.Sqrt(2 * b * b + 2 * c * c - a * a) / 2), 2);
                }
                else
                {
                    m = 0;
                }
            }
            return m;
        }
        public double bisectrisa()
        {
            double bisectrisa;
            if (a < 0 || b < 0 || c < 0)
            {
                bisectrisa = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    bisectrisa = Math.Round(Math.Sqrt(b * c * ((b + c) * (b + c) - a * a)) / (b + c), 2);
                }
                else
                {
                    bisectrisa = 0;
                }
            }
            return bisectrisa;
        }
        public double Sin()
        {
            double sinus;
            if (a < 0 || b < 0 || c < 0)
            {
                sinus = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    sinus = Math.Round((a / c), 2);
                }
                else
                {
                    sinus = 0;
                }
            }
            return sinus;
        }
        public double ugolA()
        {
            double ugolA;
            if (a < 0 || b < 0 || c < 0)
            {
                ugolA = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    ugolA = Math.Round((Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI), 2);
                }
                else
                {
                    ugolA = 0;
                }
            }
            return ugolA;
        }
        public double ugolB()
        {
            double ugolB;
            if (a < 0 || b < 0 || c < 0)
            {
                ugolB = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    ugolB = Math.Round((Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI), 2);
                }
                else
                {
                    ugolB = 0;
                }
            }
            return ugolB;
        }
        public double ugolC()
        {
            double ugolC;
            if (a < 0 || b < 0 || c < 0)
            {
                ugolC = 0;
            }
            else
            {
                if (ExistTriangle)
                {
                    ugolC = Math.Round((Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI), 2);
                }
                else
                {
                    ugolC = 0;
                }
            }
            return ugolC;
        }
    }
}