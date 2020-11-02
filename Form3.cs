using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 2);
        ListBox _list;
        Button btn;
        Label lbl1, lbl2, lbl3, lbl4;
        TextBox box1, box2, box3, box4;
        Panel panel1;
        public Form3()
        {
            this.Size = new Size(800, 900);
            _list = new ListBox();
            _list.Location = new Point(10, 10);
            _list.Size = new Size(265, 150);
            Controls.Add(_list);
            btn = new Button();
            btn.Location = new Point(100, 350);
            btn.Size = new Size(80, 40);
            btn.Click += Btn_Click;
            btn.Text = "Рассчитать";
            Controls.Add(btn);
            lbl1 = new Label();
            lbl1.Size = new Size(70, 30);
            lbl1.Location = new Point(50, 180);
            lbl1.Text = "А";
            Controls.Add(lbl1);
            lbl2 = new Label();
            lbl2.Size = new Size(70, 30);
            lbl2.Location = new Point(50, 210);
            lbl2.Text = "B";
            Controls.Add(lbl2);
            lbl3 = new Label();
            lbl3.Size = new Size(70, 30);
            lbl3.Location = new Point(50, 240);
            lbl3.Text = "C";
            Controls.Add(lbl3);
            lbl4 = new Label();
            lbl4.Size = new Size(70, 30);
            lbl4.Location = new Point(50, 270);
            lbl4.Text = "H";
            Controls.Add(lbl4);
            box1 = new TextBox();
            box1.Location = new Point(120, 180);
            Controls.Add(box1);
            box2 = new TextBox();
            box2.Location = new Point(120, 210);
            Controls.Add(box2);
            box3 = new TextBox();
            box3.Location = new Point(120, 240);
            Controls.Add(box3);
            box4 = new TextBox();
            box4.Location = new Point(120, 270);
            Controls.Add(box4);
            panel1 = new Panel();
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 585);
            panel1.TabIndex = 13;
            Controls.Add(panel1);
            gp = panel1.CreateGraphics();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            _list.Items.Clear();
            double a, b, c, h;
            if (box1.Text == "" || box2.Text == "" || box3.Text == "" || box4.Text == "")
            {
                a = 0;
                b = 0;
                c = 0;
                h = 0;
            }
            else
            {
                a = Convert.ToDouble(box1.Text);
                b = Convert.ToDouble(box2.Text);
                c = Convert.ToDouble(box3.Text);
                h = Convert.ToDouble(box4.Text);
            }        
            Triangle triangle = new Triangle(a, b, c, h);
            _list.Items.Add("A:" + " " + triangle.outputA());
            _list.Items.Add("B:" + " " + triangle.outputB());
            _list.Items.Add("C:" + " " + triangle.outputC());
            _list.Items.Add("H:" + " " + triangle.outputH());
            if (triangle.outputH() == "")
            {
                _list.Items.Add("Высота:" + " " + triangle.Height());
                box4.Text = Convert.ToString(triangle.Height());

            }
            else
            {
                if (triangle.ExistTriangle)
                {
                    if (triangle.outputH() != Convert.ToString(triangle.Height()))
                    {
                        _list.Items.Add("Высота:" + " " + Convert.ToDouble(box4.Text) + "(Правильная высота: " + triangle.Height() + ")");
                    }
                    else
                    {
                        _list.Items.Add("Высота:" + " " + triangle.outputH());
                    }
                }
                else
                {
                    _list.Items.Add("Высота:" + " 0");
                }

            }
            _list.Items.Add("P:" + " " + Convert.ToString(triangle.Perimeter()));
            _list.Items.Add("S:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { _list.Items.Add("Exists"); }
            else _list.Items.Add("No Exists");
            _list.Items.Add("Тип углов:" + " " + triangle.TypeOfTriangle());
            _list.Items.Add("Тип треугольника по сторонам:" + " " + triangle.TriangleType());
            _list.Items.Add("M:" + " " + Convert.ToString(triangle.med()));
            _list.Items.Add("Bis:" + " " + Convert.ToString(triangle.bis()));
            _list.Items.Add("Sin А:" + " " + Convert.ToString(triangle.Sin()));
            
            if (triangle.TriangleType() == "Равносторонний")
            {
                Point p1 = new Point(600, 200);
                Point p2 = new Point(680, 200);
                Point p3 = new Point(640, 150);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else if (triangle.TriangleType() == "Равнобедренный")
            {
                Point p1 = new Point(520, 200);
                Point p2 = new Point(560, 200);
                Point p3 = new Point(540, 130);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else if (triangle.TriangleType() == "Разносторонний")
            {
                Point p1 = new Point(305, 200);
                Point p2 = new Point(450, 200);
                Point p3 = new Point(355, 130);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            if(triangle.TypeOfTriangle()== "Прямоугольный")
            {
                Point p1 = new Point(605, 5);
                Point p2 = new Point(605, 60);
                Point p3 = new Point(675, 60);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else if (triangle.TypeOfTriangle()== "Тупоугольный")
            {
                Point p1 = new Point(485, 5);
                Point p2 = new Point(520, 60);
                Point p3 = new Point(580, 60);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else if (triangle.TypeOfTriangle() == "Остроугольный")
            {
                Point p1 = new Point(305, 60);
                Point p2 = new Point(450, 60);
                Point p3 = new Point(355, 5);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
        }       
    }
}
