
namespace AAUS2_SemPraca.Objects
{
    public class Estate : Area
    {
        public Estate(int number, string description, List<Parcel> subAreas, GPSLocation point1, GPSLocation point2) : base(number, description, point1, point2)
        {

        }
    }
}
