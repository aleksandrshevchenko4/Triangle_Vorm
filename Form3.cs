using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangle;

namespace triangl
{
    public partial class Form3 : Form
    {
        ListBox list_box;
        Button btn;
        Label lblA, lblB, lblC, lblH;
        TextBox txtA, txtB, txtC, txtH;
        PictureBox pic1, pic2, pic4, pic3;
        RadioButton r1,r2,r3;
        Graphics gp;
        CheckBox box_lbl, box_btn;
        Pen p = new Pen(Brushes.Red, 2);
        double a, b, c, h;

        public Form3()
        {


            this.Height = 700;
            this.Width = 800;
            this.Text = "Triangle";
            this.BackColor = Color.BlanchedAlmond;
           // this.Icon = new Icon("triangle.ico");
            list_box = new ListBox();
            list_box.Location = new Point(10, 10);
            list_box.Size = new Size(350, 160);
            list_box.Items.Add("Таблица с значением");
            list_box.BackColor = Color.Tan;

            btn = new Button();//кнопка запуск
            btn.Location = new Point(500, 310);
            btn.Size = new Size(110, 40);
            btn.Click += Btn_Click;
            btn.Text = "Запуск";
            btn.BackColor = Color.LightPink;
            btn.ForeColor = Color.Red;

            lblA = new Label();//label Стороны А
            lblA.Size = new Size(70, 30);
            lblA.Location = new Point(50, 180);
            lblA.Text = "Сторона А";
            lblA.ForeColor = Color.Black;
            lblA.BackColor = Color.White;

            txtA = new TextBox();//txt ящик
            txtA.Size = new Size(100, 30);
            txtA.Location = new Point(130, 180);
            txtA.BackColor = Color.SeaShell;

            lblB = new Label();//label Стороны B
            lblB.Size = new Size(70, 30);
            lblB.Location = new Point(50, 210);
            lblB.Text = "Сторона B";
            lblB.ForeColor = Color.Black;
            lblB.BackColor = Color.White;

            txtB = new TextBox();//txt ящик
            txtB.Location = new Point(130, 210);
            txtB.BackColor = Color.SeaShell;

            lblC = new Label();//label Стороны C
            lblC.Size = new Size(70, 30);
            lblC.Location = new Point(50, 240);
            lblC.Text = "Сторона C";
            lblC.ForeColor = Color.Black;
            lblC.BackColor = Color.White;

            txtC = new TextBox();//txt ящик
            txtC.Location = new Point(130, 240);
            txtC.BackColor = Color.SeaShell;

            lblH = new Label();//label Стороны H
            lblH.Size = new Size(70, 30);
            lblH.Location = new Point(50, 270);
            lblH.Text = "Высота H";
            lblH.ForeColor = Color.Black;
            lblH.BackColor = Color.White;

            txtH = new TextBox();//txt ящик
            txtH.Location = new Point(130, 270);
            txtH.BackColor = Color.SeaShell;

            //pic3 = new PictureBox();//PixBox
            //pic3.Image = Image.FromFile("tro.gif");
            //pic3.Location = new Point(410, 310);
            //pic3.Size = new Size(300, 300);
            //pic3.SizeMode = PictureBoxSizeMode.Zoom;
            //pic3.BorderStyle = BorderStyle.FixedSingle;

            r2 = new RadioButton();
            r2.Text = "Показать данные";
            r2.Location = new Point(350, 10);
            r2.CheckedChanged += new EventHandler(Radiobuttons_Changed);
            Controls.Add(r2);

            r3 = new RadioButton();
            r3.Text = "Скрыть данные";
            r3.Location = new Point(350, 30);
            r3.CheckedChanged += new EventHandler(Radiobuttons_Changed);
            Controls.Add(r3);

            pic1 = new PictureBox();//PixBox
            pic1.Image = Image.FromFile("tup.png");
            pic1.Location = new Point(10, 450);
            pic1.Size = new Size(100, 100);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.BorderStyle = BorderStyle.FixedSingle;

            pic2 = new PictureBox();//PixBox
            pic2.Image = Image.FromFile("ostr.png");
            pic2.Location = new Point(100, 450);
            pic2.Size = new Size(100, 100);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.BorderStyle = BorderStyle.FixedSingle;


            pic4 = new PictureBox();
            pic4.Image = Image.FromFile("prjam.png");
            pic4.Location = new Point(200, 450);
            pic4.Size = new Size(100, 100);
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            pic4.BorderStyle = BorderStyle.FixedSingle;


            Panel panel1 = new Panel();
            panel1.Location = new Point(410, 20);
            panel1.Size = new Size(195, 200);
            panel1.BackColor = Color.WhiteSmoke;

            gp = panel1.CreateGraphics();

            box_lbl = new CheckBox();
            box_lbl.CheckedChanged += Box_lbl_CheckedChanged;

            MainMenu menu = new MainMenu();
            BackColor = Color.White;
            ForeColor = Color.Black;

            Controls.Add(list_box);
            Controls.Add(btn);
            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(lblC);
            Controls.Add(lblH);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(txtC);
            Controls.Add(txtH);
            Controls.Add(pic1);
            Controls.Add(pic2);
            Controls.Add(pic4);
            Controls.Add(pic3);
            /*Controls.Add(radio1);
            Controls.Add(radio2);*/
            Controls.Add(panel1);
            Controls.Add(box_btn);
            Controls.Add(box_lbl);
            Controls.Add(r1);
        }


        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            list_box.Items.Clear();
            Triangl triangle = new Triangl(a, b, c, h);
            list_box.Items.Add("Сторона а:" + " " + triangle.outputA());
            list_box.Items.Add("Сторона b:" + " " + triangle.outputB());
            list_box.Items.Add("Сторона c:" + " " + triangle.outputC());
            list_box.Items.Add("Высота:" + " " + triangle.HeightOfTriangle());
            list_box.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
            list_box.Items.Add("ПолуПериметр:" + " " + Convert.ToString(triangle.HalfPerimeter()));
            list_box.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { list_box.Items.Add("Существует?  Существует"); }
            else list_box.Items.Add("Существует?  Не существует");
            list_box.Items.Add("Спецификатор:" + " " + triangle.TypeOfTriangle());
        }
        private void Radiobuttons_Changed(object sender, EventArgs e)
        {
            if (r3.Checked)
            {
                list_box.Visible = false;

            }
            if (r2.Checked)
            {
                list_box.Visible = true;
            }
        }

