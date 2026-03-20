using System;

namespace MidDb26_2025CS212.Forms
{
    partial class AttendanceForm
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
            this.pnl_left_header = new System.Windows.Forms.Panel();
            this.pnl_right_header = new System.Windows.Forms.Panel();
            this.lbl_sessions = new System.Windows.Forms.Label();
            this.lbl_attendance = new System.Windows.Forms.Label();
            this.btn_new_session = new System.Windows.Forms.Button();
            this.btn_delete_session = new System.Windows.Forms.Button();
            this.btn_save_attendance = new System.Windows.Forms.Button();
            this.dgv_Sessions = new System.Windows.Forms.DataGridView();
            this.dgv_Attendance = new System.Windows.Forms.DataGridView();
            this.pnl_date_picker = new System.Windows.Forms.Panel();
            this.lbl_pick_date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_create_session = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── HEADER ─────────────────────────────────────
            this.pnl_header.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.pnl_header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Height = 70;

            this.lbl_title.Text = "Attendance Management";
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
                "Track and manage student attendance";
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
                new System.Drawing.Point(820, 18);
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

            // ── BODY ───────────────────────────────────────
            this.pnl_body.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            // ── LEFT PANEL ─────────────────────────────────
            this.pnl_left.Location =
                new System.Drawing.Point(10, 10);
            this.pnl_left.Size =
                new System.Drawing.Size(300, 550);
            this.pnl_left.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom;
            this.pnl_left.BackColor =
                System.Drawing.Color.White;

