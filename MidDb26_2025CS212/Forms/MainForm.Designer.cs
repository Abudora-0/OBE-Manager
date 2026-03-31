using System.Windows.Forms;

namespace MidDb26_2025CS212.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.lbl_appsub = new System.Windows.Forms.Label();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.lbl_nav_label = new System.Windows.Forms.Label();
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_clos = new System.Windows.Forms.Button();
            this.btn_rubrics = new System.Windows.Forms.Button();
            this.btn_rubric_levels = new System.Windows.Forms.Button();
            this.btn_assessments = new System.Windows.Forms.Button();
            this.btn_evaluations = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.lbl_reports_label = new System.Windows.Forms.Label();
            this.btn_clo_report = new System.Windows.Forms.Button();
            this.btn_assessment_report = new System.Windows.Forms.Button();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.lbl_page_title = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_welcome = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_welcome_sub = new System.Windows.Forms.Label();
            this.pnl_stats = new System.Windows.Forms.Panel();
            this.card_students = new System.Windows.Forms.Panel();
            this.lbl_stat1_val = new System.Windows.Forms.Label();
            this.lbl_stat1_title = new System.Windows.Forms.Label();
            this.card_clos = new System.Windows.Forms.Panel();
            this.lbl_stat2_val = new System.Windows.Forms.Label();
            this.lbl_stat2_title = new System.Windows.Forms.Label();
            this.card_assessments = new System.Windows.Forms.Panel();
            this.lbl_stat3_val = new System.Windows.Forms.Label();
            this.lbl_stat3_title = new System.Windows.Forms.Label();
            this.card_evaluations = new System.Windows.Forms.Panel();
            this.lbl_stat4_val = new System.Windows.Forms.Label();
            this.lbl_stat4_title = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // SIDEBAR
            this.pnl_sidebar.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_sidebar.Dock =
                System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Width = 230;

            // Logo panel
            this.pnl_logo.BackColor =
                System.Drawing.Color.FromArgb(21, 28, 100);
            this.pnl_logo.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Height = 90;
            this.pnl_logo.Controls.Add(this.lbl_appname);
            this.pnl_logo.Controls.Add(this.lbl_appsub);

            this.lbl_appname.Text = "OBE Manager";
            this.lbl_appname.ForeColor =
                System.Drawing.Color.White;
            this.lbl_appname.Font = new System.Drawing.Font(
                "Segoe UI", 14F,
                System.Drawing.FontStyle.Bold);
            this.lbl_appname.Location =
                new System.Drawing.Point(62, 14);
            this.lbl_appname.Size =
                new System.Drawing.Size(160, 28);

            this.lbl_appsub.Text = "CS104  ·  Spring 2026";
            this.lbl_appsub.ForeColor =
                System.Drawing.Color.FromArgb(100, 120, 200);
            this.lbl_appsub.Font = new System.Drawing.Font(
                "Segoe UI", 8F);
            this.lbl_appsub.Location =
                new System.Drawing.Point(62, 44);
            this.lbl_appsub.Size =
                new System.Drawing.Size(160, 18);

            this.pic_Logo.Location =
            new System.Drawing.Point(10, 8);
            this.pic_Logo.Size =
                new System.Drawing.Size(44, 44);
            this.pic_Logo.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.BackColor =
                System.Drawing.Color.Transparent;
            try
            {
                this.pic_Logo.Image = System.Drawing.Image.FromFile(
                    Application.StartupPath + "\\uet logo.png");
            }
            catch { }

            this.pnl_logo.Controls.Add(this.pic_Logo);

            // Nav panel
            this.pnl_nav.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_nav.Padding =
                new System.Windows.Forms.Padding(12, 16, 12, 0);

            this.lbl_nav_label.Text = "MAIN MENU";
            this.lbl_nav_label.ForeColor =
                System.Drawing.Color.FromArgb(80, 100, 180);
            this.lbl_nav_label.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_nav_label.Location =
                new System.Drawing.Point(20, 16);
            this.lbl_nav_label.Size =
                new System.Drawing.Size(190, 18);

            // Nav buttons
            MakeNavBtn(btn_students, "    Students", 42);
            MakeNavBtn(btn_clos, "    CLOs", 88);
            MakeNavBtn(btn_rubrics, "    Rubrics", 134);
            MakeNavBtn(btn_rubric_levels, "    Rubric Levels", 180);
            MakeNavBtn(btn_attendance, "    Attendance", 318);
            MakeNavBtn(btn_assessments, "    Assessments", 226);
            MakeNavBtn(btn_evaluations, "    Evaluations", 272);

            this.lbl_reports_label.Text = "REPORTS";
            this.lbl_reports_label.ForeColor =
                System.Drawing.Color.FromArgb(80, 100, 180);
            this.lbl_reports_label.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_reports_label.Location =
                new System.Drawing.Point(20, 376);
            this.lbl_reports_label.Size =
                new System.Drawing.Size(190, 18);

            MakeNavBtn(btn_clo_report, "    CLO Wise Report", 398);
            MakeNavBtn(btn_assessment_report, "    Assessment Report", 444);

            // Wire up clicks
            this.btn_students.Click += (s, e) =>
                NavClick(btn_students, "Students", new StudentForm());
            this.btn_clos.Click += (s, e) =>
                NavClick(btn_clos, "CLOs", new CloForm());
            this.btn_rubrics.Click += (s, e) =>
                NavClick(btn_rubrics, "Rubrics", new RubricForm());
            this.btn_rubric_levels.Click += (s, e) =>
                NavClick(btn_rubric_levels, "Rubric Levels",
                new RubricLevelForm());
            this.btn_attendance.Click += (s, e) =>
                NavClick(btn_attendance, "Attendance", new AttendanceForm());
            this.btn_assessments.Click += (s, e) =>
                NavClick(btn_assessments, "Assessments",
                new AssessmentForm());
            this.btn_evaluations.Click += (s, e) =>
                NavClick(btn_evaluations, "Evaluations",
                new EvaluationForm());
            this.btn_clo_report.Click += (s, e) =>
                MidDb26_2025CS212.Reports.ReportHelper.GenerateCloWiseReport();
            this.btn_assessment_report.Click += (s, e) =>
                MidDb26_2025CS212.Reports.ReportHelper.GenerateAssessmentWiseReport();

            // Add controls to nav panel
            this.pnl_nav.Controls.Add(this.lbl_nav_label);
            this.pnl_nav.Controls.Add(this.btn_students);
            this.pnl_nav.Controls.Add(this.btn_clos);
            this.pnl_nav.Controls.Add(this.btn_rubrics);
            this.pnl_nav.Controls.Add(this.btn_rubric_levels);
            this.pnl_nav.Controls.Add(this.btn_attendance);
            this.pnl_nav.Controls.Add(this.btn_assessments);
            this.pnl_nav.Controls.Add(this.btn_evaluations);
            this.pnl_nav.Controls.Add(this.lbl_reports_label);
            this.pnl_nav.Controls.Add(this.btn_clo_report);
            this.pnl_nav.Controls.Add(this.btn_assessment_report);

            // Footer
            this.pnl_footer.BackColor =
                System.Drawing.Color.FromArgb(21, 28, 100);
            this.pnl_footer.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Height = 60;
            this.pnl_footer.Controls.Add(this.lbl_user);
            this.pnl_footer.Controls.Add(this.lbl_role);

            this.lbl_user.Text = "Teacher";
            this.lbl_user.ForeColor =
                System.Drawing.Color.White;
            this.lbl_user.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lbl_user.Location =
                new System.Drawing.Point(18, 12);
            this.lbl_user.Size =
                new System.Drawing.Size(180, 20);

            this.lbl_role.Text = "Administrator";
            this.lbl_role.ForeColor =
                System.Drawing.Color.FromArgb(100, 120, 200);
            this.lbl_role.Font = new System.Drawing.Font(
                "Segoe UI", 8F);
            this.lbl_role.Location =
                new System.Drawing.Point(18, 33);
            this.lbl_role.Size =
                new System.Drawing.Size(180, 16);

            // Add to sidebar
            this.pnl_sidebar.Controls.Add(this.pnl_nav);
            this.pnl_sidebar.Controls.Add(this.pnl_footer);
            this.pnl_sidebar.Controls.Add(this.pnl_logo);

            // CONTENT AREA 
            this.pnl_content.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
            this.pnl_content.Dock =
                System.Windows.Forms.DockStyle.Fill;

            // Topbar
            this.pnl_topbar.BackColor =
                System.Drawing.Color.White;
            this.pnl_topbar.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_topbar.Height = 56;
            this.pnl_topbar.Controls.Add(this.lbl_page_title);

            this.lbl_page_title.Text = "Dashboard";
            this.lbl_page_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_page_title.Font = new System.Drawing.Font(
                "Segoe UI", 13F,
                System.Drawing.FontStyle.Bold);
            this.lbl_page_title.Location =
                new System.Drawing.Point(24, 14);
            this.lbl_page_title.Size =
                new System.Drawing.Size(400, 28);

            // Main area
            this.pnl_main.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
            this.pnl_main.Padding =
                new System.Windows.Forms.Padding(20);

            // Welcome text
            this.pnl_welcome.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_welcome.Height = 70;
            this.pnl_welcome.BackColor =
                System.Drawing.Color.Transparent;
            this.pnl_welcome.Controls.Add(this.lbl_welcome);
            this.pnl_welcome.Controls.Add(this.lbl_welcome_sub);

            this.lbl_welcome.Text = "Welcome back, Teacher!";
            this.lbl_welcome.Font = new System.Drawing.Font(
                "Segoe UI", 18F,
                System.Drawing.FontStyle.Bold);
            this.lbl_welcome.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_welcome.Location =
                new System.Drawing.Point(0, 0);
            this.lbl_welcome.Size =
                new System.Drawing.Size(600, 36);

            this.lbl_welcome_sub.Text =
                "Select a module from the sidebar to manage your data.";
            this.lbl_welcome_sub.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.lbl_welcome_sub.ForeColor =
                System.Drawing.Color.FromArgb(150, 150, 150);
            this.lbl_welcome_sub.Location =
                new System.Drawing.Point(0, 38);
            this.lbl_welcome_sub.Size =
                new System.Drawing.Size(500, 22);

            // Stats row
            this.pnl_stats.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_stats.Height = 110;
            this.pnl_stats.BackColor =
                System.Drawing.Color.Transparent;
            this.pnl_stats.Padding =
                new System.Windows.Forms.Padding(0, 16, 0, 0);

            MakeStatCard(card_students, lbl_stat1_val,
                lbl_stat1_title, "0", "Total Students", 0,
                System.Drawing.Color.FromArgb(26, 35, 126));
            MakeStatCard(card_clos, lbl_stat2_val,
                lbl_stat2_title, "0", "Total CLOs", 180,
                System.Drawing.Color.FromArgb(0, 121, 107));
            MakeStatCard(card_assessments, lbl_stat3_val,
                lbl_stat3_title, "0", "Assessments", 360,
                System.Drawing.Color.FromArgb(136, 14, 79));
            MakeStatCard(card_evaluations, lbl_stat4_val,
                lbl_stat4_title, "0", "Evaluations", 540,
                System.Drawing.Color.FromArgb(230, 81, 0));

            this.pnl_stats.Controls.Add(this.card_students);
            this.pnl_stats.Controls.Add(this.card_clos);
            this.pnl_stats.Controls.Add(this.card_assessments);
            this.pnl_stats.Controls.Add(this.card_evaluations);

            this.pnl_main.Controls.Add(this.pnl_stats);
            this.pnl_main.Controls.Add(this.pnl_welcome);

            this.pnl_content.Controls.Add(this.pnl_main);
            this.pnl_content.Controls.Add(this.pnl_topbar);

            // MAIN FORM
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_sidebar);
            this.Text = "OBE Manager — MidDb26_2025CS212";
            this.Size = new System.Drawing.Size(1100, 680);
            this.MinimumSize =
                new System.Drawing.Size(900, 600);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.ResumeLayout(false);
        }

        private void MakeNavBtn(
            System.Windows.Forms.Button btn,
            string text, int y)
        {
            btn.Text = text;
            btn.ForeColor =
                System.Drawing.Color.FromArgb(160, 180, 230);
            btn.BackColor =
                System.Drawing.Color.Transparent;
            btn.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(35, 45, 140);
            btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            btn.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;
            btn.Location = new System.Drawing.Point(0, y);
            btn.Size = new System.Drawing.Size(206, 40);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void MakeStatCard(
            System.Windows.Forms.Panel card,
            System.Windows.Forms.Label valLbl,
            System.Windows.Forms.Label titleLbl,
            string val, string title, int x,
            System.Drawing.Color accent)
        {
            card.BackColor = System.Drawing.Color.White;
            card.Location = new System.Drawing.Point(x, 20);
            card.Size = new System.Drawing.Size(180, 100);
            card.BorderStyle = System.Windows.Forms.BorderStyle.None;

            var accent_bar = new System.Windows.Forms.Panel();
            accent_bar.BackColor = accent;
            accent_bar.Location = new System.Drawing.Point(0, 0);
            accent_bar.Size = new System.Drawing.Size(180, 5);

            valLbl.Text = val;
            valLbl.Font = new System.Drawing.Font(
                "Segoe UI", 28F,
                System.Drawing.FontStyle.Bold);
            valLbl.ForeColor = accent;
            valLbl.Location = new System.Drawing.Point(16, 18);
            valLbl.Size = new System.Drawing.Size(150, 40);

            titleLbl.Text = title;
            titleLbl.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            titleLbl.ForeColor =
                System.Drawing.Color.FromArgb(120, 120, 120);
            titleLbl.Location = new System.Drawing.Point(16, 62);
            titleLbl.Size = new System.Drawing.Size(150, 22);

            card.Controls.Add(accent_bar);
            card.Controls.Add(valLbl);
            card.Controls.Add(titleLbl);
        }

        // Control declarations
        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Panel pnl_topbar;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_welcome;
        private System.Windows.Forms.Panel pnl_stats;
        private System.Windows.Forms.Panel card_students;
        private System.Windows.Forms.Panel card_clos;
        private System.Windows.Forms.Panel card_assessments;
        private System.Windows.Forms.Panel card_evaluations;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Label lbl_appsub;
        private System.Windows.Forms.Label lbl_nav_label;
        private System.Windows.Forms.Label lbl_reports_label;
        private System.Windows.Forms.Label lbl_page_title;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_welcome_sub;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_stat1_val;
        private System.Windows.Forms.Label lbl_stat1_title;
        private System.Windows.Forms.Label lbl_stat2_val;
        private System.Windows.Forms.Label lbl_stat2_title;
        private System.Windows.Forms.Label lbl_stat3_val;
        private System.Windows.Forms.Label lbl_stat3_title;
        private System.Windows.Forms.Label lbl_stat4_val;
        private System.Windows.Forms.Label lbl_stat4_title;
        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.Button btn_clos;
        private System.Windows.Forms.Button btn_rubrics;
        private System.Windows.Forms.Button btn_rubric_levels;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_assessments;
        private System.Windows.Forms.Button btn_evaluations;
        private System.Windows.Forms.Button btn_clo_report;
        private System.Windows.Forms.Button btn_assessment_report;
    }
}