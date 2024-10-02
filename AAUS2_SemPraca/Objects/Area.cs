namespace AAUS2_SemPraca.Objects
{
    public abstract class Area
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public List<Area> SubAreas { get; set; } = new();
        public GPSLocation Point1 { get; set; }
        public GPSLocation Point2 { get; set; }

        public Area(int number, string description, GPSLocation point1, GPSLocation point2)
        {
            Number = number;
            Description = description;
            Point1 = point1;
            Point2 = point2;
        }
    }
}
