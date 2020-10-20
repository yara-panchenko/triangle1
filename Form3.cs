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
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, h;
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
            triangleForm triangleForm = new triangleForm(a, b, c, h);
            valuesList.Items.Add("Спецификатор");
            valuesList.Items.Add("Сторона A");
            valuesList.Items.Add("Сторона B");
            valuesList.Items.Add("Сторона C");
            valuesList.Items.Add("Высота");
            valuesList.Items.Add("Площадь");
            if (a != 0 || b != 0 || c != 0 || h != 0)
            {
                valuesList.Items[1].SubItems.Add(triangleForm.outputA());
                valuesList.Items[2].SubItems.Add(triangleForm.outputB());
                valuesList.Items[3].SubItems.Add(triangleForm.outputC());
                valuesList.Items[4].SubItems.Add(triangleForm.outputH());
            }
            valuesList.Items[0].SubItems.Add(triangleForm.TypeOfTriangle());
            //valuesList.Items[1].SubItems.Add(triangleForm.outputA());
            //valuesList.Items[2].SubItems.Add(triangleForm.outputB());
            //valuesList.Items[3].SubItems.Add(triangleForm.outputC());
            //valuesList.Items[4].SubItems.Add(triangleForm.outputH());
            valuesList.Items[5].SubItems.Add(Convert.ToString(triangleForm.AreaOfTriangle()));
        }
    }
}
