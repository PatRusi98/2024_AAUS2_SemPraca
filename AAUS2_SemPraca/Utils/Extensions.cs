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
    }
}
