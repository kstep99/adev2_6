namespace Fleming.Alex.RRCAGApp
{
    internal class Fragrance : Service
    {
        public decimal Price { get; set; }
        public Fragrance(string description, decimal price) : base(description, 1, true)
        {
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("Fragrance - {0}", this.Description);
        }
    }
}