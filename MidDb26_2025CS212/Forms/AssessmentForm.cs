using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.Forms
{
    public partial class AssessmentForm : Form
    {
        private AssessmentDAL dal = new AssessmentDAL();
        private RubricDAL rubricDal = new RubricDAL();
        private int selectedAssessmentId = -1;
        private int selectedComponentId = -1;

        public AssessmentForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(AssessmentForm_Load);
        }

        private void AssessmentForm_Load(object sender, EventArgs e)
        {
            LoadRubricDropdown();
            LoadAssessments();
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

        private void LoadRubricDropdown()
        {
            try
            {
                var rubrics = rubricDal.GetAll();
                cmb_Rubric.DataSource = rubrics;
                cmb_Rubric.DisplayMember = "Details";
                cmb_Rubric.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAssessments()
        {
            try
            {
                var list = dal.GetAll();
                dgv_Assessments.DataSource = list;
                HideAssessmentColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComponents(int assessmentId)
        {
            try
            {
                var list = dal.GetComponents(assessmentId);
                dgv_Components.DataSource = list;
                HideComponentColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideAssessmentColumns()
        {
            if (dgv_Assessments.Columns["DateCreated"] != null)
                dgv_Assessments.Columns["DateCreated"]
                    .Visible = false;
        }

        private void HideComponentColumns()
        {
            if (dgv_Components.Columns["RubricId"] != null)
                dgv_Components.Columns["RubricId"].Visible = false;
            if (dgv_Components.Columns["AssessmentId"] != null)
                dgv_Components.Columns["AssessmentId"]
                    .Visible = false;
            if (dgv_Components.Columns["DateCreated"] != null)
                dgv_Components.Columns["DateCreated"]
                    .Visible = false;
            if (dgv_Components.Columns["DateUpdated"] != null)
                dgv_Components.Columns["DateUpdated"]
                    .Visible = false;
        }

        // ASSESSMENT EVENTS

        private void dgv_Assessments_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgv_Assessments.Rows[e.RowIndex];
                selectedAssessmentId =
                    Convert.ToInt32(row.Cells["Id"].Value);
                txt_Title.Text =
                    row.Cells["Title"].Value.ToString();
                txt_Marks.Text =
                    row.Cells["TotalMarks"].Value.ToString();
                txt_Weightage.Text =
                    row.Cells["TotalWeightage"].Value.ToString();
                pnl_assessment_form.Visible = true;
                lbl_af_title.Text = "Edit Assessment";
                lbl_components.Text =
                    "Components for: " +
                    row.Cells["Title"].Value.ToString();
                LoadComponents(selectedAssessmentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_assessment_Click(
            object sender, EventArgs e)
        {
            if (!ValidateAssessment()) return;
            try
            {
                dal.AddAssessment(new Assessment
                {
                    Title = txt_Title.Text.Trim(),
                    TotalMarks = Convert.ToInt32(txt_Marks.Text),
                    TotalWeightage =
                        Convert.ToInt32(txt_Weightage.Text)
                });
                MessageBox.Show(
                    "Assessment added successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearAssessmentForm();
                LoadAssessments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_assessment_Click(
            object sender, EventArgs e)
        {
            if (selectedAssessmentId == -1)
            {
                MessageBox.Show(
                    "Please select an assessment to update.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateAssessment()) return;
            try
            {
                dal.UpdateAssessment(new Assessment
                {
                    Id = selectedAssessmentId,
                    Title = txt_Title.Text.Trim(),
                    TotalMarks = Convert.ToInt32(txt_Marks.Text),
                    TotalWeightage =
                        Convert.ToInt32(txt_Weightage.Text)
                });
                MessageBox.Show(
                    "Assessment updated successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearAssessmentForm();
                LoadAssessments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_assessment_Click(
            object sender, EventArgs e)
        {
            if (selectedAssessmentId == -1)
            {
                MessageBox.Show(
                    "Please select an assessment to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show(
                "Delete this assessment and all its components?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.DeleteAssessment(selectedAssessmentId);
                    MessageBox.Show(
                        "Assessment deleted successfully!",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearAssessmentForm();
                    LoadAssessments();
                    dgv_Components.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // COMPONENT EVENTS

        private void dgv_Components_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgv_Components.Rows[e.RowIndex];
                selectedComponentId =
                    Convert.ToInt32(row.Cells["Id"].Value);
                txt_CompName.Text =
                    row.Cells["Name"].Value.ToString();
                txt_CompMarks.Text =
                    row.Cells["TotalMarks"].Value.ToString();
                int rubricId =
                    Convert.ToInt32(
                        row.Cells["RubricId"].Value);
                cmb_Rubric.SelectedValue = rubricId;
                pnl_component_form.Visible = true;
                lbl_cf_title.Text = "Edit Component";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_component_Click(
            object sender, EventArgs e)
        {
            if (!ValidateComponent()) return;
            try
            {
                dal.AddComponent(new AssessmentComponent
                {
                    Name = txt_CompName.Text.Trim(),
                    TotalMarks =
                        Convert.ToInt32(txt_CompMarks.Text),
                    RubricId = Convert.ToInt32(
                        cmb_Rubric.SelectedValue),
                    AssessmentId = selectedAssessmentId
                });
                MessageBox.Show(
                    "Component added successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearComponentForm();
                LoadComponents(selectedAssessmentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_component_Click(
            object sender, EventArgs e)
        {
            if (selectedComponentId == -1)
            {
                MessageBox.Show(
                    "Please select a component to update.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateComponent()) return;
            try
            {
                dal.UpdateComponent(new AssessmentComponent
                {
                    Id = selectedComponentId,
                    Name = txt_CompName.Text.Trim(),
                    TotalMarks =
                        Convert.ToInt32(txt_CompMarks.Text),
                    RubricId = Convert.ToInt32(
                        cmb_Rubric.SelectedValue),
                    AssessmentId = selectedAssessmentId
                });
                MessageBox.Show(
                    "Component updated successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearComponentForm();
                LoadComponents(selectedAssessmentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_component_Click(
            object sender, EventArgs e)
        {
            if (selectedComponentId == -1)
            {
                MessageBox.Show(
                    "Please select a component to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show(
                "Delete this component?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.DeleteComponent(selectedComponentId);
                    MessageBox.Show(
                        "Component deleted successfully!",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearComponentForm();
                    LoadComponents(selectedAssessmentId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // VALIDATION & HELPERS

        private bool ValidateAssessment()
        {
            if (string.IsNullOrWhiteSpace(txt_Title.Text))
            {
                MessageBox.Show("Title is required.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Marks.Text) ||
                !int.TryParse(txt_Marks.Text, out _))
            {
                MessageBox.Show(
                    "Total marks must be a valid number.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Weightage.Text) ||
                !int.TryParse(txt_Weightage.Text, out _))
            {
                MessageBox.Show(
                    "Weightage must be a valid number.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidateComponent()
        {
            if (string.IsNullOrWhiteSpace(txt_CompName.Text))
            {
                MessageBox.Show("Component name is required.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_CompMarks.Text) ||
                !int.TryParse(txt_CompMarks.Text, out _))
            {
                MessageBox.Show(
                    "Marks must be a valid number.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (cmb_Rubric.SelectedValue == null)
            {
                MessageBox.Show("Please select a rubric.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearAssessmentForm()
        {
            selectedAssessmentId = -1;
            txt_Title.Clear();
            txt_Marks.Clear();
            txt_Weightage.Clear();
            pnl_assessment_form.Visible = false;
            dgv_Assessments.ClearSelection();
        }

        private void ClearComponentForm()
        {
            selectedComponentId = -1;
            txt_CompName.Clear();
            txt_CompMarks.Clear();
            if (cmb_Rubric.Items.Count > 0)
                cmb_Rubric.SelectedIndex = 0;
            pnl_component_form.Visible = false;
            dgv_Components.ClearSelection();
        }
    }
}