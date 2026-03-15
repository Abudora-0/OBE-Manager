namespace MidDb26_2025CS212.Models
{
    public class Lookup
    {
        public int LookupId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public override string ToString() => Name;
    }
}
