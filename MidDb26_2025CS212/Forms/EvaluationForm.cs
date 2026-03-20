using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MidDb26_2025CS212.DAL;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.Forms
{
    public partial class EvaluationForm : Form
    {
        private EvaluationDAL dal = new EvaluationDAL();
        private List<AssessmentComponent> currentComponents =
            new List<AssessmentComponent>();
        private Dictionary<int, ComboBox> levelDropdowns =
            new Dictionary<int, ComboBox>();

        public EvaluationForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(EvaluationForm_Load);
        }

        private void EvaluationForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadAssessments();
        }

        private void LoadStudents()
        {
            try
            {
                var students = dal.GetStudents();
                cmb_Student.DataSource = students;
                cmb_Student.DisplayMember = "FullName";
                cmb_Student.ValueMember = "Id";
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
                var assessments = dal.GetAssessments();
                cmb_Assessment.DataSource = assessments;
                cmb_Assessment.DisplayMember = "Title";
                cmb_Assessment.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Assessment_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Clear components when assessment changes
            pnl_components_list.Controls.Clear();
            levelDropdowns.Clear();
            lbl_total_marks.Text = "0.00";
            lbl_percentage.Text = "0%";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (cmb_Student.SelectedValue == null ||
                cmb_Assessment.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select both student and assessment!",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int studentId =
                Convert.ToInt32(cmb_Student.SelectedValue);
            int assessmentId =
                Convert.ToInt32(cmb_Assessment.SelectedValue);

            LoadComponentsForEvaluation(
                studentId, assessmentId);
        }

        private void LoadComponentsForEvaluation(
            int studentId, int assessmentId)
        {
            try
            {
                pnl_components_list.Controls.Clear();
                levelDropdowns.Clear();

                currentComponents =
                    dal.GetComponents(assessmentId);

                if (currentComponents.Count == 0)
                {
                    MessageBox.Show(
                        "No components found for this assessment.",
                        "No Components", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                // Get existing results
                var existingResults = dal.GetStudentResults(
                    studentId, assessmentId);

                lbl_components_title.Text =
                    "Evaluating: " +
                    cmb_Student.Text + " — " +
                    cmb_Assessment.Text;

                int yPos = 10;

                foreach (var comp in currentComponents)
                {
                    // Component card panel
                    Panel card = new Panel();
                    card.Location = new Point(0, yPos);
                    card.Size = new Size(
                        pnl_components_list.Width - 20, 100);
                    card.BackColor = Color.White;
                    card.Anchor =
                        AnchorStyles.Top |
                        AnchorStyles.Left |
                        AnchorStyles.Right;

                    // Left accent bar
                    Panel accent = new Panel();
                    accent.BackColor =
                        Color.FromArgb(26, 35, 126);
                    accent.Location = new Point(0, 0);
                    accent.Size = new Size(4, 100);

                    // Component name
                    Label lblName = new Label();
                    lblName.Text = comp.Name;
                    lblName.Font = new Font("Segoe UI", 11F,
                        FontStyle.Bold);
                    lblName.ForeColor =
                        Color.FromArgb(26, 35, 126);
                    lblName.Location = new Point(16, 10);
                    lblName.Size = new Size(300, 24);

                    // Rubric name
                    Label lblRubric = new Label();
                    lblRubric.Text = "Rubric: " +
                        comp.RubricName.Substring(0,
                        Math.Min(60, comp.RubricName.Length))
                        + "...";
                    lblRubric.Font = new Font("Segoe UI", 8.5F);
                    lblRubric.ForeColor =
                        Color.FromArgb(120, 120, 120);
                    lblRubric.Location = new Point(16, 36);
                    lblRubric.Size = new Size(500, 18);

                    // Marks label
                    Label lblMarks = new Label();
                    lblMarks.Text = "Max Marks: " +
                        comp.TotalMarks;
                    lblMarks.Font = new Font("Segoe UI", 8.5F);
                    lblMarks.ForeColor =
                        Color.FromArgb(120, 120, 120);
                    lblMarks.Location = new Point(16, 56);
                    lblMarks.Size = new Size(200, 18);

                    // Level dropdown label
                    Label lblLevel = new Label();
                    lblLevel.Text = "RUBRIC LEVEL:";
                    lblLevel.Font = new Font("Segoe UI", 7.5F,
                        FontStyle.Bold);
                    lblLevel.ForeColor =
                        Color.FromArgb(26, 35, 126);
                    lblLevel.Location = new Point(550, 10);
                    lblLevel.Size = new Size(120, 16);

                    // Level dropdown
                    ComboBox cmbLevel = new ComboBox();
                    cmbLevel.Location = new Point(550, 28);
                    cmbLevel.Size = new Size(200, 28);
                    cmbLevel.Font = new Font("Segoe UI", 10F);
                    cmbLevel.DropDownStyle =
                        ComboBoxStyle.DropDownList;
                    cmbLevel.FlatStyle = FlatStyle.Flat;
                    cmbLevel.Tag = comp.Id;

                    // Load rubric levels
                    var levels =
                        dal.GetRubricLevels(comp.RubricId);
                    if (levels.Count == 0)
                    {
                        // If no levels defined use 1-4
                        for (int i = 1; i <= 4; i++)
                        {
                            cmbLevel.Items.Add(
                                new RubricLevel
                                {
                                    Id = i,
                                    MeasurementLevel = i,
                                    Details = "Level " + i
                                });
                        }
                    }
                    else
                    {
                        cmbLevel.DataSource = levels;
                        cmbLevel.DisplayMember =
                            "MeasurementLevel";
                        cmbLevel.ValueMember = "Id";
                    }
                    if (cmbLevel.Items.Count > 0)
                        cmbLevel.SelectedIndex = 0;

                    // Obtained marks label
                    Label lblObtained = new Label();
                    lblObtained.Text = "Obtained: 0.00";
                    lblObtained.Font = new Font("Segoe UI",
                        9F, FontStyle.Bold);
                    lblObtained.ForeColor =
                        Color.FromArgb(0, 121, 107);
                    lblObtained.Location = new Point(550, 62);
                    lblObtained.Size = new Size(200, 20);

                    // Pre-fill if evaluation exists
                    var existing = existingResults.Find(
                        r => r.AssessmentComponentId == comp.Id);
                    if (existing != null)
                    {
                        if (levels.Count > 0)
                            cmbLevel.SelectedValue =
                                existing.RubricMeasurementId;
                        lblObtained.Text = "Obtained: " +
                            existing.ObtainedMarks
                            .ToString("F2");
                    }

                    // Update obtained marks on level change
                    int compMarks = comp.TotalMarks;
                    int rubricId = comp.RubricId;
                    cmbLevel.SelectedIndexChanged += (s, e) =>
                    {
                        UpdateObtainedMarks(
                            cmbLevel, lblObtained,
                            compMarks, rubricId);
                        UpdateTotal();
                    };

                    card.Controls.Add(accent);
                    card.Controls.Add(lblName);
                    card.Controls.Add(lblRubric);
                    card.Controls.Add(lblMarks);
                    card.Controls.Add(lblLevel);
                    card.Controls.Add(cmbLevel);
                    card.Controls.Add(lblObtained);

                    pnl_components_list.Controls.Add(card);
                    levelDropdowns[comp.Id] = cmbLevel;

                    yPos += 110;
                }

                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateObtainedMarks(
            ComboBox cmb, Label lbl,
            int compMarks, int rubricId)
        {
            try
            {
                if (cmb.SelectedItem == null) return;
                int maxLevel = dal.GetMaxLevel(rubricId);
                int obtainedLevel = 0;

                if (cmb.SelectedItem is RubricLevel rl)
                    obtainedLevel = rl.MeasurementLevel;
                else
                    obtainedLevel =
                        Convert.ToInt32(cmb.SelectedItem);

                if (maxLevel == 0) return;
                decimal obtained =
                    ((decimal)obtainedLevel / maxLevel)
                    * compMarks;
                lbl.Text = "Obtained: " +
                    obtained.ToString("F2");
            }
            catch { }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            decimal maxTotal = 0;

            foreach (var comp in currentComponents)
            {
                if (levelDropdowns.ContainsKey(comp.Id))
                {
                    var cmb = levelDropdowns[comp.Id];
                    if (cmb.SelectedItem == null) continue;

                    int maxLevel =
                        dal.GetMaxLevel(comp.RubricId);
                    int obtainedLevel = 0;

                    if (cmb.SelectedItem is RubricLevel rl)
                        obtainedLevel = rl.MeasurementLevel;
                    else
                        obtainedLevel =
                            Convert.ToInt32(cmb.SelectedItem);

                    if (maxLevel > 0)
                    {
                        decimal obtained =
                            ((decimal)obtainedLevel / maxLevel)
                            * comp.TotalMarks;
                        total += obtained;
                    }
                    maxTotal += comp.TotalMarks;
                }
            }

            lbl_total_marks.Text = total.ToString("F2");
            if (maxTotal > 0)
            {
                decimal pct = (total / maxTotal) * 100;
                lbl_percentage.Text = pct.ToString("F1") + "%";
                lbl_percentage.ForeColor =
                    pct >= 50 ?
                    Color.FromArgb(0, 121, 107) :
                    Color.FromArgb(183, 28, 28);
            }
        }

        private void btn_save_all_Click(object sender, EventArgs e)
        {
            if (cmb_Student.SelectedValue == null ||
                currentComponents.Count == 0)
            {
                MessageBox.Show(
                    "Please load an evaluation first!",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int studentId =
                    Convert.ToInt32(cmb_Student.SelectedValue);
                int saved = 0;

                foreach (var comp in currentComponents)
                {
                    if (!levelDropdowns.ContainsKey(comp.Id))
                        continue;

                    var cmb = levelDropdowns[comp.Id];
                    if (cmb.SelectedItem == null) continue;

                    int levelId = 0;
                    if (cmb.SelectedItem is RubricLevel rl)
                        levelId = rl.Id;
                    else
                        levelId =
                            Convert.ToInt32(cmb.SelectedValue);

                    dal.SaveEvaluation(new StudentResult
                    {
                        StudentId = studentId,
                        AssessmentComponentId = comp.Id,
                        RubricMeasurementId = levelId,
                        EvaluationDate = DateTime.Now
                    });
                    saved++;
                }

                MessageBox.Show(
                    saved + " evaluations saved successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}