using System;
namespace MidDb26_2025CS212.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalMarks { get; set; }
        public int TotalWeightage { get; set; }

        public override string ToString() => Title;
    }
}