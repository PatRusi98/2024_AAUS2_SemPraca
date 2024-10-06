using AAUS2_SemPraca.Objects;
using AAUS2_SemPraca.Struct;
using AAUS2_SemPraca.Utils;

namespace AAUS2_SemPraca
{
    public class SemProject
    {
        private static SemProject? _instance = null;
        private Generator DataGenerator { get; }
        private KDTree<Parcel, double> TreeParcel { get; } = new();
        private KDTree<Property, double> TreeProperty { get; } = new();

        /*
         * Privatny konstruktor pre semestralny projekt
         */
        private SemProject()
        {
            DataGenerator = Generator.GetInstance();
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
        public List<Property> SearchAllPropertiesInLocation(GPSLocation location)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 2: Vyhladanie parciel
         */
        public List<Parcel> SearchAllParcelsInLocation(GPSLocation location)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 3: Vyhladanie vsetkych objektov
         */
        public List<GeoEntity> SearchAllObjectsInLocation(GPSLocation location)
        {
            throw new NotImplementedException();
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
                                    gps2
                                );

            TreeProperty.Insert(propertyToAdd, propertyToAdd.LowerLeft);
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
                                    gps2
                                );

            TreeParcel.Insert(parcelToAdd, parcelToAdd.LowerLeft);
        }

        /*
         * Operacia 6: Editacia nehnutelnosti
         */
        public bool EditProperty(GPSLocation location)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 7: Editacia parcely
         */
        public bool EditParcel(GPSLocation location)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 8: Vyradenie nehnutelnosti
         */
        public bool DeleteProperty(GPSLocation location)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 9: Vyradenie parcely
         */
        public bool DeleteParcel(GPSLocation location)
        {
            throw new NotImplementedException();
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
                // TODO: najst vsetky parcely v oblasti a pridat ich do zoznamu
                TreeProperty.Insert((Property)propertyToAdd, propertyToAdd.LowerLeft);
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
                // TODO: najst vsetky nehnutelnosti v oblasti a pridat ich do zoznamu
                TreeParcel.Insert((Parcel)parcelToAdd, parcelToAdd.LowerLeft);
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
                {
                    // TODO: najst vsetky parcely v oblasti a pridat ich do zoznamu
                    TreeProperty.Insert(property, property.LowerLeft);
                }
                else if (entityToAdd is Parcel parcel)
                {
                    // TODO: najst vsetky nehnutelnosti v oblasti a pridat ich do zoznamu
                    TreeParcel.Insert(parcel, parcel.LowerLeft);
                }
            }
        }
    }
}
