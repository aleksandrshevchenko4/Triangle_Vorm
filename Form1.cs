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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (txtA.Text == "" && txtB.Text == "" && txtC.Text == "")
            {
                a = 0;
                b = 0;
                c = 0;
            }
            else
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
            }
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона а");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Высота  h");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Полупериметр");
            listView1.Items.Add("Существует?");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SemiPerimeter()));
            if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
            else listView1.Items[6].SubItems.Add("Не существует");
            listView1.Items[7].SubItems.Add(triangle.TriangleType());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Run_button_DoubleClick(object sender, MouseEventArgs e)
        {
            Form2 from = new Form2();
            from.Show();
        }
    }
}