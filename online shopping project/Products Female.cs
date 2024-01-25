using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace online_shopping_project
{
    public partial class Products_Female : Form
    {
        private string w1selectedImageSource = "W1";
        private string w2selectedImageSource = "W2";
        private string w3selectedImageSource = "W3";
        private string w4selectedImageSource = "W4";
        private void GradientForm_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the specified gradient background
            DrawCustomGradientBackground(e.Graphics, this.ClientRectangle);
        }

        private void DrawCustomGradientBackground(Graphics g, Rectangle bounds)
        {
            Color[] gradientColors = new Color[]
            {
        Color.FromArgb(218, 179, 210), // #DAB3D2
        Color.FromArgb(232, 193, 225), // #E8C1E1
        Color.FromArgb(220, 169, 223), // #DCA9DF
        Color.FromArgb(191, 129, 204), // #BF81CC
        Color.FromArgb(179, 105, 200)  // #B369C8
            };

            // Create a LinearGradientBrush to draw the custom gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(bounds, gradientColors[0], gradientColors[gradientColors.Length - 1], LinearGradientMode.Horizontal))
            {
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Positions = new float[] { 0, 0.25f, 0.5f, 0.75f, 1 };
                colorBlend.Colors = gradientColors;

                brush.InterpolationColors = colorBlend;

                // Fill the background with the gradient brush
                g.FillRectangle(brush, bounds);
            }
        }

        public Products_Female()
        {
            InitializeComponent();
            pictureBox4.MouseHover += pic1_mousehover;
            pictureBox4.MouseLeave += pic1_mouseleave;
            pictureBox1.MouseHover += pic2_mousehover;
            pictureBox1.MouseLeave += pic2_mouseleave;
            pictureBox2.MouseHover += pic3_mousehover;
            pictureBox2.MouseLeave += pic3_mouseleave;
            pictureBox3.MouseHover += pic4_mousehover;
            pictureBox3.MouseLeave += pic4_mouseleave;
            this.Paint += GradientForm_Paint;
        }
        private void pic1_mousehover(object sender, EventArgs e)
        {
            switch (w1selectedImageSource)
            {
                case "W1":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.img2blac_;
                    break;
                case "img1gray":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.img2gray;
                    break;
                case "wpink":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.pink21;
                    break;

                default:
                    break;
            }
        }
        private void pic1_mouseleave(object sender, EventArgs e)
        {
            switch (w1selectedImageSource)
            {
                case "W1":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.img1black;
                    break;
                case "img1gray":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.img1gray;
                    break;
                case "wpink":
                    this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.pink1;
                    break;

                default:
                    break;
            }
        }
        private void pic2_mousehover(object sender, EventArgs e)
        {
            switch (w2selectedImageSource)
            {
                case "W2":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wpink2;
                    break;
                case "wblue":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wblue2;
                    break;
                case "wblack":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wblack2;
                    break;

                default:
                    break;
            }
        }
        private void pic2_mouseleave(object sender, EventArgs e)
        {
            switch (w2selectedImageSource)
            {
                case "W2":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wpink1;
                    break;
                case "wblue":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wblue1;
                    break;
                case "wblack":
                    this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wblack1;
                    break;

                default:
                    break;
            }
        }
        private void pic3_mousehover(object sender, EventArgs e)
        {
            switch (w3selectedImageSource)
            {
                case "W3":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hblue2;
                    break;
                case "hgold":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hgold2;
                    break;
                case "hblack":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hblack2;
                    break;

                default:
                    break;
            }
        }
        private void pic3_mouseleave(object sender, EventArgs e)
        {
            switch (w3selectedImageSource)
            {
                case "W3":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hblue1;
                    break;
                case "hgold":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hgold1;
                    break;
                case "hblack":
                    this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hblack1;
                    break;

                default:
                    break;
            }
        }
        private void pic4_mousehover(object sender, EventArgs e)
        {
            switch (w4selectedImageSource)
            {
                case "W4":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bblack2;
                    break;
                case "bblue":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bblue2;
                    break;
                case "bwhite":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bwhite2;
                    break;

                default:
                    break;
            }
        }
        private void pic4_mouseleave(object sender, EventArgs e)
        {
            switch (w4selectedImageSource)
            {
                case "W4":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bblack1;
                    break;
                case "bblue":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bblue1;
                    break;
                case "bwhite":
                    this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bwhite1;
                    break;

                default:
                    break;
            }
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.price < 1)
            {
                MessageBox.Show("Add items First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                shoppingcart sh = new shoppingcart();
                this.Hide();
                sh.Show();
            }
        }

        private void Products_Female_Load(object sender, EventArgs e)
        {
            Program.RoundControlCorners(pictureBox4, 10);
            Program.RoundControlCorners(panel7, 10);
            Program.RoundControlCorners(panel5, 10);
            Program.RoundControlCorners(pictureBox3, 10);
            Program.RoundControlCorners(panel3, 10);
            Program.RoundControlCorners(pictureBox2, 10);
            Program.RoundControlCorners(panel1, 10);
            Program.RoundControlCorners(pictureBox1, 10);
            //RoundControlCorners(LUNE, 5);
            //RoundControlCorners(thermalhodie, 5);
            //RoundControlCorners(sp, 5);
            //RoundControlCorners(thermalst, 5);
            //RoundControlCorners(button1, 5);
            //RoundControlCorners(button2, 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home CategoriePage = new Home();
            this.Hide();
            CategoriePage.Show();
        }

       

        private void thermalhodie_Click(object sender, EventArgs e)
        {
            Program.Name.Add(" Pocket Drawstring Thermal Hoodie\t");
            Program.Price.Add("400 LE.");
            int p6 = 400;
            Program.price += p6;
        }

        

        private void thermalst_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Thermal Lined Sweatshirt\t");
            Program.Price.Add("850 LE.");
            int p8 = 850;
            Program.price += p8;
        }

        private void sp_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Butterfly Print  Sweatpants\t");
            Program.Price.Add("500 LE.");
            int p7 = 500;
            Program.price += p7;
        }

        private void LUNE_Click(object sender, EventArgs e)
        {
            Program.Name.Add("LUNE Heart Drawstring Hoodie\t");
            Program.Price.Add("500 LE.");
            int p5 = 500;
            Program.price += p5;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.img1black;
            w1selectedImageSource = "W1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.img1gray1;
            w1selectedImageSource = "img1gray";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Image = global::online_shopping_project.Properties.Resources.pink1;
            w1selectedImageSource = "wpink";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wpink1;
            w2selectedImageSource = "W2";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wblue1;
            w2selectedImageSource = "wblue";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::online_shopping_project.Properties.Resources.wblack1;
            w2selectedImageSource = "wblack";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hblue1;
            w3selectedImageSource = "W3";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hgold1;
            w3selectedImageSource = "hgold";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::online_shopping_project.Properties.Resources.hblack1;
            w3selectedImageSource = "hblack";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bblack1;
            w4selectedImageSource = "W4";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bblue1;
            w4selectedImageSource = "bblue";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Image = global::online_shopping_project.Properties.Resources.bwhite1;
            w4selectedImageSource = "bwhite";
        }

        
    }
}
