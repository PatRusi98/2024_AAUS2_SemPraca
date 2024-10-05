using AAUS2_SemPraca.Objects;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Utils
{
    public static class Extensions
    {
        public static char CoordinateToChar(this Coordinate coordinate)
        {
            return (char)coordinate;
        }
        
        public static Coordinate CharToCoordinate(this char c)
        {
            switch (c) 
            {
                case 'E':
                    return Coordinate.East;
                case 'N':
                    return Coordinate.North;
                case 'S':
                    return Coordinate.South;
                case 'W':
                    return Coordinate.West;
                default:
                    return Coordinate.Unknown;
            }
        }

        public static bool IsLatitude(this Coordinate coordinate)
        {
            return coordinate == Coordinate.North || coordinate == Coordinate.South;
        }

        public static bool IsLongitude(this Coordinate coordinate)
        {
            return coordinate == Coordinate.East || coordinate == Coordinate.West;
        }

        public static double[] GPSToDouble(this GPSLocation gps)
        {
            var latitude = GPSDoublePosition(gps.Latitude, gps.LatCoord);
            var longitude = GPSDoublePosition(gps.Longitude, gps.LongCoord);

            return [latitude, longitude];
        }

        #region private
        private static double GPSDoublePosition(double value, Coordinate coord)
        {
            switch (coord)                                                                  // prehodenie gps pozicii do double - sirka od 0.0 do 180.0 a dlzka od 0.0 do 360.0
            {                                                                               // kvoli klucom - jednoduchsie ako porovnavat v strome GPSPosition
                case Coordinate.North:
                    return 90.00 + value;
                case Coordinate.East:
                    return 180.00 + value;
                case Coordinate.South:
                    return 90.00 - value;
                case Coordinate.West:
                    return 180.00 - value;
                default:
                    return Double.MinValue;
            }
        }

        #endregion
    }
}
