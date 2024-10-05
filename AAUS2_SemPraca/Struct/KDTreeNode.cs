namespace AAUS2_SemPraca.Struct
{

    public class KDTreeNode<T, K> where K : IComparable<K>
    {
        public T Value { get; }
        public K[] Key { get; }
        public KDTreeNode<T, K>? LeftSon { get; set; } = null;
        public KDTreeNode<T, K>? RightSon { get; set; } = null;

        public KDTreeNode(T value, K[] key)
        {
            Value = value;
            Key = key;
        }
    }
}
