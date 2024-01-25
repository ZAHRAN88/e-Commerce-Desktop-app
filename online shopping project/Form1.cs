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

namespace online_shopping_project
{

    public partial class Login : Form
    {
        public int price = 0;
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
        private void GradientButton_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the gradient background with specific colors
            DrawGradientBackground(e.Graphics, button1.ClientRectangle, Color.FromArgb(5, 162, 252), Color.FromArgb(29, 122, 243));

            // Manually draw the text on the button
            using (var brush = new SolidBrush(button1.ForeColor))
            {
                // Center the text on the button
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;

                // Draw the text on the button
                e.Graphics.DrawString(button1.Text, button1.Font, brush, button1.ClientRectangle, sf);
            }
        }


       
        public Login()
        {

            InitializeComponent();
            panel2.Paint += GradientForm_Paint;
            button1.Paint += GradientButton_Paint;
            username.MouseClick += remove_placeholder;
            username.MouseLeave += placeholder_back;
            password.MouseClick += removePass_placeholder;
            

        }


        private void Login_Load(object sender, EventArgs e)
        {


            Program.RoundControlCorners(button1, 7);
            Program.RoundControlCorners(button5, 8);
            Program.RoundControlCorners(password, 15);
            Program.RoundControlCorners(username, 15);


        }

        

        private void password_TextChanged(object sender, EventArgs e)
        {


            password.UseSystemPasswordChar = true;
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }


        private string defaultText = "👤 Username";

        private void remove_placeholder(object sender, EventArgs e)
        {
            username.ForeColor = Color.Black;
            username.Text = string.Empty;
            username.MouseClick -= remove_placeholder;

        }

       

        private void removePass_placeholder(object sender, EventArgs e)
        {
            password.ForeColor = Color.Black;
            password.Text = string.Empty;
            password.PasswordChar = '*';
            password.MouseClick -= removePass_placeholder;

        }
        private void placeholder_back(object sender, EventArgs e)
        {
            if (username.Text ==string.Empty)
            {
                username.Text = "👤 Username";
                username.ForeColor = Color.FromArgb(203, 203, 205);
                username.MouseClick += remove_placeholder;


            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home login = new Home();
            if (username.Text == "admin" && password.Text == "admin")
            {
                this.Hide();
                login.Show();

            }
            else
            {

                MessageBox.Show("Wrong Username or Password");
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 magdy=new Form9();
            magdy.Show();
        }
    }
}
