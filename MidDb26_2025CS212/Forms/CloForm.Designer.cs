namespace MidDb26_2025CS212.Forms
{
    partial class CloForm
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
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add_New = new System.Windows.Forms.Button();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.dgv_Clos = new System.Windows.Forms.DataGridView();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.pnl_form_header = new System.Windows.Forms.Panel();
            this.lbl_form_title = new System.Windows.Forms.Label();
            this.pnl_fields = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // HEADER 
            this.pnl_header.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Height = 70;
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Controls.Add(this.lbl_subtitle);

            this.lbl_title.Text = "Manage CLOs";
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
                "Manage Course Learning Outcomes";
            this.lbl_subtitle.ForeColor =
                System.Drawing.Color.FromArgb(160, 180, 230);
            this.lbl_subtitle.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.lbl_subtitle.Location =
                new System.Drawing.Point(20, 42);
            this.lbl_subtitle.Size =
                new System.Drawing.Size(400, 20);

            this.btn_home.Text = "⌂ Dashboard";
            this.btn_home.Location =
                new System.Drawing.Point(850, 18);
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

            this.btn_Add_New.Text = "+ Add New CLO";
            this.btn_Add_New.Location =
                new System.Drawing.Point(386, 12);
            this.btn_Add_New.Size =
                new System.Drawing.Size(140, 30);
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
                lbl_form_title.Text = "Add New CLO";
                txt_Name.Focus();
            };

            this.pnl_search.Controls.Add(this.txt_Search);
            this.pnl_search.Controls.Add(this.btn_Search);
            this.pnl_search.Controls.Add(this.btn_Add_New);

            // GRID 
            this.pnl_grid.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Padding =
                new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnl_grid.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.dgv_Clos.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.dgv_Clos.BackgroundColor =
                System.Drawing.Color.White;
            this.dgv_Clos.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgv_Clos.RowHeadersVisible = false;
            this.dgv_Clos.AllowUserToAddRows = false;
            this.dgv_Clos.ReadOnly = true;
            this.dgv_Clos.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;
            this.dgv_Clos.MultiSelect = false;
            this.dgv_Clos.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode
                .Fill;
            this.dgv_Clos.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.dgv_Clos.ColumnHeadersHeight = 36;
            this.dgv_Clos.RowTemplate.Height = 34;
            this.dgv_Clos.GridColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgv_Clos.ColumnHeadersDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Clos.ColumnHeadersDefaultCellStyle
                .ForeColor = System.Drawing.Color.White;
            this.dgv_Clos.ColumnHeadersDefaultCellStyle
                .Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.dgv_Clos.ColumnHeadersDefaultCellStyle
                .Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgv_Clos.EnableHeadersVisualStyles = false;
            this.dgv_Clos.DefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgv_Clos.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.dgv_Clos.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Clos.AlternatingRowsDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);
            this.dgv_Clos.CellClick +=
                new System.Windows.Forms
                .DataGridViewCellEventHandler(
                this.dgv_Clos_CellClick);

            this.pnl_grid.Controls.Add(this.dgv_Clos);

            // FORM PANEL
            this.pnl_form.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_form.Height = 160;
            this.pnl_form.BackColor =
                System.Drawing.Color.White;
            this.pnl_form.Visible = false;

            this.pnl_form_header.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_form_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_form_header.Height = 36;
            this.pnl_form_header.Controls.Add(
                this.lbl_form_title);

            this.lbl_form_title.Text = "Add New CLO";
            this.lbl_form_title.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_form_title.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lbl_form_title.Location =
                new System.Drawing.Point(16, 8);
            this.lbl_form_title.Size =
                new System.Drawing.Size(300, 22);

            // Fields
            this.pnl_fields.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_fields.Padding =
                new System.Windows.Forms.Padding(16, 10, 16, 0);
            this.pnl_fields.BackColor =
                System.Drawing.Color.White;

            this.lbl_name.Text = "CLO NAME *";
            this.lbl_name.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_name.Font = new System.Drawing.Font(
                "Segoe UI", 7.5F,
                System.Drawing.FontStyle.Bold);
            this.lbl_name.Location =
                new System.Drawing.Point(0, 0);
            this.lbl_name.Size =
                new System.Drawing.Size(400, 16);

            this.txt_Name.Location =
                new System.Drawing.Point(0, 20);
            this.txt_Name.Size =
                new System.Drawing.Size(500, 28);
            this.txt_Name.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.txt_Name.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnl_fields.Controls.Add(this.lbl_name);
            this.pnl_fields.Controls.Add(this.txt_Name);

            // Buttons
            this.pnl_buttons.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Height = 52;
            this.pnl_buttons.BackColor =
                System.Drawing.Color.White;
            this.pnl_buttons.Padding =
                new System.Windows.Forms.Padding(16, 8, 16, 8);

            MakeBtn(btn_Add, "Save CLO",
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
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add_New;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dgv_Clos;
    }
}