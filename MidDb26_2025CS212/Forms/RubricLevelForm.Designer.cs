namespace MidDb26_2025CS212.Forms
{
    partial class RubricLevelForm
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
            this.pnl_search = new System.Windows.Forms.Panel();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.cmb_FilterRubric =
                new System.Windows.Forms.ComboBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_Add_New = new System.Windows.Forms.Button();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.dgv_Levels =
                new System.Windows.Forms.DataGridView();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.pnl_form_header =
                new System.Windows.Forms.Panel();
            this.lbl_form_title =
                new System.Windows.Forms.Label();
            this.pnl_fields = new System.Windows.Forms.Panel();
            this.lbl_rubric = new System.Windows.Forms.Label();
            this.cmb_Rubric =
                new System.Windows.Forms.ComboBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.cmb_Level =
                new System.Windows.Forms.ComboBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.txt_Details =
                new System.Windows.Forms.TextBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── HEADER ─────────────────────────────────────
            this.pnl_header.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Height = 70;

            this.lbl_title.Text = "Manage Rubric Levels";
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
                "Define performance levels for each rubric";
            this.lbl_subtitle.ForeColor =
                System.Drawing.Color.FromArgb(160, 180, 230);
            this.lbl_subtitle.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.lbl_subtitle.Location =
                new System.Drawing.Point(20, 42);
            this.lbl_subtitle.Size =
                new System.Drawing.Size(400, 20);

            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Controls.Add(this.lbl_subtitle);

            // ── SEARCH/FILTER PANEL ────────────────────────
            this.pnl_search.BackColor =
                System.Drawing.Color.White;
            this.pnl_search.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_search.Height = 54;

            this.lbl_filter.Text = "Filter by Rubric:";
            this.lbl_filter.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.lbl_filter.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_filter.Location =
                new System.Drawing.Point(16, 18);
            this.lbl_filter.Size =
                new System.Drawing.Size(100, 20);

            this.cmb_FilterRubric.Location =
                new System.Drawing.Point(120, 14);
            this.cmb_FilterRubric.Size =
                new System.Drawing.Size(280, 28);
            this.cmb_FilterRubric.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.cmb_FilterRubric.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FilterRubric.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_filter.Text = "Filter";
            this.btn_filter.Location =
                new System.Drawing.Point(410, 13);
            this.btn_filter.Size =
                new System.Drawing.Size(90, 30);
            this.btn_filter.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.btn_filter.ForeColor =
                System.Drawing.Color.White;
            this.btn_filter.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.FlatAppearance.BorderSize = 0;
            this.btn_filter.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.btn_filter.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_filter.Click += new System.EventHandler(
                this.btn_filter_Click);

            this.btn_Add_New.Text = "+ Add New Level";
            this.btn_Add_New.Location =
                new System.Drawing.Point(514, 13);
            this.btn_Add_New.Size =
                new System.Drawing.Size(150, 30);
            this.btn_Add_New.BackColor =
                System.Drawing.Color.FromArgb(57, 73, 171);
            this.btn_Add_New.ForeColor =
                System.Drawing.Color.White;
            this.btn_Add_New.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_New.FlatAppearance.BorderSize = 0;
            this.btn_Add_New.Font = new System.Drawing.Font(
                "Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_Add_New.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New.Click += (s, e) =>
            {
                ClearForm();
                pnl_form.Visible = true;
                lbl_form_title.Text = "Add New Rubric Level";
                txt_Details.Focus();
            };

            this.pnl_search.Controls.Add(this.lbl_filter);
            this.pnl_search.Controls.Add(this.cmb_FilterRubric);
            this.pnl_search.Controls.Add(this.btn_filter);
            this.pnl_search.Controls.Add(this.btn_Add_New);

            // ── GRID ───────────────────────────────────────
            this.pnl_grid.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Padding =
                new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnl_grid.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.dgv_Levels.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.dgv_Levels.BackgroundColor =
                System.Drawing.Color.White;
            this.dgv_Levels.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgv_Levels.RowHeadersVisible = false;
            this.dgv_Levels.AllowUserToAddRows = false;
            this.dgv_Levels.ReadOnly = true;
            this.dgv_Levels.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;
            this.dgv_Levels.MultiSelect = false;
            this.dgv_Levels.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode
                .Fill;
            this.dgv_Levels.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.dgv_Levels.ColumnHeadersHeight = 36;
            this.dgv_Levels.RowTemplate.Height = 34;
            this.dgv_Levels.GridColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgv_Levels.ColumnHeadersDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Levels.ColumnHeadersDefaultCellStyle
                .ForeColor = System.Drawing.Color.White;
            this.dgv_Levels.ColumnHeadersDefaultCellStyle
                .Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.dgv_Levels.ColumnHeadersDefaultCellStyle
                .Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgv_Levels.EnableHeadersVisualStyles = false;
            this.dgv_Levels.DefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgv_Levels.DefaultCellStyle
                .SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.dgv_Levels.DefaultCellStyle
                .SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Levels.AlternatingRowsDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
            this.dgv_Levels.CellClick +=
                new System.Windows.Forms
                .DataGridViewCellEventHandler(
                this.dgv_Levels_CellClick);

            this.pnl_grid.Controls.Add(this.dgv_Levels);

            // ── FORM PANEL ─────────────────────────────────
            this.pnl_form.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_form.Height = 220;
            this.pnl_form.BackColor =
                System.Drawing.Color.White;
            this.pnl_form.Visible = false;

            this.pnl_form_header.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_form_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_form_header.Height = 36;

            this.lbl_form_title.Text = "Add New Rubric Level";
            this.lbl_form_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_form_title.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lbl_form_title.Location =
                new System.Drawing.Point(16, 8);
            this.lbl_form_title.Size =
                new System.Drawing.Size(300, 22);
            this.pnl_form_header.Controls.Add(
                this.lbl_form_title);

            // Fields
            this.pnl_fields.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_fields.Padding =
                new System.Windows.Forms.Padding(16, 10, 16, 0);
            this.pnl_fields.BackColor =
                System.Drawing.Color.White;

            // Rubric dropdown
            this.lbl_rubric.Text = "SELECT RUBRIC *";
            this.lbl_rubric.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_rubric.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_rubric.Location =
                new System.Drawing.Point(0, 0);
            this.lbl_rubric.Size =
                new System.Drawing.Size(200, 16);

            this.cmb_Rubric.Location =
                new System.Drawing.Point(0, 18);
            this.cmb_Rubric.Size =
                new System.Drawing.Size(260, 28);
            this.cmb_Rubric.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.cmb_Rubric.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rubric.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            // Level dropdown
            this.lbl_level.Text = "MEASUREMENT LEVEL *";
            this.lbl_level.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_level.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_level.Location =
                new System.Drawing.Point(280, 0);
            this.lbl_level.Size =
                new System.Drawing.Size(180, 16);

            this.cmb_Level.Location =
                new System.Drawing.Point(280, 18);
            this.cmb_Level.Size =
                new System.Drawing.Size(120, 28);
            this.cmb_Level.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.cmb_Level.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Level.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Level.Items.AddRange(
                new object[] { 4, 3, 2, 1 });
            this.cmb_Level.SelectedIndex = 0;

            // Details field
            this.lbl_details.Text = "LEVEL DESCRIPTION *";
            this.lbl_details.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_details.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_details.Location =
                new System.Drawing.Point(0, 56);
            this.lbl_details.Size =
                new System.Drawing.Size(200, 16);

            this.txt_Details.Location =
                new System.Drawing.Point(0, 74);
            this.txt_Details.Size =
                new System.Drawing.Size(700, 60);
            this.txt_Details.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.txt_Details.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Details.Multiline = true;

            this.pnl_fields.Controls.Add(this.lbl_rubric);
            this.pnl_fields.Controls.Add(this.cmb_Rubric);
            this.pnl_fields.Controls.Add(this.lbl_level);
            this.pnl_fields.Controls.Add(this.cmb_Level);
            this.pnl_fields.Controls.Add(this.lbl_details);
            this.pnl_fields.Controls.Add(this.txt_Details);

            // Buttons
            this.pnl_buttons.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Height = 52;
            this.pnl_buttons.BackColor =
                System.Drawing.Color.White;
            this.pnl_buttons.Padding =
                new System.Windows.Forms.Padding(16, 8, 16, 8);

            MakeBtn(btn_Add, "Save Level",
                System.Drawing.Color.FromArgb(26, 35, 126), 0);
            MakeBtn(btn_Update, "Update",
                System.Drawing.Color.FromArgb(0, 121, 107), 130);
            MakeBtn(btn_Delete, "Delete",
                System.Drawing.Color.FromArgb(183, 28, 28), 240);
            MakeBtn(btn_Clear, "Cancel",
                System.Drawing.Color.FromArgb(97, 97, 97), 340);

            this.btn_Add.Click += new System.EventHandler(
                this.btn_Add_Click);
            this.btn_Update.Click += new System.EventHandler(
                this.btn_Update_Click);
            this.btn_Delete.Click += new System.EventHandler(
                this.btn_Delete_Click);
            this.btn_Clear.Click += new System.EventHandler(
                this.btn_Clear_Click);

            this.pnl_buttons.Controls.Add(this.btn_Add);
            this.pnl_buttons.Controls.Add(this.btn_Update);
            this.pnl_buttons.Controls.Add(this.btn_Delete);
            this.pnl_buttons.Controls.Add(this.btn_Clear);

            this.pnl_form.Controls.Add(this.pnl_fields);
            this.pnl_form.Controls.Add(this.pnl_buttons);
            this.pnl_form.Controls.Add(this.pnl_form_header);

            // Form setup
            this.Controls.Add(this.pnl_grid);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.pnl_header);
            this.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.ResumeLayout(false);
        }

        private void MakeBtn(
            System.Windows.Forms.Button btn,
            string text,
            System.Drawing.Color color, int x)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, 8);
            btn.Size = new System.Drawing.Size(115, 34);
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        // Control declarations
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Panel pnl_form_header;
        private System.Windows.Forms.Panel pnl_fields;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_form_title;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.Label lbl_rubric;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.TextBox txt_Details;
        private System.Windows.Forms.ComboBox cmb_FilterRubric;
        private System.Windows.Forms.ComboBox cmb_Rubric;
        private System.Windows.Forms.ComboBox cmb_Level;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_Add_New;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dgv_Levels;
    }
}