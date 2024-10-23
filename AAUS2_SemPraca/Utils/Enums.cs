using System.ComponentModel;

namespace AAUS2_SemPraca.Utils
{
    public static class Enums
    {
        public enum Coordinate : short
        {
            [Description("Unknown")]
            Unknown = -1,
            [Description("East")]
            East = 69,                                      // ASCII kod pre 'E'
            [Description("North")]
            North = 78,                                     // ASCII kod pre 'N'
            [Description("South")]
            South = 83,                                     // ASCII kod pre 'S'
            [Description("West")]
            West = 87                                       // ASCII kod pre 'W'
        }

        public enum GeoEntityType : short
        {
            [Description("Unknown")]
            Unknown = -1,
            [Description("Parcel")]
            Parcel = 0,
            [Description("Property")]
            Property = 1
        }

        public enum DebugCode : short
        {
            [Description("Stored duplicate key")]
            StoredDuplicate = -2,
            [Description("Successful operation")]
            Success = -1,
            [Description("Tree is empty")]
            EmptyTree = 0,
            [Description("Wrong key dimension")]
            WrongKeyDimension = 1,
            [Description("Parent node is null")]
            NullParent = 2,
            [Description("Unknown entity type")]
            UnknownEntity = 3,
            [Description("Unknown error")]
            Unknown = 99
        }
    }
}
