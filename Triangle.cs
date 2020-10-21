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

        public Triangle (double A, double B, double C,double H)
        {
            a = A;
            b = B;
            c = C;
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

        public double Surface() 
        {

            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double Height()
        {
            double p = SemiPerimeter();
            double h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a;
            return h;
        }

       
        public double GetSetA 
        {
            get 
            { return a; }
            set
            { a = value;}
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
                if ((a > b + c) && (b > a + c) && (c > a + b)) 
                return false;
                else return true;
            }
        }
        public string TypeOfTriangle()
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

        public string TriangleType() 
        {
           
           if  ((a == b) && (b == c) && (c == a))
           {
                answer = "Равносторонний";
           }
           else if  ((a == b) || (b == c) || (a == c))
           {
                answer = "Равнобедренный";
           }
           else
           {
                answer = "Разносторонний";
           }
            return answer;
        }
        public string ImageType()
        {
            string image = "";
            if (answer == "Равносторонний") 
            {
                image = @"C:\Users\opilane\source\repos\triangle1\image\ravno.png"; 
            }
            if (answer == "Равнобедренный")
            {
                image = @"C:\Users\opilane\source\repos\triangle1\image\ravnobed.png"; 
            }
            if (answer == "Разносторонний")
            {
                image = @"C:\Users\opilane\source\repos\triangle1\image\raznost.png"; 
            }
            return image;
        }
        public double med()
        {
            double m = 0;
            m = Math.Round((Math.Sqrt(2 * b * b + 2 * c * c - a * a) / 2), 2);
            return m;
        }
        public double bis()
        {
            double bisectrisa;
            bisectrisa = Math.Round(Math.Sqrt(b * c * ((b + c) * (b + c) - a * a)) / (b + c), 2);
            return bisectrisa;
        }
    }
}
