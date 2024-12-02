using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Tester
{
    public class TestFinalEntity(int testValue1, int testValue2, string primKey) : IStorable
    {
        private readonly int Key1 = testValue1;
        private readonly int Key2 = testValue2;
        private string PrimaryKey = primKey;

        public object[] GetKeys()
        {
            return [Key1, Key2];
        }

        public static bool operator == (TestFinalEntity? left, TestFinalEntity? right)
        {
            return Equals(left!, right);
        }

        public static bool operator != (TestFinalEntity? left, TestFinalEntity? right)
        {
            return !Equals(left!, right!);
        }

        public override bool Equals(object? obj)
        {
            if (obj is TestFinalEntity other)
            {
                if (other == null)
                    return false;

                return Key1 == other.Key1 && Key2 == other.Key2;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Key1.GetHashCode() ^ Key2.GetHashCode();
        }

        public override string ToString()
        {
            return Key1 + " " + Key2;
        }
    }
}
