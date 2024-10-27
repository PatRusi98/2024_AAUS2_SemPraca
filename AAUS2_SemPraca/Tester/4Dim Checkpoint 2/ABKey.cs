namespace AAUS2_SemPraca.Tester
{
    public class ABKey(double a, string b) : IComparable
    {
        private double A { get; set; } = a;
        private string B { get; set; } = b;

        public int CompareTo(object? obj)
        {
            if (obj is ABKey other)
            {
                if (other == null)
                    return 1;

                int comp = A.CompareTo(other.A);
                if (comp != 0)
                    return comp;

                return B.CompareTo(other.B);
            }

            throw new ArgumentException("Compared object is not ABKey!");
        }

        public static bool operator ==(ABKey? left, ABKey? right)
        {
            return Equals(left!.A, right!.A) && Equals(left!.B, right!.B);
        }

        public static bool operator !=(ABKey? left, ABKey? right)
        {
            return !Equals(left!.A, right!.A) || !Equals(left!.B, right!.B);
        }

        public override bool Equals(object? obj)
        {
            if (obj is ABKey other)
            {
                if (other == null)
                    return false;

                return A == other.A && B == other.B;
            }

            return false;
        }

        public override int GetHashCode() 
        {
            return A.GetHashCode() ^ B.GetHashCode();
        }
    }
}
