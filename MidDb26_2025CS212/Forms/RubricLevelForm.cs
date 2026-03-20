using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.Forms
{
    public partial class RubricLevelForm : Form
    {
        private RubricLevelDAL dal = new RubricLevelDAL();
        private RubricDAL rubricDal = new RubricDAL();
        private int selectedId = -1;

        public RubricLevelForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(RubricLevelForm_Load);
        }

        private void RubricLevelForm_Load(object sender, EventArgs e)
        {
            LoadRubricDropdowns();
            LoadLevels();
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

        private void LoadRubricDropdowns()
        {
            try
            {
                var rubrics = rubricDal.GetAll();

                // Filter dropdown — add "All Rubrics" option first
                var filterList = new List<Rubric>(rubrics);
                filterList.Insert(0, new Rubric
                {
                    Id = -1,
                    Details = "All Rubrics"
                });
                cmb_FilterRubric.DataSource = filterList;
                cmb_FilterRubric.DisplayMember = "Details";
                cmb_FilterRubric.ValueMember = "Id";
                cmb_FilterRubric.SelectedIndex = 0;

                // Form dropdown
                cmb_Rubric.DataSource = new List<Rubric>(rubrics);
                cmb_Rubric.DisplayMember = "Details";
                cmb_Rubric.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLevels()
        {
            try
            {
                var levels = dal.GetAll();
                dgv_Levels.DataSource = levels;
                HideColumns();
                lbl_subtitle.Text =
                    levels.Count + " rubric levels found";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideColumns()
        {
            if (dgv_Levels.Columns["RubricId"] != null)
                dgv_Levels.Columns["RubricId"].Visible = false;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_FilterRubric.SelectedValue == null)
                    return;

                int rubricId =
                    Convert.ToInt32(
                        cmb_FilterRubric.SelectedValue);

                List<RubricLevel> levels;
                if (rubricId == -1)
                    levels = dal.GetAll();
                else
                    levels = dal.GetByRubric(rubricId);

                dgv_Levels.DataSource = levels;
                HideColumns();
                lbl_subtitle.Text =
                    levels.Count + " rubric levels found";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                dal.Add(new RubricLevel
                {
                    RubricId = Convert.ToInt32(
                        cmb_Rubric.SelectedValue),
                    MeasurementLevel =
                        Convert.ToInt32(cmb_Level.SelectedItem),
                    Details = txt_Details.Text.Trim()
                });
                MessageBox.Show(
                    "Rubric level added successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadLevels();
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
                MessageBox.Show(
                    "Please select a level to update.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;
            try
            {
                dal.Update(new RubricLevel
                {
                    Id = selectedId,
                    RubricId = Convert.ToInt32(
                        cmb_Rubric.SelectedValue),
                    MeasurementLevel =
                        Convert.ToInt32(cmb_Level.SelectedItem),
                    Details = txt_Details.Text.Trim()
                });
                MessageBox.Show(
                    "Rubric level updated successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadLevels();
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
                MessageBox.Show(
                    "Please select a level to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show(
                "Delete this rubric level?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.Delete(selectedId);
                    MessageBox.Show(
                        "Rubric level deleted successfully!",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                    LoadLevels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgv_Levels_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgv_Levels.Rows[e.RowIndex];
                selectedId =
                    Convert.ToInt32(row.Cells["Id"].Value);
                txt_Details.Text =
                    row.Cells["Details"].Value.ToString();
                int rubricId =
                    Convert.ToInt32(
                        row.Cells["RubricId"].Value);
                cmb_Rubric.SelectedValue = rubricId;
                int level =
                    Convert.ToInt32(
                        row.Cells["MeasurementLevel"].Value);
                cmb_Level.SelectedItem = level;
                pnl_form.Visible = true;
                lbl_form_title.Text = "Edit Rubric Level";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (cmb_Rubric.SelectedValue == null)
            {
                MessageBox.Show("Please select a rubric.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Details.Text))
            {
                MessageBox.Show("Description is required.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_Details.Focus();
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            selectedId = -1;
            txt_Details.Clear();
            if (cmb_Rubric.Items.Count > 0)
                cmb_Rubric.SelectedIndex = 0;
            cmb_Level.SelectedIndex = 0;
            dgv_Levels.ClearSelection();
            pnl_form.Visible = false;
            lbl_form_title.Text = "Add New Rubric Level";
        }
    }
}