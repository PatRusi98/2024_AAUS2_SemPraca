using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Objects
{
    public class Parcel(int number, string description, GPSLocation point1, GPSLocation point2, GeoEntityType type) : GeoEntity(number, description, point1, point2, type) { }
}
