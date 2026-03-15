using System;
namespace MidDb26_2025CS212.Models
{
    public class Clo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public override string ToString() => Name;
    }
}