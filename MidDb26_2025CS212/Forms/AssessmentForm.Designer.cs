namespace MidDb26_2025CS212.Forms
{
    partial class AssessmentForm
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
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_left_top = new System.Windows.Forms.Panel();
            this.pnl_right_top = new System.Windows.Forms.Panel();
            this.lbl_assessments = new System.Windows.Forms.Label();
            this.lbl_components = new System.Windows.Forms.Label();
            this.btn_new_assessment = new System.Windows.Forms.Button();
            this.btn_new_component = new System.Windows.Forms.Button();
            this.dgv_Assessments = new System.Windows.Forms.DataGridView();
            this.dgv_Components = new System.Windows.Forms.DataGridView();
            this.pnl_assessment_form = new System.Windows.Forms.Panel();
            this.pnl_component_form = new System.Windows.Forms.Panel();
            this.pnl_af_header = new System.Windows.Forms.Panel();
            this.pnl_cf_header = new System.Windows.Forms.Panel();
            this.lbl_af_title = new System.Windows.Forms.Label();
            this.lbl_cf_title = new System.Windows.Forms.Label();
            this.lbl_atitle = new System.Windows.Forms.Label();
            this.lbl_marks = new System.Windows.Forms.Label();
            this.lbl_weightage = new System.Windows.Forms.Label();
            this.lbl_cname = new System.Windows.Forms.Label();
            this.lbl_cmarks = new System.Windows.Forms.Label();
            this.lbl_rubric = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Marks = new System.Windows.Forms.TextBox();
            this.txt_Weightage = new System.Windows.Forms.TextBox();
            this.txt_CompName = new System.Windows.Forms.TextBox();
            this.txt_CompMarks = new System.Windows.Forms.TextBox();
            this.cmb_Rubric = new System.Windows.Forms.ComboBox();
            this.btn_save_assessment = new System.Windows.Forms.Button();
            this.btn_update_assessment = new System.Windows.Forms.Button();
            this.btn_delete_assessment = new System.Windows.Forms.Button();
            this.btn_cancel_assessment = new System.Windows.Forms.Button();
            this.btn_save_component = new System.Windows.Forms.Button();
            this.btn_update_component = new System.Windows.Forms.Button();
            this.btn_delete_component = new System.Windows.Forms.Button();
            this.btn_cancel_component = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── HEADER ─────────────────────────────────────
            this.pnl_header.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Height = 70;

            this.lbl_title.Text = "Manage Assessments";
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
                "Create assessments and map components to rubrics";
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
                new System.Drawing.Point(1050, 18);
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

            // ── BODY PANEL ─────────────────────────────────
            this.pnl_body.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
            this.pnl_body.Padding =
                new System.Windows.Forms.Padding(10);

            // ── LEFT PANEL ─────────────────────────────────
            this.pnl_left.Location =
                new System.Drawing.Point(10, 10);
            this.pnl_left.Size =
                new System.Drawing.Size(480, 560);
            this.pnl_left.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom;
            this.pnl_left.BackColor =
                System.Drawing.Color.White;

            // Left top bar
            this.pnl_left_top.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_left_top.Height = 46;
            this.pnl_left_top.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_left_top.Controls.Add(
                this.lbl_assessments);
            this.pnl_left_top.Controls.Add(
                this.btn_new_assessment);

            this.lbl_assessments.Text = "Assessments";
            this.lbl_assessments.Font = new System.Drawing.Font(
                "Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.lbl_assessments.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_assessments.Location =
                new System.Drawing.Point(12, 12);
            this.lbl_assessments.Size =
                new System.Drawing.Size(200, 24);

            this.btn_new_assessment.Text = "+ New Assessment";
            this.btn_new_assessment.Location =
                new System.Drawing.Point(300, 10);
            this.btn_new_assessment.Size =
                new System.Drawing.Size(150, 28);
            this.btn_new_assessment.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.btn_new_assessment.ForeColor =
                System.Drawing.Color.White;
            this.btn_new_assessment.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_assessment.FlatAppearance.BorderSize = 0;
            this.btn_new_assessment.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_new_assessment.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_new_assessment.Click += (s, e) =>
            {
                ClearAssessmentForm();
                pnl_assessment_form.Visible = true;
                lbl_af_title.Text = "Add New Assessment";
                txt_Title.Focus();
            };

            // Assessment grid
            this.dgv_Assessments.Location =
                new System.Drawing.Point(0, 46);
            this.dgv_Assessments.Size =
                new System.Drawing.Size(480, 300);
            this.dgv_Assessments.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            StyleGrid(this.dgv_Assessments);
            this.dgv_Assessments.CellClick +=
                new System.Windows.Forms
                .DataGridViewCellEventHandler(
                this.dgv_Assessments_CellClick);

            // Assessment form
            this.pnl_assessment_form.Location =
                new System.Drawing.Point(0, 346);
            this.pnl_assessment_form.Size =
                new System.Drawing.Size(480, 214);
            this.pnl_assessment_form.BackColor =
                System.Drawing.Color.White;
            this.pnl_assessment_form.Visible = false;
            this.pnl_assessment_form.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnl_af_header.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_af_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_af_header.Height = 32;

            this.lbl_af_title.Text = "Add New Assessment";
            this.lbl_af_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_af_title.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_af_title.Location =
                new System.Drawing.Point(12, 7);
            this.lbl_af_title.Size =
                new System.Drawing.Size(300, 20);
            this.pnl_af_header.Controls.Add(this.lbl_af_title);

            // Assessment fields
            MakeField(lbl_atitle, txt_Title,
                "TITLE *", 12, 42, 440);
            MakeField(lbl_marks, txt_Marks,
                "TOTAL MARKS *", 12, 100, 180);
            MakeField(lbl_weightage, txt_Weightage,
                "WEIGHTAGE % *", 210, 100, 180);

            // Assessment buttons
            MakeBtn(btn_save_assessment, "Save",
                System.Drawing.Color.FromArgb(26, 35, 126),
                12, 160);
            MakeBtn(btn_update_assessment, "Update",
                System.Drawing.Color.FromArgb(0, 121, 107),
                108, 160);
            MakeBtn(btn_delete_assessment, "Delete",
                System.Drawing.Color.FromArgb(183, 28, 28),
                204, 160);
            MakeBtn(btn_cancel_assessment, "Cancel",
                System.Drawing.Color.FromArgb(97, 97, 97),
                300, 160);

            this.btn_save_assessment.Click +=
                new System.EventHandler(
                this.btn_save_assessment_Click);
            this.btn_update_assessment.Click +=
                new System.EventHandler(
                this.btn_update_assessment_Click);
            this.btn_delete_assessment.Click +=
                new System.EventHandler(
                this.btn_delete_assessment_Click);
            this.btn_cancel_assessment.Click += (s, e) =>
            {
                pnl_assessment_form.Visible = false;
                ClearAssessmentForm();
            };

            this.pnl_assessment_form.Controls.Add(
                this.lbl_atitle);
            this.pnl_assessment_form.Controls.Add(
                this.txt_Title);
            this.pnl_assessment_form.Controls.Add(
                this.lbl_marks);
            this.pnl_assessment_form.Controls.Add(
                this.txt_Marks);
            this.pnl_assessment_form.Controls.Add(
                this.lbl_weightage);
            this.pnl_assessment_form.Controls.Add(
                this.txt_Weightage);
            this.pnl_assessment_form.Controls.Add(
                this.btn_save_assessment);
            this.pnl_assessment_form.Controls.Add(
                this.btn_update_assessment);
            this.pnl_assessment_form.Controls.Add(
                this.btn_delete_assessment);
            this.pnl_assessment_form.Controls.Add(
                this.btn_cancel_assessment);
            this.pnl_assessment_form.Controls.Add(
                this.pnl_af_header);

            this.pnl_left.Controls.Add(
                this.pnl_assessment_form);
            this.pnl_left.Controls.Add(
                this.dgv_Assessments);
            this.pnl_left.Controls.Add(this.pnl_left_top);

            // ── RIGHT PANEL ────────────────────────────────
            this.pnl_right.Location =
                new System.Drawing.Point(500, 10);
            this.pnl_right.Size =
                new System.Drawing.Size(480, 560);
            this.pnl_right.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.pnl_right.BackColor =
                System.Drawing.Color.White;

            // Right top bar
            this.pnl_right_top.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_right_top.Height = 46;
            this.pnl_right_top.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_right_top.Controls.Add(
                this.lbl_components);
            this.pnl_right_top.Controls.Add(
                this.btn_new_component);

            this.lbl_components.Text =
                "Select an assessment first";
            this.lbl_components.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lbl_components.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_components.Location =
                new System.Drawing.Point(12, 12);
            this.lbl_components.Size =
                new System.Drawing.Size(300, 24);

            this.btn_new_component.Text = "+ New Component";
            this.btn_new_component.Location =
                new System.Drawing.Point(330, 10);
            this.btn_new_component.Size =
                new System.Drawing.Size(140, 28);
            this.btn_new_component.BackColor =
                System.Drawing.Color.FromArgb(0, 121, 107);
            this.btn_new_component.ForeColor =
                System.Drawing.Color.White;
            this.btn_new_component.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_component.FlatAppearance.BorderSize = 0;
            this.btn_new_component.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_new_component.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_new_component.Click += (s, e) =>
            {
                if (selectedAssessmentId == -1)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Please select an assessment first!",
                        "No Assessment Selected",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }
                ClearComponentForm();
                pnl_component_form.Visible = true;
                lbl_cf_title.Text = "Add New Component";
                txt_CompName.Focus();
            };

            // Component grid
            this.dgv_Components.Location =
                new System.Drawing.Point(0, 46);
            this.dgv_Components.Size =
                new System.Drawing.Size(480, 280);
            this.dgv_Components.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            StyleGrid(this.dgv_Components);
            this.dgv_Components.CellClick +=
                new System.Windows.Forms
                .DataGridViewCellEventHandler(
                this.dgv_Components_CellClick);

            // Component form
            this.pnl_component_form.Location =
                new System.Drawing.Point(0, 326);
            this.pnl_component_form.Size =
                new System.Drawing.Size(480, 234);
            this.pnl_component_form.BackColor =
                System.Drawing.Color.White;
            this.pnl_component_form.Visible = false;
            this.pnl_component_form.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnl_cf_header.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_cf_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_cf_header.Height = 32;

            this.lbl_cf_title.Text = "Add New Component";
            this.lbl_cf_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_cf_title.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_cf_title.Location =
                new System.Drawing.Point(12, 7);
            this.lbl_cf_title.Size =
                new System.Drawing.Size(300, 20);
            this.pnl_cf_header.Controls.Add(this.lbl_cf_title);

            // Component fields
            MakeField(lbl_cname, txt_CompName,
                "COMPONENT NAME *", 12, 42, 440);
            MakeField(lbl_cmarks, txt_CompMarks,
                "MARKS *", 12, 100, 180);

            this.lbl_rubric.Text = "SELECT RUBRIC *";
            this.lbl_rubric.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_rubric.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_rubric.Location =
                new System.Drawing.Point(12, 148);
            this.lbl_rubric.Size =
                new System.Drawing.Size(200, 16);

            this.cmb_Rubric.Location =
                new System.Drawing.Point(12, 166);
            this.cmb_Rubric.Size =
                new System.Drawing.Size(440, 28);
            this.cmb_Rubric.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.cmb_Rubric.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rubric.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            // Component buttons
            MakeBtn(btn_save_component, "Save",
                System.Drawing.Color.FromArgb(26, 35, 126),
                12, 200);
            MakeBtn(btn_update_component, "Update",
                System.Drawing.Color.FromArgb(0, 121, 107),
                108, 200);
            MakeBtn(btn_delete_component, "Delete",
                System.Drawing.Color.FromArgb(183, 28, 28),
                204, 200);
            MakeBtn(btn_cancel_component, "Cancel",
                System.Drawing.Color.FromArgb(97, 97, 97),
                300, 200);

            this.btn_save_component.Click +=
                new System.EventHandler(
                this.btn_save_component_Click);
            this.btn_update_component.Click +=
                new System.EventHandler(
                this.btn_update_component_Click);
            this.btn_delete_component.Click +=
                new System.EventHandler(
                this.btn_delete_component_Click);
            this.btn_cancel_component.Click += (s, e) =>
            {
                pnl_component_form.Visible = false;
                ClearComponentForm();
            };

            this.pnl_component_form.Controls.Add(
                this.lbl_cname);
            this.pnl_component_form.Controls.Add(
                this.txt_CompName);
            this.pnl_component_form.Controls.Add(
                this.lbl_cmarks);
            this.pnl_component_form.Controls.Add(
                this.txt_CompMarks);
            this.pnl_component_form.Controls.Add(
                this.lbl_rubric);
            this.pnl_component_form.Controls.Add(
                this.cmb_Rubric);
            this.pnl_component_form.Controls.Add(
                this.btn_save_component);
            this.pnl_component_form.Controls.Add(
                this.btn_update_component);
            this.pnl_component_form.Controls.Add(
                this.btn_delete_component);
            this.pnl_component_form.Controls.Add(
                this.btn_cancel_component);
            this.pnl_component_form.Controls.Add(
                this.pnl_cf_header);

            this.pnl_right.Controls.Add(
                this.pnl_component_form);
            this.pnl_right.Controls.Add(
                this.dgv_Components);
            this.pnl_right.Controls.Add(
                this.pnl_right_top);

            // Add both panels to body
            this.pnl_body.Controls.Add(this.pnl_right);
            this.pnl_body.Controls.Add(this.pnl_left);

            // Main form
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_header);
            this.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
            this.Size =
                new System.Drawing.Size(1050, 680);

            this.ResumeLayout(false);
        }

        private void StyleGrid(
            System.Windows.Forms.DataGridView dgv)
        {
            dgv.BackgroundColor =
                System.Drawing.Color.White;
            dgv.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode
                .Fill;
            dgv.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgv.ColumnHeadersHeight = 34;
            dgv.RowTemplate.Height = 32;
            dgv.GridColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgv.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            dgv.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
        }

        private void MakeField(
            System.Windows.Forms.Label lbl,
            System.Windows.Forms.TextBox txt,
            string labelText, int x, int y, int width)
        {
            lbl.Text = labelText;
            lbl.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            lbl.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(width, 16);

            txt.Location =
                new System.Drawing.Point(x, y + 18);
            txt.Size =
                new System.Drawing.Size(width, 26);
            txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void MakeBtn(
            System.Windows.Forms.Button btn,
            string text,
            System.Drawing.Color color, int x, int y)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(88, 30);
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font(
                "Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        // Control declarations
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_left_top;
        private System.Windows.Forms.Panel pnl_right_top;
        private System.Windows.Forms.Panel pnl_assessment_form;
        private System.Windows.Forms.Panel pnl_component_form;
        private System.Windows.Forms.Panel pnl_af_header;
        private System.Windows.Forms.Panel pnl_cf_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_assessments;
        private System.Windows.Forms.Label lbl_components;
        private System.Windows.Forms.Label lbl_af_title;
        private System.Windows.Forms.Label lbl_cf_title;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lbl_atitle;
        private System.Windows.Forms.Label lbl_marks;
        private System.Windows.Forms.Label lbl_weightage;
        private System.Windows.Forms.Label lbl_cname;
        private System.Windows.Forms.Label lbl_cmarks;
        private System.Windows.Forms.Label lbl_rubric;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Marks;
        private System.Windows.Forms.TextBox txt_Weightage;
        private System.Windows.Forms.TextBox txt_CompName;
        private System.Windows.Forms.TextBox txt_CompMarks;
        private System.Windows.Forms.ComboBox cmb_Rubric;
        private System.Windows.Forms.Button btn_new_assessment;
        private System.Windows.Forms.Button btn_new_component;
        private System.Windows.Forms.Button btn_save_assessment;
        private System.Windows.Forms.Button btn_update_assessment;
        private System.Windows.Forms.Button btn_delete_assessment;
        private System.Windows.Forms.Button btn_cancel_assessment;
        private System.Windows.Forms.Button btn_save_component;
        private System.Windows.Forms.Button btn_update_component;
        private System.Windows.Forms.Button btn_delete_component;
        private System.Windows.Forms.Button btn_cancel_component;
        private System.Windows.Forms.DataGridView dgv_Assessments;
        private System.Windows.Forms.DataGridView dgv_Components;
    }
}