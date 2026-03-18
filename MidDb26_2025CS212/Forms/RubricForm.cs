using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.Forms
{
    public partial class RubricForm : Form
    {
        public RubricDAL dal = new RubricDAL();
        private CloDAL cloDal = new CloDAL();
        private int selectedId = -1;

        public RubricForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(RubricForm_Load);
        }

        private void RubricForm_Load(object sender, EventArgs e)
        {
            LoadCloDropdown();
            LoadRubrics();
        }

        private void LoadCloDropdown()
        {
            try
            {
                var clos = cloDal.GetAll();
                cmb_Clo.DataSource = clos;
                cmb_Clo.DisplayMember = "Name";
                cmb_Clo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRubrics()
        {
            try
            {
                var rubrics = dal.GetAll();
                dgv_Rubrics.DataSource = rubrics;
                HideColumns();
                lbl_subtitle.Text =
                    rubrics.Count + " rubrics found";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideColumns()
        {
            if (dgv_Rubrics.Columns["CloId"] != null)
                dgv_Rubrics.Columns["CloId"].Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                dal.Add(new Rubric
                {
                    Id = Convert.ToInt32(txt_Id.Text),
                    Details = txt_Details.Text.Trim(),
                    CloId = Convert.ToInt32(cmb_Clo.SelectedValue)
                });
                MessageBox.Show("Rubric added successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadRubrics();
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
                MessageBox.Show("Please select a rubric to update.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;
            try
            {
                dal.Update(new Rubric
                {
                    Id = selectedId,
                    Details = txt_Details.Text.Trim(),
                    CloId = Convert.ToInt32(cmb_Clo.SelectedValue)
                });
                MessageBox.Show("Rubric updated successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadRubrics();
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
                MessageBox.Show("Please select a rubric to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this rubric?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.Delete(selectedId);
                    MessageBox.Show("Rubric deleted successfully!",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                    LoadRubrics();
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
                string kw = txt_Search.Text.Trim();
                var results = string.IsNullOrEmpty(kw)
                    ? dal.GetAll() : dal.Search(kw);
                dgv_Rubrics.DataSource = results;
                HideColumns();
                lbl_subtitle.Text =
                    results.Count + " rubrics found";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Rubrics_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgv_Rubrics.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(
                    row.Cells["Id"].Value);
                txt_Id.Text = selectedId.ToString();
                txt_Details.Text =
                    row.Cells["Details"].Value.ToString();
                int cloId = Convert.ToInt32(
                    row.Cells["CloId"].Value);
                cmb_Clo.SelectedValue = cloId;
                pnl_form.Visible = true;
                lbl_form_title.Text = "Edit Rubric";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_Details.Text))
            {
                MessageBox.Show("Rubric details are required.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_Details.Focus();
                return false;
            }
            if (cmb_Clo.SelectedValue == null)
            {
                MessageBox.Show("Please select a CLO.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            selectedId = -1;
            txt_Id.Text = dal.GetNextId().ToString();
            txt_Details.Clear();
            cmb_Clo.SelectedIndex = 0;
            dgv_Rubrics.ClearSelection();
            pnl_form.Visible = false;
            lbl_form_title.Text = "Add New Rubric";
        }
    }
}