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
    public partial class Form4 : Form
    {
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 2);
        Button btn1, btn2, btn3, btn4, btn5, btn6;
        Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        Panel panel;
        public Form4()
        {
            InitializeComponent();
            lbl1 = new Label();
            lbl1.Size = new Size(90, 30);
            lbl1.Location = new Point(60, 80);
            lbl1.Text = "Остроугольный";
            Controls.Add(lbl1);
            lbl2 = new Label();
            lbl2.Size = new Size(90, 30);
            lbl2.Location = new Point(220,80);
            lbl2.Text = "Тупоугольный";
            Controls.Add(lbl2);
            lbl3 = new Label();
            lbl3.Size = new Size(90, 30);
            lbl3.Location = new Point(310, 80);
            lbl3.Text = "Прямоугольный";
            Controls.Add(lbl3);
            lbl4 = new Label();
            lbl4.Size = new Size(90, 30);
            lbl4.Location = new Point(60, 230);
            lbl4.Text = "Разносторонний";
            Controls.Add(lbl4);
            lbl5 = new Label();
            lbl5.Size = new Size(90, 30);
            lbl5.Location = new Point(220, 230);
            lbl5.Text = "Равнобедренный";
            Controls.Add(lbl5);
            lbl6 = new Label();
            lbl6.Size = new Size(90, 30);
            lbl6.Location = new Point(310, 230);
            lbl6.Text = "Равносторонний";
            Controls.Add(lbl6);
            btn1 = new Button();
            btn1.Location = new Point(10, 390);
            btn1.Size = new Size(85, 55);
            btn1.Click += Btn1_Click;
            btn1.Text = "Нарисовать остроугольный";
            Controls.Add(btn1);
            btn2 = new Button();
            btn2.Location = new Point(100, 390);
            btn2.Size = new Size(85, 55);
            btn2.Click += Btn2_Click;
            btn2.Text = "Нарисовать тупоугольный";
            Controls.Add(btn2);
            btn3 = new Button();
            btn3.Location = new Point(190, 390);
            btn3.Size = new Size(85, 55);
            btn3.Click += Btn3_Click;
            btn3.Text = "Нарисовать прямоугольный";
            Controls.Add(btn3);
            btn4 = new Button();
            btn4.Location = new Point(280, 390);
            btn4.Size = new Size(85, 55);
            btn4.Click += Btn4_Click;
            btn4.Text = "Нарисовать разносторонний";
            Controls.Add(btn4);
            btn5 = new Button();
            btn5.Location = new Point(370, 390);
            btn5.Size = new Size(85, 55);
            btn5.Click += Btn5_Click;
            btn5.Text = "Нарисовать равнобедренный";
            Controls.Add(btn5);
            btn6 = new Button();
            btn6.Location = new Point(460, 390);
            btn6.Size = new Size(85, 55);
            btn6.Click += Btn6_Click;
            btn6.Text = "Нарисовать равносторонний";
            Controls.Add(btn6);
            panel = new Panel();
            panel.Location = new Point(12, 12);
            panel.Name = "panel1";
            panel.Size = new Size(565, 585);
            panel.TabIndex = 13;
            Controls.Add(panel);
            gp = panel.CreateGraphics();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(5, 5);
            Point p2 = new Point(150, 5);
            Point p3 = new Point(75, 30);
            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(85, 5);
            Point p2 = new Point(120, 60);
            Point p3 = new Point(150, 60);
            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(5, 5);
            Point p2 = new Point(150, 5);
            Point p3 = new Point(75, 30);
            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(305, 5);
            Point p2 = new Point(305, 60);
            Point p3 = new Point(375, 60);
            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(185, 5);
            Point p2 = new Point(220, 60);
            Point p3 = new Point(280, 60);
            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(5, 60);
            Point p2 = new Point(150, 60);
            Point p3 = new Point(55, 5);
            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }
    }
}
