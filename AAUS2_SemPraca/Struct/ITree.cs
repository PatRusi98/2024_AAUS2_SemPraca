﻿namespace AAUS2_SemPraca.Struct
{
    public interface ITree<T>
    {
        bool Insert(T record);
        List<T>? Search(T record);
        bool Delete(T record);
    }
}
