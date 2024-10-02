
namespace AAUS2_SemPraca.Objects
{
    public class Parcel : Area
    {
        public Parcel(int number, string description, List<Estate> subAreas, GPSLocation point1, GPSLocation point2) : base(number, description, point1, point2)
        {

        }
    }
}
