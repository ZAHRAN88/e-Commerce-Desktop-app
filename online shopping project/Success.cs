using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace online_shopping_project
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
            Program.RoundControlCorners(okBtn, 10);
            okBtn.MouseClick += CloseApp;
        }
        private void CloseApp (object sender ,EventArgs e)
        {
            MessageBox.Show($"Thanks For visiting us!", "Thank You !", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            Application.Exit();
        }
    }
}
