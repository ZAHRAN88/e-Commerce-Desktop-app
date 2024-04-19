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
    public partial class AdminPanel : Form
    {
        DataTable ordersTable= new DataTable();
       

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.ToLower(); 
            DataView dv = ordersTable.DefaultView;
            dv.RowFilter = $"[Order ID] LIKE '%{searchTerm}%' OR [Customer Name] LIKE '%{searchTerm}%' OR [Phone Number] LIKE '%{searchTerm}%' OR [Shipping Address] LIKE '%{searchTerm}%' OR [Total Price] LIKE '%{searchTerm}%'";
            dataGridView1.DataSource = dv.ToTable();
        }
        public AdminPanel()
        {
           
            InitializeComponent();
            dataGridView1.CellDoubleClick += Order_Details;
            Program.RoundControlCorners(dataGridView1, 10);
            button1.Click += SearchButton_Click;
            this.Paint += GradientForm_Paint;
            DisplayOrdersFromFile("orders.txt");
        }
        private void ResizeDataGridView()
        {
            // Calculate the total available height
            int totalHeight = dataGridView1.RowHeadersVisible ? dataGridView1.Height - dataGridView1.RowHeadersWidth : dataGridView1.Height;

            // Calculate the height of each row
            int rowHeight = totalHeight / dataGridView1.Rows.Count;

            // Set the height of each row
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private void GradientForm_Paint(object sender, PaintEventArgs e)
        {
            // Call a method to draw the gradient background with specific colors
            DrawGradientBackground(e.Graphics, this.ClientRectangle, Color.FromArgb(5, 162, 252), Color.FromArgb(29, 122, 243));
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResizeDataGridView();



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

        private void Order_Details(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve the selected order details from the DataTable
            string orderId = dataGridView1.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
            string customerName = dataGridView1.Rows[e.RowIndex].Cells["Customer Name"].Value.ToString();
            string phoneNumber = dataGridView1.Rows[e.RowIndex].Cells["Phone Number"].Value.ToString();
            string shippingAddress = dataGridView1.Rows[e.RowIndex].Cells["Shipping Address"].Value.ToString();
            string totalPrice = dataGridView1.Rows[e.RowIndex].Cells["Total Price"].Value.ToString();

            // Retrieve the products for the selected order from the dictionary
            List<string> products = orderProducts[orderId];

            // Construct message with order details and products
            StringBuilder message = new StringBuilder();
            message.AppendLine("Order ID: " + orderId);
            message.AppendLine("Customer Name: " + customerName);
            message.AppendLine("Phone Number: " + phoneNumber);
            message.AppendLine("Shipping Address: " + shippingAddress);
            message.AppendLine("Products:");
            foreach (string product in products)
            {
                message.AppendLine(product);
            }
            message.AppendLine("Total Price: " + totalPrice);

            // Display order details in a message box
            MessageBox.Show(message.ToString(), "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private Dictionary<string, List<string>> orderProducts = new Dictionary<string, List<string>>();

        private void DisplayOrdersFromFile(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found: " + filePath);
                return;
            }

       
            string[] lines = File.ReadAllLines(filePath);

         
            ordersTable = new DataTable();
            ordersTable.Columns.Add("Order ID");
            ordersTable.Columns.Add("Customer Name");
            ordersTable.Columns.Add("Phone Number");
            ordersTable.Columns.Add("Shipping Address");
            ordersTable.Columns.Add("Payment Method");
            ordersTable.Columns.Add("Total Price");

           
            string orderId = "";
            string customerName = "";
            string phoneNumber = "";
            string shippingAddress = "";
            string paymentMethod = "";
            decimal totalPrice = 0;
            List<string> products = new List<string>();

            // Loop through each line in the file
            foreach (string line in lines)
            {
                // Check if the line contains Order ID information
                if (line.StartsWith("Order ID:"))
                {
                    // If not first order, add previous order to the DataTable
                    if (!string.IsNullOrEmpty(orderId))
                    {
                        ordersTable.Rows.Add(orderId, customerName, phoneNumber, shippingAddress,paymentMethod, totalPrice.ToString("C")); 
                        orderProducts.Add(orderId, products); 
                    }


                    // Reset variables for new order
                    orderId = line.Substring("Order ID: ".Length).Trim();
                    customerName = "";
                    phoneNumber = "";
                    shippingAddress = "";
                    paymentMethod = "";
                    totalPrice = 0;
                    products = new List<string>();
                }
                else if (line.StartsWith("Customer Name:"))
                {
                    customerName = line.Substring("Customer Name: ".Length).Trim();
                }
                else if (line.StartsWith("Phone Number:"))
                {
                    phoneNumber = line.Substring("Phone Number: ".Length).Trim();
                }
                else if (line.StartsWith("Shipping Address:"))
                {
                    shippingAddress = line.Substring("Shipping Address: ".Length).Trim();
                }
                else if (line.StartsWith("Payment:"))
                {
                    paymentMethod = line.Substring("Payment: ".Length).Trim();
                }
                else if (line.StartsWith("Total Price:"))
                {
                    totalPrice = decimal.Parse(line.Substring("Total Price: ".Length).Trim());
                }
                else if (line.StartsWith("-"))
                {
                    // Skip lines with dashes
                    continue;
                }
                else if (!string.IsNullOrWhiteSpace(line))
                {
                    // Add product line to the products list
                    products.Add(line.Trim());
                }
            }

            // Add the last order in the file to the DataTable and the dictionary
            if (!string.IsNullOrEmpty(orderId))
            {
                ordersTable.Rows.Add(orderId, customerName, phoneNumber, shippingAddress, paymentMethod, totalPrice.ToString("C")); // Add last order to DataTable
                orderProducts.Add(orderId, products); // Add last order products to dictionary
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = ordersTable;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
          
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
