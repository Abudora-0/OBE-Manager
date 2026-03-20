namespace MidDb26_2025CS212.Forms
{
    partial class StudentForm
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add_New = new System.Windows.Forms.Button();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.dgv_Students = new System.Windows.Forms.DataGridView();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.pnl_form_header = new System.Windows.Forms.Panel();
            this.lbl_form_title = new System.Windows.Forms.Label();
            this.pnl_fields = new System.Windows.Forms.Panel();
            this.lbl_fn = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_ln = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_reg = new System.Windows.Forms.Label();
            this.txt_RegNum = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── HEADER PANEL ───────────────────────────────
            this.pnl_header.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Height = 70;
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Controls.Add(this.lbl_subtitle);

            this.lbl_title.Text = "Manage Students";
            this.lbl_title.ForeColor =
                System.Drawing.Color.White;
            this.lbl_title.Font = new System.Drawing.Font(
                "Segoe UI", 15F,
                System.Drawing.FontStyle.Bold);
            this.lbl_title.Location =
                new System.Drawing.Point(20, 10);
            this.lbl_title.Size =
                new System.Drawing.Size(400, 30);

            this.lbl_subtitle.Text =
                "Add, update and manage student records";
            this.lbl_subtitle.ForeColor =
                System.Drawing.Color.FromArgb(160, 180, 230);
            this.lbl_subtitle.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.lbl_subtitle.Location =
                new System.Drawing.Point(20, 42);
            this.lbl_subtitle.Size =
                new System.Drawing.Size(400, 20);

            // ── SEARCH PANEL ───────────────────────────────
            this.pnl_search.BackColor =
                System.Drawing.Color.White;
            this.pnl_search.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_search.Height = 54;

            this.txt_Search.Location =
                new System.Drawing.Point(16, 13);
            this.txt_Search.Size =
                new System.Drawing.Size(260, 28);
            this.txt_Search.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.txt_Search.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.btn_Search.Text = "Search";
            this.btn_Search.Location =
                new System.Drawing.Point(284, 12);
            this.btn_Search.Size =
                new System.Drawing.Size(90, 30);
            this.btn_Search.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.btn_Search.ForeColor =
                System.Drawing.Color.White;
            this.btn_Search.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.btn_Search.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Click += new System.EventHandler(
                this.btn_Search_Click);

            this.btn_Add_New.Text = "+ Add New Student";
            this.btn_Add_New.Location =
                new System.Drawing.Point(386, 12);
            this.btn_Add_New.Size =
                new System.Drawing.Size(160, 30);
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
                pnl_form.Visible = true;
                lbl_form_title.Text = "Add New Student";
                txt_FirstName.Focus();
            };

            this.pnl_search.Controls.Add(this.txt_Search);
            this.pnl_search.Controls.Add(this.btn_Search);
            this.pnl_search.Controls.Add(this.btn_Add_New);

            // ── GRID PANEL ─────────────────────────────────
            this.pnl_grid.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Padding =
                new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnl_grid.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.dgv_Students.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.dgv_Students.BackgroundColor =
                System.Drawing.Color.White;
            this.dgv_Students.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgv_Students.RowHeadersVisible = false;
            this.dgv_Students.AllowUserToAddRows = false;
            this.dgv_Students.ReadOnly = true;
            this.dgv_Students.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;
            this.dgv_Students.MultiSelect = false;
            this.dgv_Students.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode
                .Fill;
            this.dgv_Students.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.dgv_Students.ColumnHeadersHeight = 36;
            this.dgv_Students.RowTemplate.Height = 34;
            this.dgv_Students.GridColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            // Header style
            this.dgv_Students.ColumnHeadersDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Students.ColumnHeadersDefaultCellStyle
                .ForeColor =
                System.Drawing.Color.White;
            this.dgv_Students.ColumnHeadersDefaultCellStyle
                .Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.dgv_Students.ColumnHeadersDefaultCellStyle
                .Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgv_Students.EnableHeadersVisualStyles = false;

            // Row style
            this.dgv_Students.DefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgv_Students.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.dgv_Students.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Students.AlternatingRowsDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.dgv_Students.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                this.dgv_Students_CellClick);

            this.pnl_grid.Controls.Add(this.dgv_Students);

            // ── FORM PANEL ─────────────────────────────────
            this.pnl_form.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_form.Height = 220;
            this.pnl_form.BackColor =
                System.Drawing.Color.White;
            this.pnl_form.Visible = false;

            // Form header bar
            this.pnl_form_header.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_form_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_form_header.Height = 36;
            this.pnl_form_header.Controls.Add(this.lbl_form_title);

            this.lbl_form_title.Text = "Add New Student";
            this.lbl_form_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_form_title.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lbl_form_title.Location =
                new System.Drawing.Point(16, 8);
            this.lbl_form_title.Size =
                new System.Drawing.Size(300, 22);

            // Fields panel
            this.pnl_fields.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_fields.Padding =
                new System.Windows.Forms.Padding(16, 10, 16, 0);
            this.pnl_fields.BackColor =
                System.Drawing.Color.White;

            // Row 1
            MakeField(lbl_fn, txt_FirstName,
                "FIRST NAME *", 0, 0);
            MakeField(lbl_ln, txt_LastName,
                "LAST NAME", 200, 0);
            MakeField(lbl_reg, txt_RegNum,
                "REG NUMBER *", 400, 0);

            // Row 2
            MakeField(lbl_email, txt_Email,
                "EMAIL *", 0, 70);
            MakeField(lbl_contact, txt_Contact,
                "CONTACT", 200, 70);

            // Status
            this.lbl_status.Text = "STATUS";
            this.lbl_status.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_status.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_status.Location =
                new System.Drawing.Point(400, 70);
            this.lbl_status.Size =
                new System.Drawing.Size(160, 16);

            this.cmb_Status.Location =
                new System.Drawing.Point(400, 90);
            this.cmb_Status.Size =
                new System.Drawing.Size(180, 28);
            this.cmb_Status.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.cmb_Status.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.pnl_fields.Controls.Add(this.lbl_fn);
            this.pnl_fields.Controls.Add(this.txt_FirstName);
            this.pnl_fields.Controls.Add(this.lbl_ln);
            this.pnl_fields.Controls.Add(this.txt_LastName);
            this.pnl_fields.Controls.Add(this.lbl_reg);
            this.pnl_fields.Controls.Add(this.txt_RegNum);
            this.pnl_fields.Controls.Add(this.lbl_email);
            this.pnl_fields.Controls.Add(this.txt_Email);
            this.pnl_fields.Controls.Add(this.lbl_contact);
            this.pnl_fields.Controls.Add(this.txt_Contact);
            this.pnl_fields.Controls.Add(this.lbl_status);
            this.pnl_fields.Controls.Add(this.cmb_Status);

            // Buttons panel
            this.pnl_buttons.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Height = 52;
            this.pnl_buttons.BackColor =
                System.Drawing.Color.White;
            this.pnl_buttons.Padding =
                new System.Windows.Forms.Padding(16, 8, 16, 8);

            MakeBtn(btn_Add, "Save Student",
                System.Drawing.Color.FromArgb(26, 35, 126), 0);
            MakeBtn(btn_Update, "Update",
                System.Drawing.Color.FromArgb(0, 121, 107), 130);
            MakeBtn(btn_Delete, "Delete",
                System.Drawing.Color.FromArgb(183, 28, 28), 240);
            MakeBtn(btn_Report, "Report",
                System.Drawing.Color.FromArgb(0, 121, 107), 460);
            MakeBtn(btn_Clear, "Cancel",
                System.Drawing.Color.FromArgb(97, 97, 97), 340);

            this.btn_Add.Click += new System.EventHandler(
                this.btn_Add_Click);
            this.btn_Update.Click += new System.EventHandler(
                this.btn_Update_Click);
            this.btn_Delete.Click += new System.EventHandler(
                this.btn_Delete_Click);
            this.btn_Report.Click += new System.EventHandler(
                this.btn_Report_Click);
            this.btn_Clear.Click += new System.EventHandler(
                this.btn_Clear_Click);

            this.pnl_buttons.Controls.Add(this.btn_Add);
            this.pnl_buttons.Controls.Add(this.btn_Update);
            this.pnl_buttons.Controls.Add(this.btn_Delete);
            this.pnl_buttons.Controls.Add(this.btn_Report);
            this.pnl_buttons.Controls.Add(this.btn_Clear);

            this.pnl_form.Controls.Add(this.pnl_fields);
            this.pnl_form.Controls.Add(this.pnl_buttons);
            this.pnl_form.Controls.Add(this.pnl_form_header);

            // ── FORM SETUP ─────────────────────────────────
            this.Controls.Add(this.pnl_grid);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.pnl_header);
            this.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.ResumeLayout(false);
        }

        private void MakeField(
            System.Windows.Forms.Label lbl,
            System.Windows.Forms.TextBox txt,
            string labelText, int x, int y)
        {
            lbl.Text = labelText;
            lbl.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            lbl.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(170, 16);

            txt.Location =
                new System.Drawing.Point(x, y + 20);
            txt.Size = new System.Drawing.Size(180, 28);
            txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            txt.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label lbl_fn;
        private System.Windows.Forms.Label lbl_ln;
        private System.Windows.Forms.Label lbl_reg;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_RegNum;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add_New;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dgv_Students;
    }
}