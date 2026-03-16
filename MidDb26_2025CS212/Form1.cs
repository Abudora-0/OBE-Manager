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
            if (!DBHelper.TestConnection())
            {
                MessageBox.Show("Cannot connect to database!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            this.Hide();
            StudentForm sf = new StudentForm();
            sf.ShowDialog();
            this.Close();
        }
    }
}