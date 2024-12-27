namespace Fleming.Alex.RRCAGApp
{
    internal class Service
    {
        public string Description { get; set; }
        public int HighestServiceLevel { get; protected set; }
        public bool IsInterior { get; protected set; }

        public Service (string description, int highestServiceLevel, bool isInterior)
        {
            this.Description = description;
            this.HighestServiceLevel = highestServiceLevel;
            this.IsInterior = isInterior;
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}