using AAUS2_SemPraca.Utils;

namespace AAUS2_SemPraca.Objects
{
    public abstract class GeoEntity
    {
        private GPSLocation point2;

        protected int ID { get; }
        public int Number { get; set; }
        public string? Description { get; set; }
        public List<GeoEntity> SubAreas { get; set; } = new();
        public GPSLocation Point1 { get; }
        public GPSLocation Point2 { get; }
        public double[] LowerLeft { get; }
        public double[] UpperRight { get; }

        public GeoEntity(int number, string description, GPSLocation point1, GPSLocation point2)
        {
            Number = number;
            Description = description;
            Point1 = point1;
            Point2 = point2;

            var value1 = Point1.GPSToDouble();
            var value2 = Point2.GPSToDouble();

            if (Math.Min(value1[1], value2[1]) == value1[1])
            {
                LowerLeft = value1;
                UpperRight = value2;
            }
            else
            {
                LowerLeft = value2;
                UpperRight = value1;
            }
        }

        public void AddSubAreas(List<GeoEntity> entities)
        {
            entities.ForEach(x => SubAreas.Add(x));
        }
    }
}
