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
    }
}
