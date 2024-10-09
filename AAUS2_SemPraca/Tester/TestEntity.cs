using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Tester
{
    public class TestEntity : IMultiKey
    {
        private double Key1;
        private double Key2;

        public TestEntity(double testValue1, double testValue2) 
        {
            Key1 = testValue1;
            Key2 = testValue2;
        }

        public object[] GetKeys()
        {
            return [Key1, Key2];
        }
    }
}
