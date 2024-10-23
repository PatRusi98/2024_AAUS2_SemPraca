namespace AAUS2_SemPraca.Struct
{

    public class KDTreeNode<T>(T value)
    {
        public T Value { get; } = value;
        public KDTreeNode<T>? LeftSon { get; set; } = null;
        public KDTreeNode<T>? RightSon { get; set; } = null;
        public List<KDTreeNode<T>> Duplicates { get; set; } = new();
    }
}
