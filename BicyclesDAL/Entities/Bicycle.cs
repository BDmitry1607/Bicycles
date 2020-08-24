using System;

namespace BicyclesDAL.Entities
{
    public class Bicycle
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool Rented { get; set; }
        public Bicycle()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