        private void Box_lbl_CheckedChanged(object sender, EventArgs e)
        {
            lblH.Visible = false;
            txtH.Visible = false;
        }

        private void Box_btn_CheckedChanged(object sender, EventArgs e)
        {
            lblH.Visible = true;
            txtH.Visible = true;
        }


        Random random_color = new Random();
        private void colors1(object sender, EventArgs e)
        {
            int Red = random_color.Next(0, 255);
            int Green = random_color.Next(0, 255);
            int Blue = random_color.Next(0, 255);
            this.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            btn.BackColor = Color.Transparent;
            list_box.Items.Clear();

            if (box_lbl.Checked)
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


            Triangl triangle = new Triangl(a, b, c, h);
            list_box.Items.Add("Сторона а:" + " " + triangle.outputA());
            list_box.Items.Add("Сторона b:" + " " + triangle.outputB());
            list_box.Items.Add("Сторона c:" + " " + triangle.outputC());
            if (triangle.outputH() == "0")
            {
                list_box.Items.Add("Высота:" + " " + triangle.HeightOfTriangle());
            }
            list_box.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
            list_box.Items.Add("ПолуПериметр:" + " " + Convert.ToString(triangle.HalfPerimeter()));
            list_box.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { list_box.Items.Add("Существует?  Существует"); }
            else list_box.Items.Add("Существует?  Не существует");
            list_box.Items.Add("Спецификатор:" + " " + triangle.TypeOfTriangle());
            gp.Clear(Color.White);
            if (triangle.TypeOfTriangle() == "остроугольный")
            {
                Point p1 = new Point(60, 110);
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
            else if (triangle.TypeOfTriangle() == "прямоугольный")
            {
                Point p1 = new Point(70, 160);
                Point p2 = new Point(157, 30);
                Point p3 = new Point(70, 30);

                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }

        }
    }
}
