
namespace AAUS2_SemPraca.Objects
{
    public class Property : GeoEntity
    {
        public Property()
        {
        }

        public Property(int number, string description, List<Parcel> subAreas, GPSLocation point1, GPSLocation point2) : base(number, description, point1, point2)
        {
            
        }
    }
}
