namespace AAUS2_SemPraca.Struct
{
    public class TreeManager<T>
    {
        private readonly ITree<T> _tree;

        public TreeManager(ITreeFactory<T> factory)
        {
            _tree = factory.CreateTree();
        }

        public bool Add(T item) => _tree.Insert(item);
        public List<T>? Find(T item) => _tree.Search(item);
        public bool Remove(T item) => _tree.Delete(item);
    }
}
