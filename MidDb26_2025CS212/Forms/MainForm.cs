using System;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Forms;

namespace MidDb26_2025CS212.Forms
{
    public partial class MainForm : Form
    {
        private Button activeNavBtn = null;
        private StudentDAL studentDal = new StudentDAL();
        private CloDAL cloDal = new CloDAL();
        private AssessmentDAL assessmentDal = new AssessmentDAL();
        private EvaluationDAL evaluationDal = new EvaluationDAL();

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
                // Total students
                int students =
                    studentDal.GetAllStudents().Count;
                lbl_stat1_val.Text = students.ToString();

                // Total CLOs
                int clos = cloDal.GetAll().Count;
                lbl_stat2_val.Text = clos.ToString();

                // Total assessments
                int assessments =
                    assessmentDal.GetAll().Count;
                lbl_stat3_val.Text = assessments.ToString();

                // Total evaluations
                int evaluations =
                    GetTotalEvaluations();
                lbl_stat4_val.Text = evaluations.ToString();
            }
            catch { }
        }

        private int GetTotalEvaluations()
        {
            try
            {
                using (var con =
                    MidDb26_2025CS212.Helpers
                    .DBHelper.GetConnection())
                {
                    string query =
                        "SELECT COUNT(*) FROM studentresult";
                    var cmd = new MySql.Data.MySqlClient
                        .MySqlCommand(query, con);
                    con.Open();
                    return Convert.ToInt32(
                        cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public void NavClick(Button btn,
            string title, Form form)
        {
            // Update active button style
            if (activeNavBtn != null)
            {
                activeNavBtn.ForeColor =
                    System.Drawing.Color.FromArgb(
                        160, 180, 230);
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

            // Refresh stats after navigation
            UpdateStats();
        }
    }
}
