namespace AAUS2_SemPraca.Struct
{

    public class KDTreeNode<T>
    {
        public T Value { get; }
        public KDTreeNode<T>? LeftSon { get; set; } = null;
        public KDTreeNode<T>? RightSon { get; set; } = null;

        public KDTreeNode(T value)
        {
            Value = value;
        }
    }
}
