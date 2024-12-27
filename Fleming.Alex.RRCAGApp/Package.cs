using System.Collections.Generic;

namespace Fleming.Alex.RRCAGApp
{
    internal class Package
    { 
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ServiceLevel { get; set; }
        public Package(string description, decimal price, int serviceLevel)
        {
            this.Description = description;
            this.Price = price;
            this.ServiceLevel = serviceLevel;
        }
    }
}