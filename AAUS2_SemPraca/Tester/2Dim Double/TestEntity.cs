using AAUS2_SemPraca.Objects;
using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Tester
{
    public class TestEntity(double testValue1, double testValue2) : IMultiKey
    {
        private readonly double Key1 = testValue1;
        private readonly double Key2 = testValue2;

        public object[] GetKeys()
        {
            return [Key1, Key2];
        }

        public static bool operator == (TestEntity? left, TestEntity? right)
        {
            return Equals(left!, right);
        }

        public static bool operator != (TestEntity? left, TestEntity? right)
        {
            return !Equals(left!, right!);
        }

        public override bool Equals(object? obj)
        {
            if (obj is TestEntity other)
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
    }
}
