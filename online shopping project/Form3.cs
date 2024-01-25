using online_shopping_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Kids : Form
    {
        private string k1selectedImageSource = "k1";
        private string k2selectedImageSource = "k2";
        private string k3selectedImageSource = "k3";
       
        public Kids()
        {
            InitializeComponent();
            pictureBox3.MouseHover += img1_mousehover;
            pictureBox3.MouseLeave += img1_mouseleave;
            pictureBox4.MouseHover += img2_mousehover;
            pictureBox4.MouseLeave += img2_mouseleave;
            pictureBox2.MouseHover += img3_mousehover;
            pictureBox2.MouseLeave += img3_mouseleave;
            this.Paint += GradientForm_Paint;


        }

        //gradientbg
        private void GradientForm_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the specified gradient background
            DrawCustomGradientBackground(e.Graphics, this.ClientRectangle);
        }

        private void DrawCustomGradientBackground(Graphics g, Rectangle bounds)
        {
            Color[] gradientColors = new Color[]
            {
        Color.FromArgb(242, 201, 76), // #F2C94C
        Color.FromArgb(242, 153, 74)  // #F2994A
            };

            // Create a LinearGradientBrush to draw the custom gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(bounds, gradientColors[0], gradientColors[gradientColors.Length - 1], LinearGradientMode.Horizontal))
            {
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Positions = new float[] { 0, 1 };
                colorBlend.Colors = gradientColors;

                brush.InterpolationColors = colorBlend;

                // Fill the background with the gradient brush
                g.FillRectangle(brush, bounds);
            }
        }
        // Hover functions

        // Picture box 3
        private void img1_mousehover(object sender, EventArgs e)
        {
            switch (k1selectedImageSource)
            {
                case "k1" : this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1back;
                    break;
                case "k1black":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1bb;
                    break;
                case "k1g":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1gback;
                    break;
                
                default:
                    break;
            }
        }
        private void img1_mouseleave(object sender, EventArgs e)
        {
            switch (k1selectedImageSource)
            {
                case "k1":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1;
                    break;
                case "k1black":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1black;
                    break;
                case "k1g":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1g;
                    break;

                default:
                    break;
            }
        }
        //end of picB 3


        // Picture box 4
        private void img2_mousehover(object sender, EventArgs e)
        {
            switch (k2selectedImageSource)
            {
                case "k2":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.k2b;
                    break;
               
                  default:
                    break;
            }
        }
        private void img2_mouseleave(object sender, EventArgs e)
        {
            switch (k2selectedImageSource)
            {
                case "k2":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.k2;
                    break;
               default:
                    break;
            }
        }
        //end of picB 4

        // Picture box 3
        private void img3_mousehover(object sender, EventArgs e)
        {
            switch (k3selectedImageSource)
            {
                case "k3":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3b;
                    break;
                case "k3beige":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3beigeback;
                    break;
                case "k3purble":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3purbleback;
                    break;

                default:
                    break;
            }
        }
        private void img3_mouseleave(object sender, EventArgs e)
        {
            switch (k3selectedImageSource)
            {
                case "k3":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3;
                    break;
                case "k3beige":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3beige;
                    break;
                case "k3purble":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3purble;
                    break;

                default:
                    break;
            }
        }
        //end of picB 3
       

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.k4b;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.RoundControlCorners(panel1, 10);
            Program.RoundControlCorners(panel2, 10);
            Program.RoundControlCorners(panel3, 10);
            Program.RoundControlCorners(panel4, 10);
            Program.RoundControlCorners(pictureBox3, 10);
            Program.RoundControlCorners(pictureBox2, 10);
            Program.RoundControlCorners(pictureBox1, 10);
            Program.RoundControlCorners(pictureBox4, 10);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1;
            k1selectedImageSource = "k1";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1black;
            k1selectedImageSource = "k1black";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.k1g;
            k1selectedImageSource = "k1g";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.k2red;
            k2selectedImageSource = "k2red";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.k2;
            k2selectedImageSource = "k2";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3;
            k3selectedImageSource = "k3";
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3beige;
            k3selectedImageSource = "k3beige";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.k3purble;
            k3selectedImageSource = "k3purble";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.k4;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.k4blue;
        }

       private void button6_Click(object sender, EventArgs e)
        {
            if (Program.price < 1)
            {
                MessageBox.Show("Add items First");
            }
            else
            {
                shoppingcart sh = new shoppingcart();
                this.Hide();
                sh.Show();
            }


        } 
        private void button3_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Spider Printed Hoodie             ");
            Program.Price.Add("650 LE.");
            int p4 = 650;
            Program.price += p4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Fruit Pom Pom Sweater             ");
            Program.Price.Add("800 LE.");
            int p8 = 800;
            Program.price += p8;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Fruit Pom Pom Sweater             ");
            Program.Price.Add("550 LE.");
            int p8 = 550;
            Program.price += p8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Fruit Pom Pom Sweater             ");
            Program.Price.Add("780 LE.");
            int p8 = 780;
            Program.price += p8;
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Home CategoriePage = new Home();
            this.Hide();
            CategoriePage.Show();
        }
    }
}
