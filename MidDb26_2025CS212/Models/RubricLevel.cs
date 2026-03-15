namespace MidDb26_2025CS212.Models
{
    public class RubricLevel
    {
        public int Id { get; set; }
        public int RubricId { get; set; }
        public string Details { get; set; }
        public int MeasurementLevel { get; set; }

        public override string ToString() =>
            "Level " + MeasurementLevel + " - " + Details;
    }
}