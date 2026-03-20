namespace MidDb26_2025CS212.Forms
{
    partial class EvaluationForm
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_student = new System.Windows.Forms.Label();
            this.cmb_Student = new System.Windows.Forms.ComboBox();
            this.lbl_assessment = new System.Windows.Forms.Label();
            this.cmb_Assessment = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.pnl_components = new System.Windows.Forms.Panel();
            this.lbl_components_title =
                new System.Windows.Forms.Label();
            this.pnl_components_list =
                new System.Windows.Forms.Panel();
            this.pnl_summary = new System.Windows.Forms.Panel();
            this.lbl_total_title = new System.Windows.Forms.Label();
            this.lbl_total_marks = new System.Windows.Forms.Label();
            this.lbl_percentage_title =
                new System.Windows.Forms.Label();
            this.lbl_percentage = new System.Windows.Forms.Label();
            this.btn_save_all = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── HEADER ─────────────────────────────────────
            this.pnl_header.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Height = 70;

            this.lbl_title.Text = "Student Evaluations";
            this.lbl_title.ForeColor =
                System.Drawing.Color.White;
            this.lbl_title.Font = new System.Drawing.Font(
                "Segoe UI", 15F,
                System.Drawing.FontStyle.Bold);
            this.lbl_title.Location =
                new System.Drawing.Point(20, 10);
            this.lbl_title.Size =
                new System.Drawing.Size(500, 30);

            this.lbl_subtitle.Text =
                "Assign rubric levels to students per assessment";
            this.lbl_subtitle.ForeColor =
                System.Drawing.Color.FromArgb(160, 180, 230);
            this.lbl_subtitle.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.lbl_subtitle.Location =
                new System.Drawing.Point(20, 42);
            this.lbl_subtitle.Size =
                new System.Drawing.Size(500, 20);

            this.btn_home.Text = "⌂ Dashboard";
            this.btn_home.Location =
                new System.Drawing.Point(900, 18);
            this.btn_home.Size =
                new System.Drawing.Size(120, 32);
            this.btn_home.BackColor =
                System.Drawing.Color.FromArgb(57, 73, 171);
            this.btn_home.ForeColor =
                System.Drawing.Color.White;
            this.btn_home.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.Font = new System.Drawing.Font(
                "Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_home.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_home.Click +=
                new System.EventHandler(this.btn_home_Click);

            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Controls.Add(this.lbl_subtitle);
            this.pnl_header.Controls.Add(this.btn_home);

            // ── TOP SELECTION PANEL ────────────────────────
            this.pnl_top.BackColor =
                System.Drawing.Color.White;
            this.pnl_top.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Height = 80;
            this.pnl_top.Padding =
                new System.Windows.Forms.Padding(16, 14, 16, 14);

            this.lbl_student.Text = "SELECT STUDENT *";
            this.lbl_student.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_student.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_student.Location =
                new System.Drawing.Point(16, 14);
            this.lbl_student.Size =
                new System.Drawing.Size(200, 16);

            this.cmb_Student.Location =
                new System.Drawing.Point(16, 32);
            this.cmb_Student.Size =
                new System.Drawing.Size(280, 28);
            this.cmb_Student.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.cmb_Student.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Student.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.lbl_assessment.Text = "SELECT ASSESSMENT *";
            this.lbl_assessment.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_assessment.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_assessment.Location =
                new System.Drawing.Point(320, 14);
            this.lbl_assessment.Size =
                new System.Drawing.Size(200, 16);

            this.cmb_Assessment.Location =
                new System.Drawing.Point(320, 32);
            this.cmb_Assessment.Size =
                new System.Drawing.Size(280, 28);
            this.cmb_Assessment.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.cmb_Assessment.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Assessment.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Assessment.SelectedIndexChanged +=
                new System.EventHandler(
                this.cmb_Assessment_SelectedIndexChanged);

            this.btn_load.Text = "Load Evaluation";
            this.btn_load.Location =
                new System.Drawing.Point(620, 30);
            this.btn_load.Size =
                new System.Drawing.Size(150, 32);
            this.btn_load.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.btn_load.ForeColor =
                System.Drawing.Color.White;
            this.btn_load.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.btn_load.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_load.Click += new System.EventHandler(
                this.btn_load_Click);

            this.pnl_top.Controls.Add(this.lbl_student);
            this.pnl_top.Controls.Add(this.cmb_Student);
            this.pnl_top.Controls.Add(this.lbl_assessment);
            this.pnl_top.Controls.Add(this.cmb_Assessment);
            this.pnl_top.Controls.Add(this.btn_load);

            // ── COMPONENTS TITLE ───────────────────────────
            this.pnl_components.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
            this.pnl_components.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_components.Padding =
                new System.Windows.Forms.Padding(16, 10, 16, 10);

            this.lbl_components_title.Text =
                "Select a student and assessment, then click Load";
            this.lbl_components_title.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.lbl_components_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_components_title.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.lbl_components_title.Height = 30;

            // Scrollable components list
            this.pnl_components_list.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_components_list.AutoScroll = true;
            this.pnl_components_list.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.pnl_components.Controls.Add(
                this.pnl_components_list);
            this.pnl_components.Controls.Add(
                this.lbl_components_title);

            // ── SUMMARY PANEL ──────────────────────────────
            this.pnl_summary.BackColor =
                System.Drawing.Color.White;
            this.pnl_summary.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_summary.Height = 60;

            this.lbl_total_title.Text = "TOTAL OBTAINED MARKS:";
            this.lbl_total_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_total_title.Font = new System.Drawing.Font(
                "Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.lbl_total_title.Location =
                new System.Drawing.Point(16, 20);
            this.lbl_total_title.Size =
                new System.Drawing.Size(200, 20);

            this.lbl_total_marks.Text = "0.00";
            this.lbl_total_marks.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_total_marks.Font = new System.Drawing.Font(
                "Segoe UI", 14F,
                System.Drawing.FontStyle.Bold);
            this.lbl_total_marks.Location =
                new System.Drawing.Point(220, 14);
            this.lbl_total_marks.Size =
                new System.Drawing.Size(100, 28);

            this.lbl_percentage_title.Text = "PERCENTAGE:";
            this.lbl_percentage_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_percentage_title.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.lbl_percentage_title.Location =
                new System.Drawing.Point(340, 20);
            this.lbl_percentage_title.Size =
                new System.Drawing.Size(100, 20);

            this.lbl_percentage.Text = "0%";
            this.lbl_percentage.ForeColor =
                System.Drawing.Color.FromArgb(0, 121, 107);
            this.lbl_percentage.Font = new System.Drawing.Font(
                "Segoe UI", 14F,
                System.Drawing.FontStyle.Bold);
            this.lbl_percentage.Location =
                new System.Drawing.Point(450, 14);
            this.lbl_percentage.Size =
                new System.Drawing.Size(100, 28);

            this.btn_save_all.Text = "Save All Evaluations";
            this.btn_save_all.Location =
                new System.Drawing.Point(700, 14);
            this.btn_save_all.Size =
                new System.Drawing.Size(200, 34);
            this.btn_save_all.BackColor =
                System.Drawing.Color.FromArgb(0, 121, 107);
            this.btn_save_all.ForeColor =
                System.Drawing.Color.White;
            this.btn_save_all.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_all.FlatAppearance.BorderSize = 0;
            this.btn_save_all.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.btn_save_all.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_save_all.Click += new System.EventHandler(
                this.btn_save_all_Click);

            this.pnl_summary.Controls.Add(this.lbl_total_title);
            this.pnl_summary.Controls.Add(this.lbl_total_marks);
            this.pnl_summary.Controls.Add(
                this.lbl_percentage_title);
            this.pnl_summary.Controls.Add(this.lbl_percentage);
            this.pnl_summary.Controls.Add(this.btn_save_all);

            // Main form
            this.Controls.Add(this.pnl_components);
            this.Controls.Add(this.pnl_summary);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_header);
            this.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.ResumeLayout(false);
        }

        // Control declarations
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_components;
        private System.Windows.Forms.Panel pnl_components_list;
        private System.Windows.Forms.Panel pnl_summary;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.Label lbl_assessment;
        private System.Windows.Forms.Label lbl_components_title;
        private System.Windows.Forms.Label lbl_total_title;
        private System.Windows.Forms.Label lbl_total_marks;
        private System.Windows.Forms.Label lbl_percentage_title;
        private System.Windows.Forms.Label lbl_percentage;
        private System.Windows.Forms.ComboBox cmb_Student;
        private System.Windows.Forms.ComboBox cmb_Assessment;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save_all;
        private System.Windows.Forms.Button btn_home;
    }
}