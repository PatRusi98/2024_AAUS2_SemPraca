using AAUS2_SemPraca.Objects;
using AAUS2_SemPraca.Utils;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca
{
    public class SemProject
    {
        private static SemProject? _instance = null;
        private GeoSystemHandler Handler { get; set; }
        private Generator DataGenerator { get; set; }

        /*
         * Privatny konstruktor pre semestralny projekt
         */
        private SemProject()
        {
            Handler = GeoSystemHandler.Instance;
            DataGenerator = Generator.Instance;
        }

        /*
         * Vrati instanciu semestralneho projektu, zarucuje jednu instanciu (navrhovy vzor singleton)
         */
        public static SemProject Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new();

                return _instance;
            }
        }

        /*
         * Operacia 1: Vyhladanie nehnutelnosti
         */
        public List<Property> SearchAllPropertiesOnLocation(double lat, char latCoord, double lon, char lonCoord)
        {
            var gps = new GPSLocation()
            {
                Latitude = lat,
                LatCoord = latCoord.CharToCoordinate(),
                Longitude = lon,
                LongCoord = lonCoord.CharToCoordinate()
            };

            var properties = Handler.Search(gps, GeoEntityType.Property);
            return properties.Cast<Property>().ToList();
        }

        /*
         * Operacia 2: Vyhladanie parciel
         */
        public List<Parcel> SearchAllParcelsOnLocation(double lat, char latCoord, double lon, char lonCoord)
        {
            var gps = new GPSLocation()
            {
                Latitude = lat,
                LatCoord = latCoord.CharToCoordinate(),
                Longitude = lon,
                LongCoord = lonCoord.CharToCoordinate()
            };

            var parcels = Handler.Search(gps, GeoEntityType.Property);
            return parcels.Cast<Parcel>().ToList();
        }

        /*
         * Operacia 3: Vyhladanie vsetkych objektov
         */
        public List<GeoEntity> SearchAllObjectsOnLocation(double lat, char latCoord, double lon, char lonCoord)
        {
            var gps = new GPSLocation()
            {
                Latitude = lat,
                LatCoord = latCoord.CharToCoordinate(),
                Longitude = lon,
                LongCoord = lonCoord.CharToCoordinate()
            };

            return Handler.Search(gps);
        }

        /*
         * Operacia 4: Pridanie nehnutelnosti
         */
        public void AddProperty(int number, string description, double lat1, char latCoord1, double long1, char longCoord1,
                                double lat2, char latCoord2, double long2, char longCoord2)
        {
            var gps1 = new GPSLocation()
            {
                Latitude = lat1,
                LatCoord = latCoord1.CharToCoordinate(),
                Longitude = long1,
                LongCoord = longCoord1.CharToCoordinate()
            };

            var gps2 = new GPSLocation()
            {
                Latitude = lat2,
                LatCoord = latCoord2.CharToCoordinate(),
                Longitude = long2,
                LongCoord = longCoord2.CharToCoordinate()
            };

            var propertyToAdd = new Property(
                                    number,
                                    description,
                                    gps1,
                                    gps2,
                                    GeoEntityType.Property
                                );

            Handler.Insert(propertyToAdd);
        }

        /*
         * Operacia 5: Pridanie parcely
         */
        public void AddParcel(int number, string description, double lat1, char latCoord1, double long1, char longCoord1,
                                double lat2, char latCoord2, double long2, char longCoord2)
        {
            var gps1 = new GPSLocation()
            {
                Latitude = lat1,
                LatCoord = latCoord1.CharToCoordinate(),
                Longitude = long1,
                LongCoord = longCoord1.CharToCoordinate()
            };

            var gps2 = new GPSLocation()
            {
                Latitude = lat2,
                LatCoord = latCoord2.CharToCoordinate(),
                Longitude = long2,
                LongCoord = longCoord2.CharToCoordinate()
            };

            var parcelToAdd = new Parcel(
                                    number,
                                    description,
                                    gps1,
                                    gps2,
                                    GeoEntityType.Parcel
                                );

            Handler.Insert(parcelToAdd);
        }

        /*
         * Operacia 6: Editacia nehnutelnosti
         */
        public bool EditProperty(Property propertyToEdit, GeoEntityParams par)
        {
            return Handler.Update(propertyToEdit, par);
        }

        /*
         * Operacia 7: Editacia parcely
         */
        public bool EditParcel(Parcel parcelToEdit, GeoEntityParams par)
        {
            return Handler.Update(parcelToEdit, par);
        }

        /*
         * Operacia 8: Vyradenie nehnutelnosti
         */
        public bool DeleteProperty(Property propertyToDelete)
        {
            return Handler.Delete(propertyToDelete);
        }

        /*
         * Operacia 9: Vyradenie parcely
         */
        public bool DeleteParcel(Parcel parcelToDelete)
        {
            return Handler.Delete(parcelToDelete);
        }

        /*
         * Generovanie nehnutelnosti
         */
        public void GenerateRandomProperties(int number)
        {
            if (number < 1)
                return;

            for (int i = 0; i < number; i++)
            {
                var propertyToAdd = DataGenerator.GenerateEntity(Enums.GeoEntityType.Property);

                if (propertyToAdd is Property property)
                    Handler.Insert(property);
            }
        }

        /*
         * Generovanie parciel
         */
        public void GenerateRandomParcels(int number)
        {
            if (number < 1)
                return;

            for (int i = 0; i < number; i++)
            {
                var parcelToAdd = DataGenerator.GenerateEntity(Enums.GeoEntityType.Parcel);

                if (parcelToAdd is Parcel parcel)
                    Handler.Insert(parcel);
            }
        }

        /*
         * Generovanie nahodnych objektov
         */
        public void GenerateRandomEntities(int number)
        {
            if (number < 1)
                return;

            for (int i = 0; i < number; i++)
            {
                var entityToAdd = DataGenerator.GenerateEntity();

                if (entityToAdd is Property property)
                    Handler.Insert(property);
                else if (entityToAdd is Parcel parcel)
                    Handler.Insert(parcel);
            }
        }

        /*
         * Vrati vsetky parcely
         */
        public List<GeoEntity> GetAllParcels()
        {
            return Handler.SearchAll(GeoEntityType.Parcel);
        }

        /*
         * Vrati vsetky nehnutelnosti
         */
        public List<GeoEntity> GetAllProperties()
        {
            return Handler.SearchAll(GeoEntityType.Property);
        }

        /*
         * Vrati vsetky objekty
         */
        public List<GeoEntity> GetAllEntities()
        {
            return Handler.SearchAll();
        }

        /*
         * Ulozi vsetky objekty do suboru
         */
        public void SaveToFile(string path)
        {
            var allItems = Handler.SearchAll();

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var item in allItems)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        /*
         * Nacita vsetky objekty zo suboru
         */
        public void LoadFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(';'); // "{Type};{Number};{Description};{Point1};{Point2}"

                    var type = values[0] == "Parcel" ? GeoEntityType.Parcel : GeoEntityType.Property;
                    var number = int.Parse(values[1]);
                    var description = values[2];
                    var point1 = values[3].Split('~');
                    var point2 = values[4].Split('~');

                    var lat1 = double.Parse(point1[0]);
                    var latCoord1 = point1[1].First();
                    var long1 = double.Parse(point1[2]);
                    var longCoord1 = point1[3].First();
                    var lat2 = double.Parse(point2[0]);
                    var latCoord2 = point2[1].First();
                    var long2 = double.Parse(point2[2]);
                    var longCoord2 = point2[3].First();

                    if (type == GeoEntityType.Parcel)
                        AddParcel(number, description, lat1, latCoord1, long1, longCoord1, lat2, latCoord2, long2, longCoord2);
                    else
                        AddProperty(number, description, lat1, latCoord1, long1, longCoord1, lat2, latCoord2, long2, longCoord2);
                }
            }
        }
    }
}
