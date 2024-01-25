using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_shopping_project
{
    public partial class Products_male : Form

    {
        private string B1selectedImageSource = "B1";
        private string B2selectedImageSource = "B2";
        private string B3selectedImageSource = "B3";
        private string B4selectedImageSource = "B4";

       
        public Products_male()
        {

            InitializeComponent();
            
            pictureBox1.MouseHover += Img4_mousehover;
            pictureBox1.MouseLeave += Img4_mouseleave;

            pictureBox2.MouseHover += Img2_mousehover;
            pictureBox2.MouseLeave += Img2_mouseleave;

            pictureBox3.MouseHover += Img3_mousehover;
            pictureBox3.MouseLeave += Img3_mouseleave;

            pictureBox4.MouseHover += img1_mousehover;
            pictureBox4.MouseLeave += img1_mouseleave;
            this.Paint += GradientForm_Paint;


        }
        private void GradientForm_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the specified gradient background
            DrawCustomGradientBackground(e.Graphics, this.ClientRectangle);
        }

        private void DrawCustomGradientBackground(Graphics g, Rectangle bounds)
        {
            Color[] gradientColors = new Color[]
            {
        Color.FromArgb(234, 234, 234), // #EAEAEA
        Color.FromArgb(219, 219, 219), // #DBDBDB
        Color.FromArgb(242, 242, 242), // #F2F2F2
        Color.FromArgb(173, 169, 150)  // #ADA996
            };

            // Create a LinearGradientBrush to draw the custom gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(bounds, gradientColors[0], gradientColors[gradientColors.Length - 1], LinearGradientMode.Horizontal))
            {
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Positions = new float[] { 0, 0.33f, 0.66f, 1 };
                colorBlend.Colors = gradientColors;

                brush.InterpolationColors = colorBlend;

                // Fill the background with the gradient brush
                g.FillRectangle(brush, bounds);
            }
        }


        private void img1_mousehover(object sender, EventArgs e)
        {
            switch (B3selectedImageSource)
            {
                case "B3":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.B3_black;
                    break;
                case "B3_green":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.B3_green;
                    break;
                case "B3_blue":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.B3_blue;
                    break;

                default:
                    break;
            }
        }
        private void img1_mouseleave(object sender, EventArgs e)
        {
            switch (B3selectedImageSource)
            {
                case "B3":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.M1_removebg_preview;
                    break;
                case "B3_green":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.m1_green;
                    break;
                case "B3_blue":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.m1_navy;
                    break;

                default:
                    break;
            }
        }
        private void Img3_mousehover(object sender, EventArgs e)
        {
            switch (B4selectedImageSource)
            {
                case "B4":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.B4_grey;
                    break;
                case "B4_white":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.B4_white;
                    break;
                case "B4_black":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.B4_black;
                    break;

                default:
                    break;
            }
        }
        private void Img3_mouseleave(object sender, EventArgs e)
        {
            switch (B4selectedImageSource)
            {
                case "B4":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.M2_removebg_preview;
                    break;
                case "B4_white":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.m2_white;
                    break;
                case "B4_black":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.m2_black;
                    break;

                default:
                    break;
            }
        }
        private void Img2_mousehover(object sender, EventArgs e)
        {
            switch (B2selectedImageSource)
            {
                case "B2":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.B1_black;
                    break;
                case "B2_green":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.B1_green;
                    break;
                case "B2_beige":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.B1_beige;
                    break;

                default:
                    break;
            }
        }
        private void Img2_mouseleave(object sender, EventArgs e)
        {
            switch (B2selectedImageSource)
            {
                case "B2":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.M3_removebg_preview;
                    break;
                case "B2_green":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.m3_army_green;
                    break;
                case "B2_beige":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.m3_khaki;
                    break;

                default:
                    break;
            }
        }
        private void Img4_mousehover(object sender, EventArgs e)
        {
            switch (B1selectedImageSource)
            {
                case "B1":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.B2_black;
                    break;
                case "B1_green":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.B2_green;
                    break;
                case "B1_grey":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.B2_grey;
                    break;

                default:
                    break;
            }
        }
        private void Img4_mouseleave(object sender, EventArgs e)
        {
            switch (B1selectedImageSource)
            {
                case "B1":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.m4_black;
                    break;
                case "B1_green":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.m4_army_green;
                    break;
                case "B1_grey":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.ة4_removebg_preview;
                    break;

                default:
                    break;
            }
        }
       

       
        private void Products_male_Load(object sender, EventArgs e)
        {
            Program.RoundControlCorners(panel1, 10);
            Program.RoundControlCorners(panel3, 10);
            Program.RoundControlCorners(panel7, 10);
            Program.RoundControlCorners(panel5, 10);
            Program.RoundControlCorners(pictureBox1, 10);
            Program.RoundControlCorners(pictureBox2, 10);
            Program.RoundControlCorners(pictureBox3, 10);
            Program.RoundControlCorners(pictureBox4, 10);


        }

        private void blacksp_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Black sweetpants       ");
            Program.Price.Add("400 LE.");


            int p2 = 400;
            Program.price += p2;



        }

        private void hoodiew_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Black NASA sweetpants             ");
            Program.Price.Add("500 LE.");
            int p3 = 500;
            Program.price += p3;
        }

        private void bejesp_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Grey hoodie        ");
            Program.Price.Add("500 LE.");
            int p3 = 500;
            Program.price += p3;
        }

        private void hoodieb_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Black hoodie              ");
            Program.Price.Add("650 LE.");
            int p4 = 650;
            Program.price += p4;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.price <1)
            {
                MessageBox.Show("Add items First","Warning",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else {shoppingcart sh = new shoppingcart();
            this.Hide();
            sh.Show(); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home CategoriePage = new Home();
            this.Hide();
            CategoriePage.Show();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       



        private void blacksp_Click_1(object sender, EventArgs e)
        {
            Program.Name.Add("Black sweetpants       ");
            Program.Price.Add("400 LE.");


            int p2 = 400;
            Program.price += p2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.m1_green;
            B3selectedImageSource = "B3_green";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.m1_navy;
            B3selectedImageSource = "B3_blue";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.M1_removebg_preview;

            B3selectedImageSource = "B3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.m2_white;
            B4selectedImageSource = "B4_white";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.m2_black;
            B4selectedImageSource = "B4_black";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.M2_removebg_preview;
            B4selectedImageSource = "B4";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.m3_army_green;
            B2selectedImageSource = "B2_green";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.M3_removebg_preview;
            B2selectedImageSource = "B2";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.m3_khaki;
            B2selectedImageSource = "B2_beige";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.m4_army_green;
            B1selectedImageSource = "B1_green";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.m4_black;
            B1selectedImageSource = "B1";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.ة4_removebg_preview;
            B1selectedImageSource = "B1_grey";
        }

        private void hoodieb_Click_1(object sender, EventArgs e)
        {
            Program.Name.Add("Black hoodie              ");
            Program.Price.Add("650 LE.");
            int p4 = 650;
            Program.price += p4;
        }

        private void hoodiew_Click_1(object sender, EventArgs e)
        {
            Program.Name.Add("Grey hoodie        ");
            Program.Price.Add("500 LE.");
            int p3 = 500;
            Program.price += p3;
        }

        private void bejesp_Click_1(object sender, EventArgs e)
        {
            Program.Name.Add("Black NASA sweetpants             ");
            Program.Price.Add("500 LE.");
            int p3 = 500;
            Program.price += p3;
        }

       
    }
}
