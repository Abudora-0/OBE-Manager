using System;
using System.Windows.Forms;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Forms;

namespace MidDb26_2025CS212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Test DB connection first
            if (!DBHelper.TestConnection())
            {
                MessageBox.Show(
                    "Cannot connect to database!\n" +
                    "Please check MySQL is running.",
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            // Show login form
            this.Hide();
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Login successful — open main form
                MainForm main = new MainForm();
                main.ShowDialog();
            }
            this.Close();
        }
    }
}