using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;

namespace MidDb26_2025CS212.Reports
{
    public class ReportHelper
    {
        // ── COLORS ─────────────────────────────────────────
        private static BaseColor NavyBlue =
            new BaseColor(26, 35, 126);
        private static BaseColor LightBlue =
            new BaseColor(232, 234, 246);
        private static BaseColor White =
            new BaseColor(255, 255, 255);
        private static BaseColor LightGray =
            new BaseColor(248, 249, 252);
        private static BaseColor DarkGray =
            new BaseColor(80, 80, 80);
        private static BaseColor Green =
            new BaseColor(0, 121, 107);
        private static BaseColor Red =
            new BaseColor(183, 28, 28);

        // ── FONTS ──────────────────────────────────────────
        private static Font TitleFont =
            FontFactory.GetFont(FontFactory.HELVETICA_BOLD,
                18, White);
        private static Font SubTitleFont =
            FontFactory.GetFont(FontFactory.HELVETICA,
                10, new BaseColor(160, 180, 230));
        private static Font HeaderFont =
            FontFactory.GetFont(FontFactory.HELVETICA_BOLD,
                10, White);
        private static Font NormalFont =
            FontFactory.GetFont(FontFactory.HELVETICA,
                9, DarkGray);
        private static Font BoldFont =
            FontFactory.GetFont(FontFactory.HELVETICA_BOLD,
                9, NavyBlue);
        private static Font SmallFont =
            FontFactory.GetFont(FontFactory.HELVETICA,
                8, DarkGray);

        // ── CLO WISE REPORT ────────────────────────────────
        public static void GenerateCloWiseReport()
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files|*.pdf";
                dlg.FileName = "CLO_Wise_Report_" +
                    DateTime.Now.ToString("yyyyMMdd");
                dlg.Title = "Save CLO Wise Report";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4,
                    40, 40, 60, 40);
                PdfWriter writer = PdfWriter.GetInstance(doc,
                    new FileStream(dlg.FileName,
                    FileMode.Create));
                doc.Open();

                // Header
                AddReportHeader(doc,
                    "CLO Wise Class Result",
                    "Course Learning Outcome Performance Report");

                // Get data
                var data = GetCloWiseData();

                foreach (var clo in data)
                {
                    // CLO title
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable cloHeader =
                        new PdfPTable(1);
                    cloHeader.WidthPercentage = 100;
                    PdfPCell cloCell = new PdfPCell(
                        new Phrase(clo.Key, BoldFont));
                    cloCell.BackgroundColor = LightBlue;
                    cloCell.Padding = 8;
                    cloCell.Border = 0;
                    cloHeader.AddCell(cloCell);
                    doc.Add(cloHeader);

                    // Table
                    PdfPTable table = new PdfPTable(5);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[]
                        { 3f, 2f, 2f, 1.5f, 1.5f });

                    // Table headers
                    AddTableHeader(table, new string[]
                    {
                        "Student Name",
                        "Reg Number",
                        "Assessment",
                        "Obtained",
                        "Total"
                    });

                    // Table rows
                    bool alternate = false;
                    foreach (var row in clo.Value)
                    {
                        BaseColor bg = alternate ?
                            LightGray : White;
                        AddTableRow(table, row, bg);
                        alternate = !alternate;
                    }

