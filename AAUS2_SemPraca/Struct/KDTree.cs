using AAUS2_SemPraca.Utils;
using System.Collections.Generic;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Struct
{
    public class KDTree<T> where T : IMultiKey
    {
        private KDTreeNode<T>? Root = null;
        private int Dimensions = 0;

        public KDTree() { }

        public (bool, DebugCode) Insert(T value)              // pozn.cvicenie: doplnit si vlastny komparator!!! Key1 neposielat, posielat objekt s komparatorom (T value)
        {
            if (Root == null)                                                                   // ak neexistuje localRoot, vkladany prvok sa nim stane a dimenzia jeho kluca urci dimenziu stromu
            {
                Root = new(value);
                Dimensions = value.GetKeys().Length;
                return (true, DebugCode.Success);
            }

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                return (false, DebugCode.WrongKeyDimension);

            KDTreeNode<T>? currNode = Root;                                                     // nastavim aktualny node na localRoot, kedze prehladavam od korena
            KDTreeNode<T>? parentNode = null;
            bool isLeft = true;
            int depth = 0;

            while (currNode != null)                                                            // pokial sa nedostaneme do listu (nema syna)
            {
                parentNode = currNode;
                int axis = depth % Dimensions;                                                  // podla ktoreho kluca sa rozhodujem

                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) == 0)
                {
                    var isDuplicate = true;
                    for (int i = 0; i < Dimensions; i++)
                    {
                        if (value.GetKeys()[i].CompareKeys(currNode.Value.GetKeys()[i]) != 0)
                        {
                            isDuplicate = false;
                            break;
                        }
                    }

                    if (isDuplicate)
                    {
                        currNode.Duplicates.Add(new(value));
                        return (true, DebugCode.StoredDuplicate);
                    }
                }

                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) <= 0)      // porovnanie klucov v danej dimenzii
                {
                    currNode = currNode.LeftSon;                                                // ak je kluc mensi, ideme cestou dolava
                    isLeft = true;
                }
                else
                {
                    currNode = currNode.RightSon;                                               // ak je kluc vacsi, ideme cestou doprava
                    isLeft = false;
                }

                depth++;
            }

            if (isLeft && parentNode != null)
                parentNode.LeftSon = new(value);
            else if (parentNode != null)
                parentNode.RightSon = new(value);
            else
                return (false, DebugCode.NullParent);

            return (true, DebugCode.Success);
        }

        public List<T>? Search(T value)                                                         // bodove vyhladavanie na operacie s konkretymi prvkami
        {
            if (Root == null)                                                                   // ak neexistuje localRoot, strom je prazdny
                return default;

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                throw new ArgumentException("Wrong key dimension!");

            List<T>? found = new();

            KDTreeNode<T>? currNode = Root;                                                     // nastavim aktualny node na localRoot, kedze prehladavam od korena
            int depth = 0;

            while (currNode != null)                                                            // pokial sa nedostaneme do listu (nema syna)
            {
                if (currNode.Value.GetKeys().SequenceEqual(value.GetKeys()))                    // ak sa kluc zhoduje s hladanym klucom, vrat prvok
                {
                    found.Add(currNode.Value);

                    if (currNode.Duplicates.Count > 0)                                          // ak obsahuje duplikaty
                    {
                        foreach (var item in currNode.Duplicates)               
                        {
                            found.Add(item.Value);                                              // pridaj duplikaty do zoznamu najdenych
                        }
                    }

                    return found;
                }

                int axis = depth % Dimensions;

                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) <= 0)     // porovnanie klucov v danej dimenzii
                    currNode = currNode.LeftSon;                                                // ak je kluc mensi, ideme dolava
                else
                    currNode = currNode.RightSon;                                               // ak je kluc vacsi, ideme doprava

                depth++;
            }

            return found;
        }

        public List<T>? GetAllItems()
        {
            //TODO: inorder prehladanie celeho stromu 
            return new();
        }

        public (bool, DebugCode) Delete(T value)
        {
            if (Root == null)                                                                   // ak je strom prazdny
                return (false, DebugCode.EmptyTree);

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                return (false, DebugCode.WrongKeyDimension);

            KDTreeNode<T>? currNode = Root;
            KDTreeNode<T>? parentNode = null;
            bool isLeft = true;
            int depth = 0;

            while (currNode != null)
            {
                if (currNode.Value.Equals(value))                                               // ak sa kluc zhoduje s hladanym klucom, neprehladavame dalej
                    break;

                parentNode = currNode;
                int axis = depth % Dimensions;

                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) <= 0)     // porovnanie klucov v danej dimenzii
                {
                    currNode = currNode.LeftSon;
                    isLeft = true;
                }
                else
                {
                    currNode = currNode.RightSon;
                    isLeft = false;
                }

                depth++;
            }

            //TODO
            if (currNode == null)                                                               // ak sa prvok nenasiel, nemame co zmazat
                return(false, DebugCode.Unknown);

            if (currNode.LeftSon == null && currNode.RightSon == null)                          // ak je listom (nema synov)
            {
                if (parentNode == null)                                                         // ak je mazany prvok localRoot
                    Root = null;
                else if (isLeft)                                                                // ak je mazany prvok lavy syn
                    parentNode.LeftSon = null;
                else
                    parentNode.RightSon = null;

                //TODO
                return (false, DebugCode.Unknown);
            }

            return (false, DebugCode.Unknown);
        }

        #region private
        private (KDTreeNode<T>, bool) GetMinimum(KDTreeNode<T> localRoot, int localRootDepth, int keyPosition)
        {
            KDTreeNode<T>? min = null;
            KDTreeNode<T>? currNode = localRoot;
            int depth = localRootDepth;
            var isLeaf = false;

            while (currNode != null)
            {
                if(min == null)
                    min = currNode;

                if (currNode.LeftSon == null && currNode.RightSon == null)                                              // ak sme sa dostali do listu
                {
                    if (currNode.Value.GetKeys()[keyPosition].CompareKeys(min.Value.GetKeys()[keyPosition]) <= 0)       // ak je kluc na hladanej pozicii mensi alebo rovny ako min
                        min = currNode;                                                                                 // nastav aktualny ako minimum

                    isLeaf = true;
                    return (min, isLeaf);
                }

                int axis = depth % Dimensions;
                var hasLeft = currNode.LeftSon != null;
                var hasRight = currNode.RightSon != null;
                var hasBoth = (hasLeft && hasRight);

                if (depth == keyPosition)
                {
                    min = currNode.LeftSon;
                    currNode = currNode.LeftSon;
                }
                else
                {
                    
                }
                
            }

            return (min!, isLeaf);
        }

        private (KDTreeNode<T>, bool) GetMaximum(KDTreeNode<T> localRoot, int keyPosition)
        {
            KDTreeNode<T>? max = null;
            KDTreeNode<T>? currNode = localRoot;
            int depth = keyPosition;
            var isLeaf = false;

            while (currNode != null)
            {
                if(max == null)
                    max = currNode;
            }

            return(max!, isLeaf);
        }
        #endregion
    }
}
