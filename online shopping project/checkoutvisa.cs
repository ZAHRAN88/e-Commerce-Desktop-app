using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_shopping_project
{
    public partial class checkoutvisa : Form
    {
        public static string usrN ;
        public checkoutvisa()
        {
            
            InitializeComponent();
            
            textBox1.MouseClick += del1; 
            textBox2.MouseClick += del2; 
            textBox3.MouseClick += del3; 
            textBox4.MouseClick += del4; 
            textBox5.MouseClick += del5;
            textBox1.TextChanged += clr1;
            textBox2.TextChanged += clr2;
            textBox3.TextChanged += clr3;
            textBox4.TextChanged += clr4;
            textBox5.TextChanged += clr5;
            textBox4.KeyPress += TextBoxNumericOnly_KeyPress;
            textBox2.KeyPress += TextBoxNumericOnly_KeyPress;
            textBox1.KeyPress += TextBoxNumericOnly_KeyPress;
            textBox3.KeyPress += TextBoxNumericOnly_KeyPress;
            usrN = textBox5.Text;
           

        }
        private void del1(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

        }
        private void del2(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }
        private void del3(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
        }
        private void del4(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
        }
        private void del5(object sender, EventArgs e)
        {
            textBox5.Text = string.Empty;
        }
        private void clr1(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
        private void clr2(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }
        private void clr3(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
        }
        private void clr4(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Black;
        }
        private void clr5(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;
        }

        //methods
        public void GradientForm_Paint(object sender, PaintEventArgs e)
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
       
        //end of methods
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            textBox4.ForeColor = Color.FromArgb(85, 88, 91);
        }
        private void TextBoxNumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // If not a digit or control key, suppress the key press
                e.Handled = true;
            }
            if (textBox1.Text.Length >= 3 && e.KeyChar != '\b'&& textBox2.Text.Length >= 4 && textBox3.Text.Length >= 2 &&textBox4.Text.Length>=16)
            {
                // If four digits, cancel the keypress event
                e.Handled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void checkoutvisa_Load(object sender, EventArgs e)
        {
            textBox6.Text = shoppingcart.finalprice.ToString("");
            Program.RoundControlCorners(button1, 10);
            Program.RoundControlCorners(textBox1, 10);
            Program.RoundControlCorners(textBox2, 10);
            Program.RoundControlCorners(textBox3, 10);
            Program.RoundControlCorners(textBox4, 10);
            Program.RoundControlCorners(textBox5, 10);
            Program.RoundControlCorners(textBox6, 10);
            Program.RoundControlCorners(textBox6, 10);
            Program.RoundControlCorners(panel1, 10);
            this.Paint += GradientForm_Paint;



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ( textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty ||  textBox5.Text == string.Empty)
                 {
                     MessageBox.Show("Please fill out all fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                 }
            else {
                MessageBox.Show($"Thanks {textBox5.Text} for visiting us");

                int orderCount = 1;

                // Generate a unique ID for the order
                string orderId = $"{DateTime.Now:yyyyMMddHHmmss}&{orderCount++}";


                // Write the order details to a file
                Program.WriteOrderToFile(orderId, textBox5.Text, textBox7.Text, textBox8.Text, "Card");

               

                Success S = new Success();
                this.Hide();
                S.Show();

                 }
           
        }
        
       

       
    }
}
