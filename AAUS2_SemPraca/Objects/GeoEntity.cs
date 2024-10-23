using AAUS2_SemPraca.Utils;

namespace AAUS2_SemPraca.Objects
{
    public abstract class GeoEntity
    {
        protected int ID { get; }
        public int Number { get; set; }
        public string? Description { get; set; }
        public List<GeoEntity> SubAreas { get; set; } = new();
        public GPSLocation Point1 { get; set; }
        public GPSLocation Point2 { get; set; }
        public double[] Key1
        {
            get
            {
                return Point1.GPSToDouble();
            }
        }
        public double[] Key2 
        {
            get
            {
                return Point2.GPSToDouble();
            }
        }

        public GeoEntity(int number, string description, GPSLocation point1, GPSLocation point2)
        {
            Number = number;
            Description = description;
            Point1 = point1;
            Point2 = point2;

            var value1 = Point1.GPSToDouble();
            var value2 = Point2.GPSToDouble();

            if (Math.Min(value1[1], value2[1]) != value1[1])
            {
                (Point2, Point1) = (Point1, Point2);
            }
        }

        public void AddSubAreas(List<GeoEntity> entities)
        {
            entities.ForEach(x => SubAreas.Add(x));
        }
    }
}