                    doc.Add(table);
                }

                // Footer
                AddReportFooter(doc);
                doc.Close();

                MessageBox.Show(
                    "CLO Wise Report generated successfully!\n" +
                    dlg.FileName,
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Open the PDF
                System.Diagnostics.Process.Start(dlg.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating report: " + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ── ASSESSMENT WISE REPORT ─────────────────────────
        public static void GenerateAssessmentWiseReport()
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files|*.pdf";
                dlg.FileName = "Assessment_Wise_Report_" +
                    DateTime.Now.ToString("yyyyMMdd");
                dlg.Title = "Save Assessment Wise Report";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4,
                    40, 40, 60, 40);
                PdfWriter.GetInstance(doc,
                    new FileStream(dlg.FileName,
                    FileMode.Create));
                doc.Open();

                // Header
                AddReportHeader(doc,
                    "Assessment Wise Class Result",
                    "Student Performance Per Assessment");

                // Get data
                var assessments = GetAssessmentWiseData();

                foreach (var assessment in assessments)
                {
                    doc.Add(Chunk.NEWLINE);

                    // Assessment title bar
                    PdfPTable titleTable = new PdfPTable(1);
                    titleTable.WidthPercentage = 100;
                    PdfPCell titleCell = new PdfPCell(
                        new Phrase(assessment.Key, HeaderFont));
                    titleCell.BackgroundColor = NavyBlue;
                    titleCell.Padding = 10;
                    titleCell.Border = 0;
                    titleTable.AddCell(titleCell);
                    doc.Add(titleTable);

                    // Student results table
                    PdfPTable table = new PdfPTable(5);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[]
                        { 3f, 2f, 2f, 2f, 1.5f });

                    AddTableHeader(table, new string[]
                    {
                        "Student Name",
                        "Reg Number",
                        "Obtained Marks",
                        "Total Marks",
                        "Percentage"
                    });

                    bool alternate = false;
                    foreach (var row in assessment.Value)
                    {
                        BaseColor bg = alternate ?
                            LightGray : White;

                        // Color percentage based on pass/fail
                        string pct = row[4];
                        float pctVal = 0;
                        float.TryParse(
                            pct.Replace("%", ""), out pctVal);
                        Font pctFont = pctVal >= 50 ?
                            FontFactory.GetFont(
                                FontFactory.HELVETICA_BOLD,
                                9, Green) :
                            FontFactory.GetFont(
                                FontFactory.HELVETICA_BOLD,
                                9, Red);

                        PdfPCell c1 = MakeCell(
                            row[0], NormalFont, bg);
                        PdfPCell c2 = MakeCell(
                            row[1], NormalFont, bg);
                        PdfPCell c3 = MakeCell(
                            row[2], NormalFont, bg);
                        PdfPCell c4 = MakeCell(
                            row[3], NormalFont, bg);
                        PdfPCell c5 = MakeCell(
                            row[4], pctFont, bg);

                        table.AddCell(c1);
                        table.AddCell(c2);
                        table.AddCell(c3);
                        table.AddCell(c4);
                        table.AddCell(c5);

                        alternate = !alternate;
                    }

                    doc.Add(table);
                }

                AddReportFooter(doc);
                doc.Close();

                MessageBox.Show(
                    "Assessment Report generated!\n" +
                    dlg.FileName,
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(dlg.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating report: " + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ── STUDENT REPORT ─────────────────────────────────
        public static void GenerateStudentReport(
            int studentId, string studentName)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files|*.pdf";
                dlg.FileName = "Student_Report_" +
                    studentName.Replace(" ", "_") + "_" +
                    DateTime.Now.ToString("yyyyMMdd");

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4,
                    40, 40, 60, 40);
                PdfWriter.GetInstance(doc,
                    new FileStream(dlg.FileName,
                    FileMode.Create));
                doc.Open();

                AddReportHeader(doc,
                    "Student Result Report",
                    "Individual Performance Summary: " +
                    studentName);

                var data = GetStudentReportData(studentId);
                decimal grandTotal = 0;
                decimal grandMax = 0;

                foreach (var assessment in data)
                {
                    doc.Add(Chunk.NEWLINE);

                    PdfPTable titleTable = new PdfPTable(1);
                    titleTable.WidthPercentage = 100;
                    PdfPCell titleCell = new PdfPCell(
                        new Phrase(assessment.Key, HeaderFont));
                    titleCell.BackgroundColor = NavyBlue;
                    titleCell.Padding = 8;
                    titleCell.Border = 0;
                    titleTable.AddCell(titleCell);
                    doc.Add(titleTable);

                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[]
                        { 3f, 2f, 1.5f, 1.5f });

                    AddTableHeader(table, new string[]
                    {
                        "Component",
                        "Rubric Level",
                        "Obtained",
                        "Total"
                    });

                    decimal assessTotal = 0;
                    decimal assessMax = 0;
                    bool alternate = false;

                    foreach (var row in assessment.Value)
                    {
                        BaseColor bg = alternate ?
                            LightGray : White;
                        AddTableRow(table, row, bg);
                        alternate = !alternate;

                        decimal obtained, total;
                        decimal.TryParse(row[2],
                            out obtained);
                        decimal.TryParse(row[3], out total);
                        assessTotal += obtained;
                        assessMax += total;
                    }

                    doc.Add(table);

                    // Assessment summary row
                    PdfPTable summaryTable = new PdfPTable(2);
                    summaryTable.WidthPercentage = 100;
                    PdfPCell sumLabel = new PdfPCell(
                        new Phrase("Assessment Total:",
                        BoldFont));
                    sumLabel.BackgroundColor = LightBlue;
                    sumLabel.Padding = 6;
                    sumLabel.Border = 0;
                    PdfPCell sumVal = new PdfPCell(
                        new Phrase(
                        assessTotal.ToString("F2") +
                        " / " + assessMax.ToString("F2") +
                        " (" +
                        (assessMax > 0 ?
                        (assessTotal / assessMax * 100)
                        .ToString("F1") : "0") + "%)",
                        BoldFont));
                    sumVal.BackgroundColor = LightBlue;
                    sumVal.Padding = 6;
                    sumVal.Border = 0;
                    summaryTable.AddCell(sumLabel);
                    summaryTable.AddCell(sumVal);
                    doc.Add(summaryTable);

                    grandTotal += assessTotal;
                    grandMax += assessMax;
                }

                // Grand total
                doc.Add(Chunk.NEWLINE);
                PdfPTable grandTable = new PdfPTable(2);
                grandTable.WidthPercentage = 100;
                PdfPCell grandLabel = new PdfPCell(
                    new Phrase("GRAND TOTAL:", HeaderFont));
                grandLabel.BackgroundColor = NavyBlue;
                grandLabel.Padding = 10;
                grandLabel.Border = 0;
                PdfPCell grandVal = new PdfPCell(
                    new Phrase(
                    grandTotal.ToString("F2") +
                    " / " + grandMax.ToString("F2") +
                    " (" +
                    (grandMax > 0 ?
                    (grandTotal / grandMax * 100)
                    .ToString("F1") : "0") + "%)",
                    HeaderFont));
                grandVal.BackgroundColor = NavyBlue;
                grandVal.Padding = 10;
                grandVal.Border = 0;
                grandTable.AddCell(grandLabel);
                grandTable.AddCell(grandVal);
                doc.Add(grandTable);

                AddReportFooter(doc);
                doc.Close();

                MessageBox.Show(
                    "Student report generated!\n" +
                    dlg.FileName,
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(dlg.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ── HELPER METHODS ─────────────────────────────────

        private static void AddReportHeader(
            Document doc, string title, string subtitle)
        {
            // Header background
            PdfPTable header = new PdfPTable(1);
            header.WidthPercentage = 100;
            header.SpacingAfter = 10;

            PdfPCell titleCell = new PdfPCell();
            titleCell.BackgroundColor = NavyBlue;
            titleCell.Border = 0;
            titleCell.Padding = 20;

            Paragraph titlePara =
                new Paragraph(title, TitleFont);
            titlePara.SpacingAfter = 4;
            Paragraph subtitlePara =
                new Paragraph(subtitle, SubTitleFont);
            Paragraph datePara = new Paragraph(
                "Generated: " +
                DateTime.Now.ToString("dd MMMM yyyy, hh:mm tt"),
                SubTitleFont);

            titleCell.AddElement(titlePara);
            titleCell.AddElement(subtitlePara);
            titleCell.AddElement(datePara);
            header.AddCell(titleCell);
            doc.Add(header);
        }

        private static void AddTableHeader(
            PdfPTable table, string[] headers)
        {
            foreach (var h in headers)
            {
                PdfPCell cell = new PdfPCell(
                    new Phrase(h, HeaderFont));
                cell.BackgroundColor = NavyBlue;
                cell.Padding = 8;
                cell.Border = 0;
                cell.BorderWidthBottom = 2;
                cell.BorderColorBottom = White;
                table.AddCell(cell);
            }
        }

        private static void AddTableRow(
            PdfPTable table, string[] values,
            BaseColor bg)
        {
            foreach (var v in values)
            {
                table.AddCell(MakeCell(v, NormalFont, bg));
            }
        }

        private static PdfPCell MakeCell(
            string text, Font font, BaseColor bg)
        {
            PdfPCell cell = new PdfPCell(
                new Phrase(text, font));
            cell.BackgroundColor = bg;
            cell.Padding = 7;
            cell.Border = 0;
            cell.BorderWidthBottom = 1;
            cell.BorderColorBottom =
                new BaseColor(220, 220, 220);
            return cell;
        }

        private static void AddReportFooter(Document doc)
        {
            doc.Add(Chunk.NEWLINE);
            Paragraph footer = new Paragraph(
                "OBE Manager — CS104 Database Systems — " +
                "Spring 2026 — Generated by MidDb26_2025CS212",
                SmallFont);
            footer.Alignment = Element.ALIGN_CENTER;
            doc.Add(footer);
        }

        // ── DATA QUERIES ───────────────────────────────────

        private static Dictionary<string,
            List<string[]>> GetCloWiseData()
        {
            var result =
                new Dictionary<string, List<string[]>>();
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT
                            c.Name as CloName,
                            CONCAT(s.FirstName,' ',s.LastName)
                                as StudentName,
                            s.RegistrationNumber,
                            a.Title as Assessment,
                            SUM((rl.MeasurementLevel /
                                (SELECT MAX(rl2.MeasurementLevel)
                                 FROM rubriclevel rl2
                                 WHERE rl2.RubricId = r.Id))
                                * ac.TotalMarks)
                                as ObtainedMarks,
                            SUM(ac.TotalMarks) as TotalMarks
                        FROM studentresult sr
                        INNER JOIN student s
                            ON sr.StudentId = s.Id
                        INNER JOIN assessmentcomponent ac
                            ON sr.AssessmentComponentId = ac.Id
                        INNER JOIN assessment a
                            ON ac.AssessmentId = a.Id
                        INNER JOIN rubric r
                            ON ac.RubricId = r.Id
                        INNER JOIN clo c
                            ON r.CloId = c.Id
                        INNER JOIN rubriclevel rl
                            ON sr.RubricMeasurementId = rl.Id
                        GROUP BY c.Name, s.Id, a.Id
                        ORDER BY c.Name, s.FirstName, a.Title";

                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string cloName =
                            reader["CloName"].ToString();
                        if (!result.ContainsKey(cloName))
                            result[cloName] =
                                new List<string[]>();

                        result[cloName].Add(new string[]
                        {
                            reader["StudentName"].ToString(),
                            reader["RegistrationNumber"]
                                .ToString(),
                            reader["Assessment"].ToString(),
                            Convert.ToDecimal(
                                reader["ObtainedMarks"])
                                .ToString("F2"),
                            reader["TotalMarks"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error getting CLO data: " + ex.Message);
            }
            return result;
        }

        private static Dictionary<string,
            List<string[]>> GetAssessmentWiseData()
        {
            var result =
                new Dictionary<string, List<string[]>>();
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT
                            a.Title as Assessment,
                            CONCAT(s.FirstName,' ',s.LastName)
                                as StudentName,
                            s.RegistrationNumber,
                            SUM((rl.MeasurementLevel /
                                (SELECT MAX(rl2.MeasurementLevel)
                                 FROM rubriclevel rl2
                                 WHERE rl2.RubricId = r.Id))
                                * ac.TotalMarks)
                                as ObtainedMarks,
                            SUM(ac.TotalMarks) as TotalMarks
                        FROM studentresult sr
                        INNER JOIN student s
                            ON sr.StudentId = s.Id
                        INNER JOIN assessmentcomponent ac
                            ON sr.AssessmentComponentId = ac.Id
                        INNER JOIN assessment a
                            ON ac.AssessmentId = a.Id
                        INNER JOIN rubric r
                            ON ac.RubricId = r.Id
                        INNER JOIN rubriclevel rl
                            ON sr.RubricMeasurementId = rl.Id
                        GROUP BY a.Id, s.Id
                        ORDER BY a.Title, s.FirstName";

                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string assessment =
                            reader["Assessment"].ToString();
                        if (!result.ContainsKey(assessment))
                            result[assessment] =
                                new List<string[]>();

                        decimal obtained =
                            Convert.ToDecimal(
                                reader["ObtainedMarks"]);
                        decimal total =
                            Convert.ToDecimal(
                                reader["TotalMarks"]);
                        decimal pct = total > 0 ?
                            (obtained / total * 100) : 0;

                        result[assessment].Add(new string[]
                        {
                            reader["StudentName"].ToString(),
                            reader["RegistrationNumber"]
                                .ToString(),
                            obtained.ToString("F2"),
                            total.ToString("F2"),
                            pct.ToString("F1") + "%"
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error getting assessment data: " +
                    ex.Message);
            }
            return result;
        }

        private static Dictionary<string,
            List<string[]>> GetStudentReportData(int studentId)
        {
            var result =
                new Dictionary<string, List<string[]>>();
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT
                            a.Title as Assessment,
                            ac.Name as Component,
                            rl.MeasurementLevel as Level,
                            (SELECT MAX(rl2.MeasurementLevel)
                             FROM rubriclevel rl2
                             WHERE rl2.RubricId = r.Id)
                                as MaxLevel,
                            ((rl.MeasurementLevel /
                             (SELECT MAX(rl2.MeasurementLevel)
                              FROM rubriclevel rl2
                              WHERE rl2.RubricId = r.Id))
                             * ac.TotalMarks)
                                as ObtainedMarks,
                            ac.TotalMarks
                        FROM studentresult sr
                        INNER JOIN assessmentcomponent ac
                            ON sr.AssessmentComponentId = ac.Id
                        INNER JOIN assessment a
                            ON ac.AssessmentId = a.Id
                        INNER JOIN rubric r
                            ON ac.RubricId = r.Id
                        INNER JOIN rubriclevel rl
                            ON sr.RubricMeasurementId = rl.Id
                        WHERE sr.StudentId = @sid
                        ORDER BY a.Title, ac.Id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@sid",
                        studentId);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string assessment =
                            reader["Assessment"].ToString();
                        if (!result.ContainsKey(assessment))
                            result[assessment] =
                                new List<string[]>();

                        result[assessment].Add(new string[]
                        {
                            reader["Component"].ToString(),
                            "Level " + reader["Level"]
                                .ToString() + " / " +
                                reader["MaxLevel"].ToString(),
                            Convert.ToDecimal(
                                reader["ObtainedMarks"])
                                .ToString("F2"),
                            reader["TotalMarks"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error getting student data: " + ex.Message);
            }
            return result;
        }
    }
}