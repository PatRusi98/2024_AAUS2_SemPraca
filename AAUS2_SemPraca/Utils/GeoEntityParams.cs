using AAUS2_SemPraca.Objects;

namespace AAUS2_SemPraca.Utils
{
    public struct GeoEntityParams
    {
        public int? Number { get; set; } = null;
        public string? Description { get; set; } = null;
        public GPSLocation? Point1 { get; set; } = null;
        public GPSLocation? Point2 { get; set; } = null;

        public GeoEntityParams() { }
    }
}