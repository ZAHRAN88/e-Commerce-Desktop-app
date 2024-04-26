using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp3;

namespace online_shopping_project
{


    public partial class SignUp : Form
    {
        private const string regex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$";

        public static string name;
        public int price = 0;
        private void GradientForm_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the gradient background with specific colors
            DrawGradientBackground(e.Graphics, this.ClientRectangle, Color.FromArgb(5, 162, 252), Color.FromArgb(29, 122, 243));
        }

        private static void DrawGradientBackground(Graphics g, Rectangle bounds, Color startColor, Color endColor)
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


       
        public SignUp()
        {

            InitializeComponent();
            panel2.Paint += GradientForm_Paint;
            button1.Paint += GradientButton_Paint;
            username.MouseClick += remove_placeholder;
            username.MouseLeave += placeholder_back;
            password.MouseClick += removePass_placeholder;
            textBox1.MouseClick += removePassConfirm_placeholder;
            label2.MouseHover += text_blue;
            label2.MouseLeave += text_grey;



        }


        private void Login_Load(object sender, EventArgs e)
        {


            Program.RoundControlCorners(button1, 7);
           
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
        private void removePassConfirm_placeholder(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = string.Empty;
            textBox1.PasswordChar = '*';
            textBox1.MouseClick -= removePassConfirm_placeholder;

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
            // Check if password and confirm password match
            if (password.Text != textBox1.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password using regex
            if (!Regex.IsMatch(password.Text, regex))
            {
                MessageBox.Show("Password must contain at least 8 characters, including at least one uppercase letter, one lowercase letter, , one digit and a special character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save user information to a text file
            try
            {
                using (StreamWriter writer = new StreamWriter("users.txt", true)) 
                {
                    writer.WriteLine("Username: " + username.Text);
                    writer.WriteLine("Password: " + password.Text);
                    writer.WriteLine("-------------------"); // Add an empty line for separation between users
                }

                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home h =new Home();
                this.Close();
                h.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Kids k=new Kids();
            k.Show();
        }

        private void password_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();


            login.Show();

        }
        private void text_blue(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void text_grey(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkGray;
        }
    }
}
