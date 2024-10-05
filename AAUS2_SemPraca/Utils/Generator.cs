﻿using AAUS2_SemPraca.Objects;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Utils
{
    public class Generator
    {
        private static Generator? _instance = null;
        private readonly Random _random = new();

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
            // generovanie nahodnych GPS lokalit, maximalne do 89 sirky a 179 dlzky aby sa neprelievali
            var lat1 = Math.Round(_random.NextDouble() * 89, 4);
            var longt1 = Math.Round(_random.NextDouble() * 179, 4);
            Coordinate latCoord = _random.Next(2) == 0 ? Coordinate.North : Coordinate.South;
            Coordinate longCoord = _random.Next(2) == 0 ? Coordinate.East : Coordinate.West;

            // logika, aby negenerovalo zbytocne velke objekty +- max 1.0 sirky a dlzky
            var lat2 = Math.Round(_random.NextDouble(), 4) + lat1;
            var longt2 = Math.Round(_random.NextDouble(), 4) + longt1;

            GPSLocation[] result =
            [
                new GPSLocation()
                {
                    Latitude = lat1,
                    LatCoord = latCoord,
                    Longitude = longt1,
                    LongCoord = longCoord
                },
                new GPSLocation()
                {
                    Latitude = lat2,
                    LatCoord = latCoord,
                    Longitude = longt2,
                    LongCoord = longCoord
                }
            ];

            return result;
        }
        #endregion
    }
}