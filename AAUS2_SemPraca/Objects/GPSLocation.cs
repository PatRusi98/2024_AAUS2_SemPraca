using AAUS2_SemPraca.Utils;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Objects
{
    public class GPSLocation
    {
        public double Latitude { get; set; }
        public Coordinate LatCoord { get; set; }
        public double Longitude { get; set; }
        public Coordinate LongCoord { get; set; }
    }
}
