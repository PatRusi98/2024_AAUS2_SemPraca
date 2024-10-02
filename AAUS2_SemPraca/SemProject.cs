using AAUS2_SemPraca.Objects;

namespace AAUS2_SemPraca
{
    public class SemProject
    {
        private static SemProject? _instance;

        /*
         * Privatny konstruktor pre semestralny projekt
         */
        private SemProject()
        {

        }

        /*
         * Vrati instanciu semestralneho projektu, zarucuje jednu instanciu (navrhovy vzor singleton)
         */
        public static SemProject Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new();
                }
                return _instance;
            }
        }

        /*
         * Operacia 1: Vyhladanie nehnutelnosti
         */
        public List<Estate> SearchAllEstatesInLocation(GPSLocation location)
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
        public List<Area> SearchAllObjectsInLocation(GPSLocation location)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 4: Pridanie nehnutelnosti
         */
        public bool AddEstate(Estate estate)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 5: Pridanie parcely
         */
        public bool AddParcel(Parcel parcel)
        {
            throw new NotImplementedException();
        }

        /*
         * Operacia 6: Editacia nehnutelnosti
         */
        public bool EditEstate(GPSLocation location)
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
        public bool DeleteEstate(GPSLocation location)
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
    }
}
