using System;
namespace MidDb26_2025CS212.Models
{
    public class StudentResult
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int AssessmentComponentId { get; set; }
        public string ComponentName { get; set; }
        public int RubricMeasurementId { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int ObtainedLevel { get; set; }
        public int MaxLevel { get; set; }
        public decimal ComponentMarks { get; set; }

        public decimal ObtainedMarks =>
            MaxLevel == 0 ? 0 :
            ((decimal)ObtainedLevel / MaxLevel) * ComponentMarks;
    }
}