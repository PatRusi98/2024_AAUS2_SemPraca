namespace AAUS2_SemPraca.Struct
{
    public class KDTreeFactory : ITreeFactory<IStorable>
    {
        private static KDTreeFactory instance;
        private KDTreeFactory() { }
        public static KDTreeFactory Instance()
        {
            if (instance == null)
            {
                instance = new KDTreeFactory();
            }
            return instance;
        }

        public ITree<T> CreateTree<T>() where T : IStorable
        {
            return new KDTree<T>();
        }
    }
}