using System;
using System.Windows.Forms;
using MidDb26_2025CS212.Helpers;

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
            if (DBHelper.TestConnection())
            {
                MessageBox.Show("Database connected successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot connect to database!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}