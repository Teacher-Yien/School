using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shcool_management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password_txt.PasswordChar = '*';
           // checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool username = false; // Flag for successful username validation
        private bool password = false; // Flag for successful password validation

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Simulate username validation (replace with your actual logic)
            username = username_txt.Text == "admin"; // Replace with your validation condition
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Simulate password validation (replace with your actual logic)
            password = password_txt.Text == "123"; // Replace with your validation condition
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (username && password)
            {
                MessageBox.Show("Login successful!", "Success");
                DialogResult = DialogResult.OK; // Simulate successful login dialog result
               
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error");
            }
        }
    }
}
