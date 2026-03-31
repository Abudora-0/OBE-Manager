using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.Forms
{
    public partial class AttendanceForm : Form
    {
        private AttendanceDAL dal = new AttendanceDAL();
        private int selectedSessionId = -1;
        private List<Lookup> statuses =
            new List<Lookup>();

        public AttendanceForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(
                AttendanceForm_Load);
        }

        private void AttendanceForm_Load(
            object sender, EventArgs e)
        {
            statuses = dal.GetAttendanceStatuses();
            LoadSessions();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // Navigate back to dashboard
            Form parentForm = this.ParentForm;
            if (parentForm is MainForm main)
            {
                main.ShowDashboard();
            }
        }

        // SESSION MANAGEMENT

        private void LoadSessions()
        {
            try
            {
                var sessions = dal.GetAllSessions();
                dgv_Sessions.DataSource = sessions;
                lbl_sessions.Text =
                    "Sessions (" + sessions.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_new_session_Click(
            object sender, EventArgs e)
        {
            pnl_date_picker.Visible = true;
            dtp_Date.Value = DateTime.Today;
        }

        private void btn_create_session_Click(
            object sender, EventArgs e)
        {
            try
            {
                int newId =
                    dal.CreateSession(dtp_Date.Value.Date);
                pnl_date_picker.Visible = false;
                LoadSessions();
                lbl_attendance.Text =
                    "Attendance: " +
                    dtp_Date.Value.Date
                    .ToString("dd MMM yyyy - dddd");
                LoadAttendance(newId);
                MessageBox.Show(
                    "Session created successfully!\n" +
                    "Now mark attendance for each student.",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(
            object sender, EventArgs e)
        {
            pnl_date_picker.Visible = false;
        }

        private void btn_delete_session_Click(
            object sender, EventArgs e)
        {
            if (selectedSessionId == -1)
            {
                MessageBox.Show(
                    "Please select a session to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show(
                "Delete this session and all its records?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.DeleteSession(selectedSessionId);
                    selectedSessionId = -1;
                    dgv_Attendance.DataSource = null;
                    dgv_Attendance.Columns.Clear();
                    lbl_attendance.Text =
                        "Select a session from the left";
                    LoadSessions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_Sessions_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgv_Sessions.Rows[e.RowIndex];
                selectedSessionId =
                    Convert.ToInt32(
                        row.Cells["Id"].Value);
                DateTime date =
                    (DateTime)row.Cells[
                        "AttendanceDate"].Value;
                lbl_attendance.Text =
                    "Attendance: " +
                    date.ToString("dd MMM yyyy - dddd");
                LoadAttendance(selectedSessionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ATTENDANCE 

        private void LoadAttendance(int sessionId)
        {
            try
            {
                selectedSessionId = sessionId;
                var attendance =
                    dal.GetSessionAttendance(sessionId);

                dgv_Attendance.DataSource = null;
                dgv_Attendance.Columns.Clear();

                // Student ID column hidden
                dgv_Attendance.Columns.Add(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "StudentId",
                        HeaderText = "ID",
                        DataPropertyName = "StudentId",
                        Width = 50,
                        ReadOnly = true,
                        Visible = false
                    });

                // Name column
                dgv_Attendance.Columns.Add(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "StudentName",
                        HeaderText = "Student Name",
                        DataPropertyName = "StudentName",
                        ReadOnly = true
                    });

                // Reg number column
                dgv_Attendance.Columns.Add(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "RegistrationNumber",
                        HeaderText = "Reg Number",
                        DataPropertyName =
                            "RegistrationNumber",
                        ReadOnly = true,
                        Width = 130
                    });

                // Status dropdown column
                DataGridViewComboBoxColumn statusCol =
                    new DataGridViewComboBoxColumn();
                statusCol.Name = "Status";
                statusCol.HeaderText = "Status";
                statusCol.DataPropertyName = "StatusId";
                statusCol.DataSource =
                    new List<Lookup>(statuses);
                statusCol.DisplayMember = "Name";
                statusCol.ValueMember = "LookupId";
                statusCol.Width = 160;
                dgv_Attendance.Columns.Add(statusCol);

                dgv_Attendance.DataSource = attendance;

                // Color rows by status
                foreach (DataGridViewRow row in
                    dgv_Attendance.Rows)
                    ColorRow(row);

                dgv_Attendance.CellValueChanged +=
                    (s, ev) =>
                    {
                        if (ev.RowIndex >= 0 &&
                            ev.ColumnIndex ==
                            dgv_Attendance.Columns[
                                "Status"].Index)
                            ColorRow(dgv_Attendance
                                .Rows[ev.RowIndex]);
                    };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ColorRow(DataGridViewRow row)
        {
            try
            {
                if (row.Cells["Status"].Value == null)
                    return;
                int statusId = Convert.ToInt32(
                    row.Cells["Status"].Value);
                Color bg;
                switch (statusId)
                {
                    case 1: // Present - green
                        bg = Color.FromArgb(232, 245, 233);
                        break;
                    case 2: // Absent - red
                        bg = Color.FromArgb(255, 235, 238);
                        break;
                    case 3: // Leave - yellow
                        bg = Color.FromArgb(255, 248, 225);
                        break;
                    case 4: // Late - blue
                        bg = Color.FromArgb(232, 240, 254);
                        break;
                    default:
                        bg = Color.White;
                        break;
                }
                row.DefaultCellStyle.BackColor = bg;
            }
            catch { }
        }

        private void btn_save_attendance_Click(
            object sender, EventArgs e)
        {
            if (selectedSessionId == -1)
            {
                MessageBox.Show(
                    "Please select a session first!",
                    "No Session", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int saved = 0;
                foreach (DataGridViewRow row in
                    dgv_Attendance.Rows)
                {
                    if (row.IsNewRow) continue;
                    int studentId = Convert.ToInt32(
                        row.Cells["StudentId"].Value);
                    int statusId = Convert.ToInt32(
                        row.Cells["Status"].Value);
                    dal.SaveAttendance(
                        selectedSessionId,
                        studentId, statusId);
                    saved++;
                }
                MessageBox.Show(
                    saved + " records saved successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}