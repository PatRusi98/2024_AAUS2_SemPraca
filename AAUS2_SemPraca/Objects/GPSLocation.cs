using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Objects
{
    public struct GPSLocation
    {
        public required double Latitude { get; set; }
        public required Coordinate LatCoord { get; set; }
        public required double Longitude { get; set; }
        public required Coordinate LongCoord { get; set; }

        public override readonly string ToString() => $"{Latitude}~{LatCoord}~{Longitude}~{LongCoord}";
    }
}
