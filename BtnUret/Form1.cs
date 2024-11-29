using System;
using System.Drawing;
using System.Windows.Forms;

namespace BtnUret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
            lblMayin.Text = "0";
        }

        private void btnUret_Click(object sender, EventArgs e)
        {


            int mayin1, mayin2, mayin3 = 0;


            Random random = new Random();
            mayin1 = random.Next(1, 20);
            mayin2 = random.Next(21, 30);
            mayin3 = random.Next(31, 50);


            for (int i = 1; i <= 50; i++) 
            { 
            
                Button button = new Button();
                button.Name = "btn"+i.ToString();
                button.Size = new System.Drawing.Size(35,35);
                button.Text = i.ToString(); 
                button.UseVisualStyleBackColor = true;  
                flowLayoutPanel1.Controls.Add(button);

                if (mayin1==i || mayin2 ==i || mayin3 ==i)
                {
                    button.Tag = true;
                }
                else
                {
                    button.Tag=false;   
                }

                button.Click += BtnTemp_Click;


            }


        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Button basilanButton = (Button)sender; 

            bool mayinBulunduMu = (bool) basilanButton.Tag;

            if (mayinBulunduMu)
            {
                MessageBox.Show("Mayını buldunuz");
                basilanButton.BackColor = Color.Red;
                int mayinInt = int.Parse(lblMayin.Text);
                mayinInt++;
                lblMayin.Text = mayinInt.ToString();
            }
            else
            {
                basilanButton .BackColor = Color.Green;
                int skorInt = int.Parse(lblSkor.Text);
                skorInt++;
                lblSkor.Text = skorInt.ToString();
            }

        }

     
    }
}
