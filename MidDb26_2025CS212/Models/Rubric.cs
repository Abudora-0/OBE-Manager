namespace MidDb26_2025CS212.Models
{
    public class Rubric
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public int CloId { get; set; }
        public string CloName { get; set; }

        public override string ToString() => Details;
    }
}