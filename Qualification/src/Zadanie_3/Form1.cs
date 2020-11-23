using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3
{
    public partial class Form1 : Form
    {
        TextBox x_box = new TextBox();
        TextBox y_box = new TextBox();
        Button calculate_button = new Button();
        Label x_label = new Label();
        Label y_label = new Label();
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Show_controls()
        {
            this.Height = 200;
            this.Width = 200;
            x_label.Parent = this;
            x_label.Text = "Координата x: ";
            x_label.Location = new Point(0, 30);
            x_box.Parent = this;
            x_box.Size = new Size(20, 20);
            x_box.Location = new Point(100, 30);
            y_label.Parent = this;
            y_label.Text = "Координата y: ";
            y_label.Location = new Point(0, 70);
            y_box.Parent = this;
            y_box.Size = new Size(20, 20);
            y_box.Location = new Point(100, 70);
            calculate_button.Parent = this;
            calculate_button.Size = new Size(100, 30);
            calculate_button.Location = new Point(25, 120);
            calculate_button.Text = "Проверить";
            calculate_button.Click += Calculate_button_Click;
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(y_box.Text);
                double x = Convert.ToDouble(x_box.Text);
                if (flag)
                {
                    if ((y <= 1 && x <= 1 && x >= -1 && y >= -1))
                    {
                        if(y == 1 && x== 1)
                        {
                            Status.Text = "На границе";
                        }
                        else
                            Status.Text = "Принадлежит";
                    }
                    else Status.Text = "Не принадлежит";
                }
                else
                {

                    Status.Text = "Нажат второй вариант";
                }
            }
            catch (Exception ex)
            {
                Status.Text = ex.Message;
            }
        }

        private void сайт1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Denis\Desktop\Qualification\src\web\web1.html");
            flag = true;
            Show_controls();
        }

        private void сайт2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Denis\Desktop\Qualification\src\web\web2.html");
            flag = false;
            Show_controls();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор работы : Коркишко Д. А. Пкспк-217 Вариант №8");
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
