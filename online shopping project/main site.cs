using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace online_shopping_project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.Paint += GradientForm_Paint;
            Program.RoundControlCorners(panel1, 10);
            Program.RoundControlCorners(panel2, 10);
            Program.RoundControlCorners(panel3, 10);
            Program.RoundControlCorners(panel4, 10);
            panel1.MouseClick += menCategory;
            pictureBox1.MouseClick += menCategory;
            pictureBox2.MouseClick += femaleCategory;
            panel2.MouseClick += femaleCategory;
            pictureBox4.MouseClick += kidsCategory;
            panel4.MouseClick += kidsCategory;
            panel3.MouseClick += acc_Category;
            pictureBox3.MouseClick += acc_Category;
        }


        private void GradientForm_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the gradient background with specific colors
            DrawGradientBackground(e.Graphics, this.ClientRectangle, Color.FromArgb(5, 162, 252), Color.FromArgb(29, 122, 243));
        }

        private void DrawGradientBackground(Graphics g, Rectangle bounds, Color startColor, Color endColor)
        {
            // Create a LinearGradientBrush to draw the gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(bounds, startColor, endColor, LinearGradientMode.Horizontal))
            {
                // Fill the background with the gradient brush
                g.FillRectangle(brush, bounds);
            }
        }
      


        

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

      

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Home Login = new Home();
            this.Hide();
            Login.Show();
        }

        private void menCategory(object sender, EventArgs e)
        {
            Products_male male = new Products_male();
            this.Hide();
            male.Show();
        }
        private void femaleCategory(object sender, EventArgs e)
        {
            Products_Female female = new Products_Female();
            this.Hide();
            female.Show();
        }
        private void kidsCategory(object sender, EventArgs e)
        {
            Kids kids = new Kids();
            this.Hide();
            kids.Show();
        }
        private void acc_Category(object sender, EventArgs e)
        {
            Form1 accesories = new Form1();
            this.Hide();
            accesories.Show();
        }

       
    }
}
