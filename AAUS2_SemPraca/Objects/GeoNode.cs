using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Objects
{
    public class GeoNode(double[] key) : IMultiKey
    {
        public GeoEntity? Value { get; set; } = null;
        public double[] KeyArr { get; } = key;

        public object[] GetKeys() => KeyArr.Cast<object>().ToArray();
    }
}