            // Left header
            this.pnl_left_header.Location =
                new System.Drawing.Point(0, 0);
            this.pnl_left_header.Size =
                new System.Drawing.Size(300, 46);
            this.pnl_left_header.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);

            this.lbl_sessions.Text = "Sessions";
            this.lbl_sessions.Font = new System.Drawing.Font(
                "Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.lbl_sessions.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_sessions.Location =
                new System.Drawing.Point(12, 12);
            this.lbl_sessions.Size =
                new System.Drawing.Size(120, 24);

            this.btn_new_session.Text = "+ New";
            this.btn_new_session.Location =
                new System.Drawing.Point(150, 10);
            this.btn_new_session.Size =
                new System.Drawing.Size(65, 28);
            this.btn_new_session.BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.btn_new_session.ForeColor =
                System.Drawing.Color.White;
            this.btn_new_session.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_session.FlatAppearance.BorderSize = 0;
            this.btn_new_session.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_new_session.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_new_session.Click +=
                new System.EventHandler(
                this.btn_new_session_Click);

            this.btn_delete_session.Text = "Delete";
            this.btn_delete_session.Location =
                new System.Drawing.Point(222, 10);
            this.btn_delete_session.Size =
                new System.Drawing.Size(65, 28);
            this.btn_delete_session.BackColor =
                System.Drawing.Color.FromArgb(183, 28, 28);
            this.btn_delete_session.ForeColor =
                System.Drawing.Color.White;
            this.btn_delete_session.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_session.FlatAppearance.BorderSize = 0;
            this.btn_delete_session.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_delete_session.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_delete_session.Click +=
                new System.EventHandler(
                this.btn_delete_session_Click);

            this.pnl_left_header.Controls.Add(
                this.lbl_sessions);
            this.pnl_left_header.Controls.Add(
                this.btn_new_session);
            this.pnl_left_header.Controls.Add(
                this.btn_delete_session);

            // Sessions grid
            this.dgv_Sessions.Location =
                new System.Drawing.Point(0, 46);
            this.dgv_Sessions.Size =
                new System.Drawing.Size(300, 410);
            this.dgv_Sessions.BackgroundColor =
                System.Drawing.Color.White;
            this.dgv_Sessions.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgv_Sessions.RowHeadersVisible = false;
            this.dgv_Sessions.AllowUserToAddRows = false;
            this.dgv_Sessions.ReadOnly = true;
            this.dgv_Sessions.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;
            this.dgv_Sessions.MultiSelect = false;
            this.dgv_Sessions.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode
                .Fill;
            this.dgv_Sessions.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.dgv_Sessions.ColumnHeadersHeight = 34;
            this.dgv_Sessions.RowTemplate.Height = 32;
            this.dgv_Sessions.GridColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgv_Sessions.ColumnHeadersDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Sessions.ColumnHeadersDefaultCellStyle
                .ForeColor = System.Drawing.Color.White;
            this.dgv_Sessions.ColumnHeadersDefaultCellStyle
                .Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.dgv_Sessions.EnableHeadersVisualStyles = false;
            this.dgv_Sessions.DefaultCellStyle
                .SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.dgv_Sessions.DefaultCellStyle
                .SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Sessions.CellClick +=
                new System.Windows.Forms
                .DataGridViewCellEventHandler(
                this.dgv_Sessions_CellClick);

            // Date picker panel
            this.pnl_date_picker.Location =
                new System.Drawing.Point(0, 456);
            this.pnl_date_picker.Size =
                new System.Drawing.Size(300, 94);
            this.pnl_date_picker.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.pnl_date_picker.Visible = false;

            this.lbl_pick_date.Text = "SELECT DATE:";
            this.lbl_pick_date.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_pick_date.Font = new System.Drawing.Font(
                "Segoe UI", 8F,
                System.Drawing.FontStyle.Bold);
            this.lbl_pick_date.Location =
                new System.Drawing.Point(10, 10);
            this.lbl_pick_date.Size =
                new System.Drawing.Size(100, 16);

            this.dtp_Date.Location =
                new System.Drawing.Point(10, 28);
            this.dtp_Date.Size =
                new System.Drawing.Size(180, 28);
            this.dtp_Date.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.dtp_Date.Format =
                System.Windows.Forms.DateTimePickerFormat
                .Short;
            this.dtp_Date.Value = DateTime.Today;

            this.btn_create_session.Text = "Create";
            this.btn_create_session.Location =
                new System.Drawing.Point(10, 58);
            this.btn_create_session.Size =
                new System.Drawing.Size(80, 28);
            this.btn_create_session.BackColor =
                System.Drawing.Color.FromArgb(0, 121, 107);
            this.btn_create_session.ForeColor =
                System.Drawing.Color.White;
            this.btn_create_session.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_session.FlatAppearance.BorderSize = 0;
            this.btn_create_session.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_create_session.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_create_session.Click +=
                new System.EventHandler(
                this.btn_create_session_Click);

            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Location =
                new System.Drawing.Point(100, 58);
            this.btn_cancel.Size =
                new System.Drawing.Size(80, 28);
            this.btn_cancel.BackColor =
                System.Drawing.Color.FromArgb(97, 97, 97);
            this.btn_cancel.ForeColor =
                System.Drawing.Color.White;
            this.btn_cancel.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.Font = new System.Drawing.Font(
                "Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_cancel.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Click +=
                new System.EventHandler(
                this.btn_cancel_Click);

            this.pnl_date_picker.Controls.Add(
                this.lbl_pick_date);
            this.pnl_date_picker.Controls.Add(this.dtp_Date);
            this.pnl_date_picker.Controls.Add(
                this.btn_create_session);
            this.pnl_date_picker.Controls.Add(this.btn_cancel);

            this.pnl_left.Controls.Add(this.pnl_left_header);
            this.pnl_left.Controls.Add(this.dgv_Sessions);
            this.pnl_left.Controls.Add(this.pnl_date_picker);

            // ── RIGHT PANEL ────────────────────────────────
            this.pnl_right.Location =
                new System.Drawing.Point(320, 10);
            this.pnl_right.Size =
                new System.Drawing.Size(650, 550);
            this.pnl_right.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.pnl_right.BackColor =
                System.Drawing.Color.White;

            // Right header
            this.pnl_right_header.Location =
                new System.Drawing.Point(0, 0);
            this.pnl_right_header.Size =
                new System.Drawing.Size(650, 46);
            this.pnl_right_header.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);

            this.lbl_attendance.Text =
                "Select a session from the left";
            this.lbl_attendance.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lbl_attendance.ForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.lbl_attendance.Location =
                new System.Drawing.Point(12, 12);
            this.lbl_attendance.Size =
                new System.Drawing.Size(380, 24);

            this.btn_save_attendance.Text = "Save Attendance";
            this.btn_save_attendance.Location =
                new System.Drawing.Point(490, 10);
            this.btn_save_attendance.Size =
                new System.Drawing.Size(150, 28);
            this.btn_save_attendance.BackColor =
                System.Drawing.Color.FromArgb(0, 121, 107);
            this.btn_save_attendance.ForeColor =
                System.Drawing.Color.White;
            this.btn_save_attendance.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_attendance.FlatAppearance
                .BorderSize = 0;
            this.btn_save_attendance.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btn_save_attendance.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_save_attendance.Click +=
                new System.EventHandler(
                this.btn_save_attendance_Click);

            this.pnl_right_header.Controls.Add(
                this.lbl_attendance);
            this.pnl_right_header.Controls.Add(
                this.btn_save_attendance);

            // Attendance grid
            this.dgv_Attendance.Location =
                new System.Drawing.Point(0, 46);
            this.dgv_Attendance.Size =
                new System.Drawing.Size(650, 504);
            this.dgv_Attendance.BackgroundColor =
                System.Drawing.Color.White;
            this.dgv_Attendance.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgv_Attendance.RowHeadersVisible = false;
            this.dgv_Attendance.AllowUserToAddRows = false;
            this.dgv_Attendance.ReadOnly = false;
            this.dgv_Attendance.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;
            this.dgv_Attendance.MultiSelect = false;
            this.dgv_Attendance.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode
                .Fill;
            this.dgv_Attendance.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.dgv_Attendance.ColumnHeadersHeight = 34;
            this.dgv_Attendance.RowTemplate.Height = 34;
            this.dgv_Attendance.GridColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgv_Attendance.ColumnHeadersDefaultCellStyle
                .BackColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Attendance.ColumnHeadersDefaultCellStyle
                .ForeColor = System.Drawing.Color.White;
            this.dgv_Attendance.ColumnHeadersDefaultCellStyle
                .Font = new System.Drawing.Font(
                "Segoe UI", 9.5F,
                System.Drawing.FontStyle.Bold);
            this.dgv_Attendance.EnableHeadersVisualStyles =
                false;
            this.dgv_Attendance.DefaultCellStyle
                .SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);
            this.dgv_Attendance.DefaultCellStyle
                .SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 35, 126);
            this.dgv_Attendance.EditMode =
                System.Windows.Forms.DataGridViewEditMode
                .EditOnEnter;

            this.pnl_right.Controls.Add(this.dgv_Attendance);
            this.pnl_right.Controls.Add(
                this.pnl_right_header);

            // Body
            this.pnl_body.Controls.Add(this.pnl_right);
            this.pnl_body.Controls.Add(this.pnl_left);

            // Main form
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_header);
            this.BackColor =
                System.Drawing.Color.FromArgb(248, 249, 252);

            this.ResumeLayout(false);
        }

        // Control declarations
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_left_header;
        private System.Windows.Forms.Panel pnl_right_header;
        private System.Windows.Forms.Panel pnl_date_picker;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_sessions;
        private System.Windows.Forms.Label lbl_attendance;
        private System.Windows.Forms.Label lbl_pick_date;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_new_session;
        private System.Windows.Forms.Button btn_delete_session;
        private System.Windows.Forms.Button btn_save_attendance;
        private System.Windows.Forms.Button btn_create_session;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dgv_Sessions;
        private System.Windows.Forms.DataGridView dgv_Attendance;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}