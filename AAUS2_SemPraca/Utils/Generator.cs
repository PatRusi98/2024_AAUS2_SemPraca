using AAUS2_SemPraca.Objects;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Utils
{
    public class Generator
    {
        private static Generator _instance = null;
        private Random _random = new();

        private Generator() { }

        public static Generator GetInstance()
        {
            if (_instance == null)
                _instance = new();

            return _instance;
        }

        public GeoEntity GenerateEntity(GeoEntityType type = GeoEntityType.Unknown)
        {
            bool property = false;

            switch (type)
            {
                case GeoEntityType.Parcel:
                    property = false;
                    break;
                case GeoEntityType.Property:
                    property = true;
                    break;
                default:
                    property = _random.Next() % 2 == 0;
                    break;
            }

            var number = _random.Next();
            var gpss = GenerateGPSLocations();
            var description = "Description of " + (property ? "property" : "parcel") + " number: " + number;
            GeoEntity result = null;

            if (property)
            {
                result = new Property()
                {
                    Number = number,
                    Description = description,
                    Point1 = gpss[0],
                    Point2 = gpss[1]
                };
            }
            else
            {
                result = new Parcel()
                {
                    Number = number,
                    Description = description,
                    Point1 = gpss[0],
                    Point2 = gpss[1]
                };
            }

            return result;
        }

        #region private
        private GPSLocation[] GenerateGPSLocations()
        {
            return [new GPSLocation(), new GPSLocation()];
        }
        #endregion
    }
}
