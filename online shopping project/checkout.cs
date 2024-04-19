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
    public partial class checkout : Form
    {
        public  void Show(string errorMessage)
        {
            string caption = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            DialogResult result = MessageBox.Show(errorMessage, caption, buttons, icon);

            if (result == DialogResult.OK)
            {
                // Implement any additional logic upon closing the error message box
            }
        }
        public static string paymentMethod;
        public checkout()
        {
            InitializeComponent();
            panel1.MouseClick += visaClicked;
            panel2.MouseClick += cashClicked;
        }
        private void visaClicked(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(213, 235, 211);
            paymentMethod = "visa";
            panel2.MouseClick -=  cashClicked;
        }
        private void cashClicked(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(213, 235, 211);
            paymentMethod = "cash";
            panel1.MouseClick -= visaClicked;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        
        private void checkout_Load(object sender, EventArgs e)
        {
            //RoundControlCorners(VisaRadio, 20);
            //RoundControlCorners(cashRadio, 20);
            Program.RoundControlCorners(panel1, 10);
            Program.RoundControlCorners(panel2, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (paymentMethod=="cash")
            {
                checkoutcash cash = new checkoutcash();
                this.Hide();
                cash.Show();
            }
            else if (paymentMethod == "visa")
            {
                checkoutvisa visa = new checkoutvisa();
                this.Hide();
                visa.Show();
            }
            else
                
            this.Show("Please Choose Payment Method");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            shoppingcart cart = new shoppingcart();
            cart.Show();
        }
    }



}
