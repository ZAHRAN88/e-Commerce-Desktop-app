using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using System.IO;

namespace online_shopping_project
{
    internal static class Program
    {
        public static string u;
        public static string p;
        public static int price;
        public static List<string> Name = new List<string>();
        public static List<string> Price = new List<string>();
        public static void RoundControlCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            control.Region = new Region(path);
        }



        #region WriteOrderToFile

        public static void WriteOrderToFile( string orderId, string customerName, string phoneNumber, string shippingAddress, string paymentMethod)
        {
            using (StreamWriter file = new StreamWriter("orders.txt", true))
            {
                file.WriteLine($"Order ID: {orderId}");
                file.WriteLine($"Customer Name: {customerName}");
                file.WriteLine($"Phone Number: {phoneNumber}");
                file.WriteLine($"Shipping Address: {shippingAddress}");
                file.WriteLine($"Payment: {paymentMethod}");
                file.WriteLine("------------Products-------------");

                // Write order details to the file
                foreach (var item in shoppingcart.products.Items)
                {
                    file.WriteLine(item.ToString());
                }

                file.WriteLine($"Total Price: {shoppingcart.finalprice}");
                file.WriteLine("========================================");
            }
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string u=Console.ReadLine();
            //string p = Console.ReadLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminPanel());
           
        }
    }
}
