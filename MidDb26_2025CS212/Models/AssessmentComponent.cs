using System;
namespace MidDb26_2025CS212.Models
{
    public class AssessmentComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RubricId { get; set; }
        public string RubricName { get; set; }
        public int TotalMarks { get; set; }
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}