using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Tester
{
    public class TestEntity4Dim(ABKey key1, int key2, double key3, BCKey key4) : IStorable
    {
        private ABKey Key1 { get; set; } = key1;
        private int Key2 { get; set; } = key2;
        private double Key3 { get; set; } = key3;
        private BCKey Key4 { get; set; } = key4;

        public object[] GetKeys()
        {
            return [Key1, Key2, Key3, Key4];
        }

        public static bool operator ==(TestEntity4Dim? left, TestEntity4Dim? right)
        {
            return Equals(left!, right);
        }

        public static bool operator !=(TestEntity4Dim? left, TestEntity4Dim? right)
        {
            return !Equals(left!, right!);
        }

        public override bool Equals(object? obj)
        {
            if (obj is TestEntity4Dim other)
            {
                if (other == null)
                    return false;

                return Key1 == other.Key1 && Key2 == other.Key2 && Key3 == other.Key3 && Key4 == other.Key4;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Key1.GetHashCode() ^ Key2.GetHashCode() ^ Key3.GetHashCode() ^ Key4.GetHashCode();
        }
    }
}