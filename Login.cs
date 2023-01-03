using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uk_Retails
{
    public partial class Login : Form
    {
        static int attempt = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Admin" && password == "admin")
            {
                attempt = 0;


                MainMenu myForm = new MainMenu();
                this.Hide();
                myForm.ShowDialog();
                this.Close();

            }
            else if ((attempt == 3) && (attempt > 0))
            {
                lblAttempt.Text = ("You have Only " + Convert.ToString(attempt) + " Attempt Left to Try");
                --attempt;
            }
            else
            {
                MessageBox.Show("You are not granted with access!");
            }

        }
    }
}
