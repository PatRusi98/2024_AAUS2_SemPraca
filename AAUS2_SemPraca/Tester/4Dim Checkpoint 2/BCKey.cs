namespace AAUS2_SemPraca.Tester
{
    public class BCKey(string b, int c) : IComparable
    {
        private string B { get; set; } = b;
        private int C { get; set; } = c;

        public int CompareTo(object? obj)
        {
            if (obj is BCKey other)
            {
                if (other == null)
                    return 1;

                int comp = B.CompareTo(other.B);
                if (comp != 0)
                    return comp;

                return C.CompareTo(other.C);
            }

            throw new ArgumentException("Compared object is not BCKey!");
        }

        public static bool operator ==(BCKey? left, BCKey? right)
        {
            return Equals(left!.B, right!.B) && Equals(left!.C, right!.C);
        }

        public static bool operator !=(BCKey? left, BCKey? right)
        {
            return !Equals(left!.B, right!.B) || !Equals(left!.C, right!.C);
        }

        public override bool Equals(object? obj)
        {
            if (obj is BCKey other)
            {
                if (other == null)
                    return false;

                return B == other.B && C == other.C;
            }

            return false;
        }

        public override int GetHashCode() 
        {
            return B.GetHashCode() ^ C.GetHashCode();
        }
    }
}
