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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Students = new System.Windows.Forms.DataGridView();
            this.pnl_form = new System.Windows.Forms.Panel();
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.pnl_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.txt_Search);
            this.pnl_top.Controls.Add(this.btn_Search);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1010, 50);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(15, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(300, 28);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Manage Students";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(550, 13);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(200, 22);
            this.txt_Search.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(760, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 28);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_Students
            // 
            this.dgv_Students.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Students.ColumnHeadersHeight = 29;
            this.dgv_Students.Location = new System.Drawing.Point(10, 60);
            this.dgv_Students.Name = "dgv_Students";
            this.dgv_Students.RowHeadersWidth = 51;
            this.dgv_Students.Size = new System.Drawing.Size(1588, 280);
            this.dgv_Students.TabIndex = 1;
            this.dgv_Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Students_CellClick);
            // 
            // pnl_form
            // 
            this.pnl_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_form.Controls.Add(this.lbl_fn);
            this.pnl_form.Controls.Add(this.txt_FirstName);
            this.pnl_form.Controls.Add(this.lbl_ln);
            this.pnl_form.Controls.Add(this.txt_LastName);
            this.pnl_form.Controls.Add(this.lbl_reg);
            this.pnl_form.Controls.Add(this.txt_RegNum);
            this.pnl_form.Controls.Add(this.lbl_email);
            this.pnl_form.Controls.Add(this.txt_Email);
            this.pnl_form.Controls.Add(this.lbl_contact);
            this.pnl_form.Controls.Add(this.txt_Contact);
            this.pnl_form.Controls.Add(this.lbl_status);
            this.pnl_form.Controls.Add(this.cmb_Status);
            this.pnl_form.Controls.Add(this.btn_Add);
            this.pnl_form.Controls.Add(this.btn_Update);
            this.pnl_form.Controls.Add(this.btn_Delete);
            this.pnl_form.Controls.Add(this.btn_Clear);
            this.pnl_form.Location = new System.Drawing.Point(10, 350);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(860, 230);
            this.pnl_form.TabIndex = 2;
            // 
            // lbl_fn
            // 
            this.lbl_fn.Location = new System.Drawing.Point(15, 15);
            this.lbl_fn.Name = "lbl_fn";
            this.lbl_fn.Size = new System.Drawing.Size(90, 20);
            this.lbl_fn.TabIndex = 0;
            this.lbl_fn.Text = "First Name *";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(15, 38);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(180, 22);
            this.txt_FirstName.TabIndex = 1;
            // 
            // lbl_ln
            // 
            this.lbl_ln.Location = new System.Drawing.Point(215, 15);
            this.lbl_ln.Name = "lbl_ln";
            this.lbl_ln.Size = new System.Drawing.Size(80, 20);
            this.lbl_ln.TabIndex = 2;
            this.lbl_ln.Text = "Last Name";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(215, 38);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(180, 22);
            this.txt_LastName.TabIndex = 3;
            // 
            // lbl_reg
            // 
            this.lbl_reg.Location = new System.Drawing.Point(415, 15);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(100, 20);
            this.lbl_reg.TabIndex = 4;
            this.lbl_reg.Text = "Reg Number *";
            // 
            // txt_RegNum
            // 
            this.txt_RegNum.Location = new System.Drawing.Point(415, 38);
            this.txt_RegNum.Name = "txt_RegNum";
            this.txt_RegNum.Size = new System.Drawing.Size(180, 22);
            this.txt_RegNum.TabIndex = 5;
            // 
            // lbl_email
            // 
            this.lbl_email.Location = new System.Drawing.Point(15, 75);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(80, 20);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email *";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(15, 98);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(180, 22);
            this.txt_Email.TabIndex = 7;
            // 
            // lbl_contact
            // 
            this.lbl_contact.Location = new System.Drawing.Point(215, 75);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(80, 20);
            this.lbl_contact.TabIndex = 8;
            this.lbl_contact.Text = "Contact";
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(215, 98);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(180, 22);
            this.txt_Contact.TabIndex = 9;
            // 
            // lbl_status
            // 
            this.lbl_status.Location = new System.Drawing.Point(415, 75);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(80, 20);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status";
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.Location = new System.Drawing.Point(415, 98);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(180, 24);
            this.cmb_Status.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(15, 155);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 35);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add Student";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(145, 155);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 35);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(255, 155);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 35);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(365, 155);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 35);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(1010, 573);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.dgv_Students);
            this.Controls.Add(this.pnl_form);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Students";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.ResumeLayout(false);

        }

        // ── CONTROL DECLARATIONS ───────────────────────────
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Students;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Label lbl_fn;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_ln;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_reg;
        private System.Windows.Forms.TextBox txt_RegNum;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
    }
}