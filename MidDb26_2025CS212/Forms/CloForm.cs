using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.Forms
{
    public partial class CloForm : Form
    {
        private CloDAL dal = new CloDAL();
        private int selectedId = -1;

        public CloForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(CloForm_Load);
        }

        private void CloForm_Load(object sender, EventArgs e)
        {
            LoadClos();
        }

        private void LoadClos()
        {
            try
            {
                var clos = dal.GetAll();
                dgv_Clos.DataSource = clos;
                HideColumns();
                lbl_subtitle.Text = clos.Count + " CLOs found";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideColumns()
        {
            if (dgv_Clos.Columns["DateCreated"] != null)
                dgv_Clos.Columns["DateCreated"].Visible = false;
            if (dgv_Clos.Columns["DateUpdated"] != null)
                dgv_Clos.Columns["DateUpdated"].Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                dal.Add(new Clo { Name = txt_Name.Text.Trim() });
                MessageBox.Show("CLO added successfully!", "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadClos();
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
                MessageBox.Show("Please select a CLO to update.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;
            try
            {
                dal.Update(new Clo
                {
                    Id = selectedId,
                    Name = txt_Name.Text.Trim()
                });
                MessageBox.Show("CLO updated successfully!", "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadClos();
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
                MessageBox.Show("Please select a CLO to delete.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this CLO?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.Delete(selectedId);
                    MessageBox.Show("CLO deleted successfully!",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                    LoadClos();
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
                    ? dal.GetAll()
                    : dal.Search(kw);
                dgv_Clos.DataSource = results;
                HideColumns();
                lbl_subtitle.Text = results.Count + " CLOs found";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Clos_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgv_Clos.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(
                    row.Cells["Id"].Value);
                txt_Name.Text =
                    row.Cells["Name"].Value.ToString();
                pnl_form.Visible = true;
                lbl_form_title.Text = "Edit CLO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("CLO name is required.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_Name.Focus();
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            selectedId = -1;
            txt_Name.Clear();
            dgv_Clos.ClearSelection();
            pnl_form.Visible = false;
            lbl_form_title.Text = "Add New CLO";
        }
    }
}