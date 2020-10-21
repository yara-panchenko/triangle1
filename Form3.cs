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
        Label lbl1, lbl2, lbl3, lbl4;
        TextBox box1, box2, box3, box4;
        public Form3()
        {
            this.Size = new Size(300, 450);
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
            _list.Items.Add("P:" + " " + Convert.ToString(triangle.Perimeter()));
            _list.Items.Add("S:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { _list.Items.Add("Exists"); }
            else _list.Items.Add("No Exists");
            _list.Items.Add("Тип углов:" + " " + triangle.TypeOfTriangle());
            _list.Items.Add("Тип треугольника по сторонам:" + " " + triangle.TriangleType());
            _list.Items.Add("M:" + " " + Convert.ToString(triangle.med()));
            _list.Items.Add("Bis:" + " " + Convert.ToString(triangle.bis()));
        }
    }
}
