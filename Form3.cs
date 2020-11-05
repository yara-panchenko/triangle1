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
        ListBox _list;
        Button btn;
        Label lA, lB, lC, lH;
        TextBox txtA, txtB, txtC, txtH;
        PictureBox box;
        RadioButton r1, r2;
        double a, b, c, h;
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 2);
        public Form3()
        {
            this.Size = new Size(475, 500);
            this.Text = "Triangle";
            this.MaximizeBox = false;
            Panel panel1 = new Panel();
            panel1.Location = new Point(210, 220);
            panel1.Size = new Size(230, 210);
            panel1.BackColor = Color.White;
            Controls.Add(panel1);
            gp = panel1.CreateGraphics();
            _list = new ListBox();
            _list.Location = new Point(10, 10);
            _list.Size = new Size(440, 200);
            Controls.Add(_list);
            btn = new Button();
            btn.Location = new Point(120, 390);
            btn.Size = new Size(80, 40);
            btn.Click += Btn_Click;
            btn.Text = "Запуск";
            Controls.Add(btn);
            r1 = new RadioButton();
            r1.Location = new Point(105, 340);
            r1.Text = "Найти высоту";
            r1.CheckedChanged += R1_CheckedChanged;
            Controls.Add(r1);
            r2 = new RadioButton();
            r2.Location = new Point(105, 360);
            r2.Text = "Высота есть";
            r2.CheckedChanged += R2_CheckedChanged;
            Controls.Add(r2);
            box = new PictureBox();
            box.Location = new Point(9, 340);
            box.Size = new Size(90, 90);
            box.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(box);
            lA = new Label();
            lA.Size = new Size(70, 30);
            lA.Location = new Point(10, 220);
            lA.Text = "Сторона А";
            Controls.Add(lA);
            lB = new Label();
            lB.Size = new Size(70, 30);
            lB.Location = new Point(10, 250);
            lB.Text = "Сторона B";
            Controls.Add(lB);
            lC = new Label();
            lC.Size = new Size(70, 30);
            lC.Location = new Point(10, 280);
            lC.Text = "Сторона C";
            Controls.Add(lC);
            lH = new Label();
            lH.Size = new Size(70, 30);
            lH.Location = new Point(10, 310);
            lH.Text = "Высота H";
            Controls.Add(lH);
            txtA = new TextBox();
            txtA.Location = new Point(80, 220);
            Controls.Add(txtA);
            txtB = new TextBox();
            txtB.Location = new Point(80, 250);
            Controls.Add(txtB);
            txtC = new TextBox();
            txtC.Location = new Point(80, 280);
            Controls.Add(txtC);
            txtH = new TextBox();
            txtH.Location = new Point(80, 310);
            Controls.Add(txtH);
            r1.Checked = true;
        }
        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            lH.Visible = true;
            txtH.Visible = true;
        }
        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            lH.Visible = false;
            txtH.Visible = false;
            txtH.Text = "";
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            _list.Items.Clear();
            if (r1.Checked)
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                h = 0;
            }
            else
            {
                if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtH.Text == "")
                {
                    a = 0;
                    b = 0;
                    c = 0;
                    h = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    h = Convert.ToDouble(txtH.Text);
                }
            }
            Triangle triangle = new Triangle(a, b, c, h);
            _list.Items.Add("Сторона а:" + " " + triangle.outputA());
            _list.Items.Add("Сторона b:" + " " + triangle.outputB());
            _list.Items.Add("Сторона c:" + " " + triangle.outputC());
            _list.Items.Add("Угол а:" + " " + Convert.ToString(triangle.ugolA()));
            _list.Items.Add("Угол b:" + " " + Convert.ToString(triangle.ugolB()));
            _list.Items.Add("Угол c:" + " " + Convert.ToString(triangle.ugolC()));
            if (triangle.outputH() == "0")
            {
                _list.Items.Add("Высота:" + " " + triangle.HeightOfTriangle());
            }
            else
            {
                if (triangle.ExistTriangle)
                {
                    if (triangle.outputH() != Convert.ToString(triangle.HeightOfTriangle()))
                    {
                        _list.Items.Add("Высота:" + " " + Convert.ToDouble(txtH.Text) + "(Правильная высота: " + triangle.HeightOfTriangle() + ")");
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
            _list.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
            _list.Items.Add("Полупериметр:" + " " + Convert.ToString(triangle.PoluPerimeter()));
            _list.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { _list.Items.Add("Существует?  Существует"); }
            else _list.Items.Add("Существует?  Не существует");
            _list.Items.Add("Спецификатор:" + " " + triangle.TypeOfTriangle());
            gp.Clear(Color.White);
            if (triangle.TypeOfTriangle() == "прямоугольный")
            {
                Point p1 = new Point(70, 150);
                Point p2 = new Point(155, 30);
                Point p3 = new Point(70, 30);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else if (triangle.TypeOfTriangle() == "остроугольный")
            {
                Point p1 = new Point(50, 110);
                Point p2 = new Point(150, 110);
                Point p3 = new Point(100, 20);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else if (triangle.TypeOfTriangle() == "тупоугольный")
            {
                Point p1 = new Point(100, 110);
                Point p2 = new Point(150, 110);
                Point p3 = new Point(75, 30);
                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            _list.Items.Add("Медиана:" + " " + Convert.ToString(triangle.mediana()));
            _list.Items.Add("Биссектриса:" + " " + Convert.ToString(triangle.bisectrisa()));
            _list.Items.Add("Синус угла А:" + " " + Convert.ToString(triangle.Sin()));
        }

        private void item_exit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void item_new(object sender, EventArgs e)
        {
            _list.Items.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtH.Clear();
        }
    }
}