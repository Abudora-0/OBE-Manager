using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.Forms
{
    public partial class StudentForm : Form
    {
        private StudentDAL dal = new StudentDAL();
        private int selectedId = -1;

        public StudentForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(StudentForm_Load);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadStatusDropdown();
            LoadStudents();
        }

        private void SetupGrid()
        {
            dgv_Students.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Students.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgv_Students.MultiSelect = false;
            dgv_Students.ReadOnly = true;
            dgv_Students.AllowUserToAddRows = false;
            dgv_Students.BackgroundColor = System.Drawing.Color.White;
            dgv_Students.BorderStyle = BorderStyle.None;
            dgv_Students.RowHeadersVisible = false;
            dgv_Students.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void LoadStatusDropdown()
        {
            try
            {
                var statuses = dal.GetStatusLookup();
                cmb_Status.DataSource = statuses;
                cmb_Status.DisplayMember = "Name";
                cmb_Status.ValueMember = "LookupId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                var students = dal.GetAllStudents();
                dgv_Students.DataSource = students;
                HideColumns();
                UpdateRecordCount(students.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideColumns()
        {
            if (dgv_Students.Columns["Status"] != null)
                dgv_Students.Columns["Status"].Visible = false;
        }

        private void UpdateRecordCount(int count)
        {
            lbl_title.Text = "Manage Students (" + count + " records)";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                Student s = GetStudentFromForm();
                dal.Add(s);
                MessageBox.Show("Student added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a student to update.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;
            try
            {
                Student s = GetStudentFromForm();
                s.Id = selectedId;
                dal.Update(s);
                MessageBox.Show("Student updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a student to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.Delete(selectedId);
                    MessageBox.Show("Student deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();
                List<Student> results;

                if (string.IsNullOrEmpty(keyword))
                    results = dal.GetAllStudents();
                else
                    results = dal.Search(keyword);

                dgv_Students.DataSource = results;
                HideColumns();
                UpdateRecordCount(results.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Students_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgv_Students.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txt_FirstName.Text = row.Cells["FirstName"].Value.ToString();
                txt_LastName.Text = row.Cells["LastName"].Value.ToString();
                txt_RegNum.Text = row.Cells["RegistrationNumber"]
                    .Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_Contact.Text = row.Cells["Contact"].Value.ToString();
                int statusId = Convert.ToInt32(row.Cells["Status"].Value);
                cmb_Status.SelectedValue = statusId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Student GetStudentFromForm()
        {
            return new Student
            {
                FirstName = txt_FirstName.Text.Trim(),
                LastName = txt_LastName.Text.Trim(),
                RegistrationNumber = txt_RegNum.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                Contact = txt_Contact.Text.Trim(),
                Status = Convert.ToInt32(cmb_Status.SelectedValue)
            };
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_FirstName.Text))
            {
                MessageBox.Show("First name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_FirstName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_RegNum.Text))
            {
                MessageBox.Show("Registration number is required.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_RegNum.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("Email is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            selectedId = -1;
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_RegNum.Clear();
            txt_Email.Clear();
            txt_Contact.Clear();
            cmb_Status.SelectedIndex = 0;
            dgv_Students.ClearSelection();
        }
    }
}