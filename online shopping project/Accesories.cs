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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace online_shopping_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += GradientForm_Paint;
            Program.RoundControlCorners(hat, 10);
            Program.RoundControlCorners(wallet, 10);
            Program.RoundControlCorners(watch, 10);
            Program.RoundControlCorners(bracelet, 10);
            Program.RoundControlCorners(panel1, 10);
            Program.RoundControlCorners(panel2, 10);
            Program.RoundControlCorners(panel3, 10);
            Program.RoundControlCorners(panel4, 10);
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
              Color.FromArgb(253, 252, 251), // #D3CBB8
              Color.FromArgb(226, 209, 195)    // #6D6027
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


        private void button1_Click(object sender, EventArgs e)
        {
            watch.Image = global::online_shopping_project.Properties.Resources.blackwatch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            watch.Image = global::online_shopping_project.Properties.Resources.brownwatch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            watch.Image = global::online_shopping_project.Properties.Resources.bluewatch;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            wallet.Image = global::online_shopping_project.Properties.Resources.black_wallet_removebg_preview;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            wallet.Image = global::online_shopping_project.Properties.Resources.NH4014PN_J37_24_removebg_preview;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            wallet.Image = global::online_shopping_project.Properties.Resources.NH1115FG028_1_900x_removebg_preview;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bracelet.Image = global::online_shopping_project.Properties.Resources.black_breclet_removebg_preview;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bracelet.Image = global::online_shopping_project.Properties.Resources.brown_breclet_removebg_preview;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bracelet.Image = global::online_shopping_project.Properties.Resources.white_breclet_removebg_preview;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hat.Image = global::online_shopping_project.Properties.Resources.black_hat_removebg_preview;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hat.Image = global::online_shopping_project.Properties.Resources.bage_hat_removebg_preview;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hat.Image = global::online_shopping_project.Properties.Resources.red_hat_removebg_preview;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            hat.Image = global::online_shopping_project.Properties.Resources.blue_hat_removebg_preview;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Polo Hat              ");
            Program.Price.Add("100 LE.");
            int p4 = 100;
            Program.price += p4;
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

        private void button12_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Barcelet              ");
            Program.Price.Add("50 LE.");
            int p4 = 50;
            Program.price += p4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Lacoste Wallet              ");
            Program.Price.Add("250 LE.");
            int p4 = 250;
            Program.price += p4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Name.Add("Classic Watch              ");
            Program.Price.Add("400 LE.");
            int p4 = 400;
            Program.price += p4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home catg = new Home();
            this.Close();
            catg.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
