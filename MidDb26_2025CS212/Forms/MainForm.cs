using System;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;

namespace MidDb26_2025CS212.Forms
{
    public partial class MainForm : Form
    {
        private Button activeNavBtn = null;
        private StudentDAL studentDal = new StudentDAL();

        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateStats();
        }

        public void UpdateStats()
        {
            try
            {
                int studentCount = studentDal
                    .GetAllStudents().Count;
                lbl_stat1_val.Text = studentCount.ToString();
            }
            catch { }
        }

        public void NavClick(Button btn, string title, Form form)
        {
            // Update active button style
            if (activeNavBtn != null)
            {
                activeNavBtn.ForeColor =
                    System.Drawing.Color.FromArgb(160, 180, 230);
                activeNavBtn.BackColor =
                    System.Drawing.Color.Transparent;
            }
            activeNavBtn = btn;
            activeNavBtn.ForeColor =
                System.Drawing.Color.White;
            activeNavBtn.BackColor =
                System.Drawing.Color.FromArgb(57, 73, 171);

            // Update page title
            lbl_page_title.Text = title;

            // Clear content and load form
            pnl_main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
    }
}