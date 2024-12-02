namespace AAUS2_SemPraca.Struct
{
    public class KDTreeFactory<T> : ITreeFactory<T> where T : IStorable
    {
        public ITree<T> CreateTree() => new KDTree<T>();
    }
}
