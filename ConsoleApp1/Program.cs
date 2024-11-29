using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleApp1
{
    internal class Program
    {
        //Control
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = 500;
            form.Height = 500;
            form.Text = "Merhaba Desktop";
            form.BackColor = Color.AliceBlue;
            form.Resize += Form_Resize;

            Button button = new Button();
            button.Width = 150;
            button.Height = 150;
            button.Text = "Merhaba Sınıf";
            button.Location = new Point(150, 150);


            TextBox textBox = new TextBox();
            textBox.Click += Form_Resize;
            button.Click += Form_Resize;
            form.Controls.Add(textBox);
            form.Controls.Add(button);
            textBox.Location = new Point(150, 50);

            form.ShowDialog();
            
        }

        private static void Form_Resize(object sender, EventArgs e)
        {

            Form f = null;

            if (sender is Button)
            {
                Button b = (Button)sender;
                b.BackColor = Color.White;
            }

            if (sender is TextBox)
            {
                TextBox txt = (TextBox)sender;
                txt.Text = "Object Sender";
            }

            else if (sender is Form)
            {
                f = (Form)sender;
                Random random = new Random();
                int r = random.Next(0, 255);
                int g = random.Next(0, 255);
                int b = random.Next(0, 255);
                f.BackColor = Color.FromArgb(r, g, b);
            }
        }


        //private static void Button_Click(object sender, EventArgs e)
        //{
        //    Button b = (Button)sender;
        //    b.Text = "Hello";
        //    MessageBox.Show("Merhaba Sınıf");
        //}
    }
}
