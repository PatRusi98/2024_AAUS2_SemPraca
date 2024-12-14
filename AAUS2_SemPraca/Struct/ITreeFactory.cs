namespace AAUS2_SemPraca.Struct
{
    public interface ITreeFactory<TBase>
    {
        ITree<T> CreateTree<T>() where T : TBase;
    }
}