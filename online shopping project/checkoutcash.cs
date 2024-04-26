using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_shopping_project
{
    public partial class checkoutcash : Form
    {
        public checkoutcash()
        {
            InitializeComponent();
            this.Paint += GradientForm_Paint;
            pictureBox1.Paint += GradientPic_Paint;
            button1.MouseHover += forclr;
            button1.MouseLeave += bforclr;
            Program.RoundControlCorners(pictureBox1, 10);
            Program.RoundControlCorners(panel1, 10);

        }
        //gradient background 
        private void GradientPic_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the gradient background with specific colors
            DrawGradientBackground(e.Graphics, pictureBox1.ClientRectangle, Color.FromArgb(5, 162, 252), Color.FromArgb(29, 122, 243));

            // Manually draw the text on the button
            using (var brush = new SolidBrush(button1.ForeColor))
            {
                // Center the text on the button
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;

                // Draw the text on the button
                e.Graphics.DrawString(pictureBox1.Text, pictureBox1.Font, brush, pictureBox1.ClientRectangle, sf);
            }

            // Draw the image on top of the background
            if (pictureBox1.Image != null)
            {
                e.Graphics.DrawImage(pictureBox1.Image, pictureBox1.ClientRectangle);
            }
        }
        private void RoundControlCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            control.Region = new Region(path);
        }
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
       
        private void forclr(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            

        }
        private void bforclr(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(33, 125, 228);
            

        }
        public void Show(string errorMessage)
        {
            string caption = "Order placed";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            DialogResult result = MessageBox.Show(errorMessage, caption, buttons, icon);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // make this take only numbers
                    


            if (textBox2.Text.Length != 11)
            {
                MessageBox.Show("Please Enter valid Number");

            }
            else
            {
                this.Show($"Thanks {textBox3.Text} for visiting us");
                 int orderCount = 1;

                // Generate a unique ID for the order
                string orderId = $"{DateTime.Now:yyyyMMddHHmmss}&{orderCount++}";

                // Write the order details to a file
                Program.WriteOrderToFile(orderId, textBox3.Text, textBox2.Text, textBox1.Text, "Cash");

               
                Application.Exit();
            }

        }
    }
}
