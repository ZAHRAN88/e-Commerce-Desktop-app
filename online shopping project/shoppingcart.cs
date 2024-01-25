using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace online_shopping_project
{
    public partial class shoppingcart : Form
    {
        public string promocode = "ZAHRAN";
        public int shipingval = 200;
        public int promodiscount = 300;
        public double finalprice;
        public int originalcost = Program.price;

        public double updateprice()
        {
            if (chkpromo())
            {
                finalprice = originalcost - promodiscount + shipingval;
                return finalprice;
            }
            else
            {
                MessageBox.Show("Promo Code not valid or expired");
                return finalprice;
            }
        }

        public bool chkpromo()
        {
            return promotext.Text == "ZAHRAN";
        }

        public shoppingcart()
        {
            InitializeComponent();
            Program.RoundControlCorners(panel1, 10);
            Program.RoundControlCorners(panel3, 10);
            Program.RoundControlCorners(listBoxProducts, 10);
            this.Paint += GradientForm_Paint;
        }

        // gradient bg
        private void GradientForm_Paint(object sender, PaintEventArgs e)
        {
            DrawGradientBackground(e.Graphics, this.ClientRectangle, Color.FromArgb(5, 162, 252), Color.FromArgb(29, 122, 243));
        }

        private void DrawGradientBackground(Graphics g, Rectangle bounds, Color startColor, Color endColor)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(bounds, startColor, endColor, LinearGradientMode.Horizontal))
            {
                g.FillRectangle(brush, bounds);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkout check = new checkout();
            this.Hide();
            check.Show();
        }

        private void shoppingcart_Load(object sender, EventArgs e)
        {
            finalprice = originalcost + shipingval;

            // Add items to the ListBox
            for (int i = 0; i < Program.Name.Count; i++)
            {
                string productRow = $"{Program.Name[i],-30} {Program.Price[i],-10:C}";
                listBoxProducts.Items.Add(productRow);
            }

            label6.Text = finalprice.ToString();
            label1.Text = Program.price.ToString();
        }

        private void listBoxProducts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                // Draw the text
                e.Graphics.DrawString(listBoxProducts.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);

                // Draw the delete icon (🗑️)
                const int iconSize = 20;
                Font deleteIconFont = new Font("Segoe UI Emoji", 12); // Change the font size if needed
                e.Graphics.DrawString("🗑️", deleteIconFont, Brushes.Red, e.Bounds.Right - iconSize, e.Bounds.Top + (e.Bounds.Height - iconSize) / 2);

                e.DrawFocusRectangle();
            }
        }

        private void listBoxProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxProducts.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                // Get the selected index and delete the corresponding product
                DeleteProduct(index);

                // Recalculate the total price
                UpdateTotalPrice();
            }
        }

        private void DeleteProduct(int index)
        {
            if (index >= 0 && index < Program.Name.Count)
            {
                Program.Name.RemoveAt(index);
                Program.Price.RemoveAt(index);

                // Remove the item from the ListBox
                listBoxProducts.Items.RemoveAt(index);
            }
        }

        private void UpdateTotalPrice()
        {
            finalprice = originalcost + shipingval;

            // Recalculate the total price based on the remaining products
            foreach (var item in listBoxProducts.Items)
            {
                if (item is string labelText)
                {
                    // Find the index of the last space in the label text
                    int lastSpaceIndex = labelText.LastIndexOf(' ');

                    // Check if a space is found
                    if (lastSpaceIndex >= 0)
                    {
                        // Extract the price part starting from the last space
                        string pricePart = labelText.Substring(lastSpaceIndex + 1);

                        // Parse the price
                        if (double.TryParse(pricePart, out double price))
                        {
                            finalprice += price;
                        }
                    }
                }
            }

            label6.Text = finalprice.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chkpromo();
            updateprice();
            label6.Text = updateprice().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
