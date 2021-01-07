using System;
namespace PetsAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Details { get; set; }
        public int BirthYear { get; set; }
    }
}
