using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Objects
{
    public class GeoNode(double[] key) : IMultiKey
    {
        public GeoEntity? Value { get; set; } = null;
        public double[] KeyArr { get; } = key;

        public object[] GetKeys() => KeyArr.Cast<object>().ToArray();

        public static bool operator == (GeoNode left, GeoNode right) 
        { 
            return Equals(left!.Value, right!.Value); 
        }

        public static bool operator != (GeoNode? left, GeoNode? right) 
        { 
            return !Equals(left!.Value, right!.Value); 
        }

        public override bool Equals(object obj)
        {
            if (obj is GeoNode other)
            {
                return Equals(Value, other.Value);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Value?.GetHashCode() ?? 0;
        }
    }
}
