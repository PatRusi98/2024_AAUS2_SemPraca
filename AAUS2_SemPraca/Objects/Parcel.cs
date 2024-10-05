
namespace AAUS2_SemPraca.Objects
{
    public class Parcel : GeoEntity
    {
        public Parcel()
        {
        }

        public Parcel(int number, string description, List<Property> subAreas, GPSLocation point1, GPSLocation point2) : base(number, description, point1, point2)
        {

        }
    }
}
