using AAUS2_SemPraca.Utils;

namespace AAUS2_SemPraca.Objects
{
    public abstract class GeoEntity
    {
        private GPSLocation point2;

        protected int ID { get; }
        public required int Number { get; set; }
        public string? Description { get; set; }
        public List<GeoEntity> SubAreas { get; set; } = new();
        public required GPSLocation Point1 { get; set; }
        public required GPSLocation Point2 { get; set; }
        protected double[] LowerLeft { get; }
        protected double[] UpperRight { get; }

        public GeoEntity()
        {
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
