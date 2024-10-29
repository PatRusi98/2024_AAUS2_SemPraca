using AAUS2_SemPraca.Utils;
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
                Root = new(value, 0);
                Dimensions = value.GetKeys().Length;
                return (true, DebugCode.Success);
            }

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                return (false, DebugCode.WrongKeyDimension);

            KDTreeNode<T>? currNode = Root;                                                     // nastavim aktualny workingNode na localRoot, kedze prehladavam od korena
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
                        currNode.Duplicates.Add(new(value, depth, currNode.Parent));
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
                parentNode.LeftSon = new(value, depth, parentNode);
            else if (parentNode != null)
                parentNode.RightSon = new(value, depth, parentNode);
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

            KDTreeNode<T>? currNode = Root;                                                     // nastavim aktualny workingNode na localRoot, kedze prehladavam od korena
            int depth = 0;

            while (currNode != null)                                                            // pokial sa nedostaneme do listu (nema syna)
            {
                if (currNode.Value.GetKeys().SequenceEqual(value.GetKeys()))                    // ak sa kluc zhoduje s hladanym klucom, vloz prvok do listu
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

        public List<T>? GetAllItems(KDTreeNode<T>? root = null, bool includeDuplicates = false)
        {
            List<T> items = new();
            Stack<KDTreeNode<T>> stack = new();
            KDTreeNode<T>? currNode = null;

            if (root == null)
                currNode = Root;
            else
                currNode = root;

            while (currNode != null || stack.Count > 0)
            {
                while (currNode != null)                                                        // dostaneme sa co najviac dolava
                {
                    stack.Push(currNode);
                    currNode = currNode.LeftSon;
                }

                currNode = stack.Pop();                                                         
                items.Add(currNode.Value);

                if (includeDuplicates)                                                          // pridame duplikaty
                {
                    foreach (var duplicate in currNode.Duplicates)
                    {
                        items.Add(duplicate.Value);
                    }
                }

                currNode = currNode.RightSon;
            }

            return items;
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
            int axis = 0;
            int depth = 0;

            while (currNode != null)
            {
                axis = depth % Dimensions;
                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) == 0)         // ak sa kluce v danej dimenzii rovnaju
                {
                    var isDuplicateKey = true;
                    for (int i = 0; i < Dimensions; i++)
                    {
                        if (value.GetKeys()[i].CompareKeys(currNode.Value.GetKeys()[i]) != 0)
                        {
                            isDuplicateKey = false;
                            break;
                        }
                    }

                    if (isDuplicateKey)
                    {
                        var (deleted, breaked) = HandleDuplicateDelete(currNode, value, isLeft);

                        if (deleted) return (true, DebugCode.Success);
                        if (breaked) break;
                        if (!breaked && !deleted) return (false, DebugCode.Unknown);
                    }
                }

                parentNode = currNode;

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

            if (currNode?.LeftSon == null && currNode?.RightSon == null)                          // ak je listom
            {
                if (currNode == null)
                    Root = null;
                else if (isLeft)
                    parentNode!.LeftSon = null;
                else
                    parentNode!.RightSon = null;

                return (true, DebugCode.Success);
            }

            Stack<KDTreeNode<T>> needsToBeReplaced = new();
            needsToBeReplaced.Push(currNode);
            var foundLeaf = false;

            while (!foundLeaf)
            {
                KDTreeNode<T> workingNode = needsToBeReplaced.Peek();
                KDTreeNode<T>? nextWorkingNode = null;

                if (workingNode.LeftSon != null)
                    nextWorkingNode = GetMaxInorder(workingNode.LeftSon, workingNode.Depth);

                if (workingNode.RightSon != null && nextWorkingNode == null)
                    nextWorkingNode = GetMinInorder(workingNode.RightSon, workingNode.Depth);

                needsToBeReplaced.Push(nextWorkingNode!);

                if (nextWorkingNode?.LeftSon == null && nextWorkingNode?.RightSon == null)
                    foundLeaf = true;
            }

            var leaf = needsToBeReplaced.Pop();

            while (needsToBeReplaced.Count > 0)
            {
                var replacedByLeaf = needsToBeReplaced.Pop();
                HandleReplacing(replacedByLeaf, leaf);

                leaf = replacedByLeaf;
            }
            
            return (true, DebugCode.Success);
        }

        public (bool, DebugCode) DeleteAlternate(T value)
        {
            if (Root == null)                                                                   // ak je strom prazdny
                return (false, DebugCode.EmptyTree);

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                return (false, DebugCode.WrongKeyDimension);

            KDTreeNode<T>? currNode = Root;
            KDTreeNode<T>? parentNode = null;
            bool isLeft = true;
            int axis = 0;
            int depth = 0;

            while (currNode != null)
            {
                axis = depth % Dimensions;
                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) == 0)         // ak sa kluce v danej dimenzii rovnaju
                {
                    var isDuplicateKey = true;
                    for (int i = 0; i < Dimensions; i++)
                    {
                        if (value.GetKeys()[i].CompareKeys(currNode.Value.GetKeys()[i]) != 0)
                        {
                            isDuplicateKey = false;
                            break;
                        }
                    }

                    if (isDuplicateKey)
                    {
                        var (deleted, breaked) = HandleDuplicateDelete(currNode, value, isLeft);

                        if (deleted) return (true, DebugCode.Success);
                        if (breaked) break;
                        if (!breaked && !deleted) return (false, DebugCode.Unknown);
                    }
                }

                parentNode = currNode;

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

            if (currNode?.LeftSon == null && currNode?.RightSon == null)                          // ak je listom
            {
                if (currNode == null)
                    Root = null;
                else if (isLeft)
                    parentNode!.LeftSon = null;
                else
                    parentNode!.RightSon = null;

                return (true, DebugCode.Success);
            }

            List<T> itemsUnderDeleted = new();

            if (currNode?.LeftSon != null)
            {
                itemsUnderDeleted = GetAllItems(currNode.LeftSon, true);
            }
            else
            {
                itemsUnderDeleted = GetAllItems(currNode?.RightSon, true);
            }

            return (false, DebugCode.Unknown);
        }// nedokoncene

        #region private
        private KDTreeNode<T> GetMaxInorder(KDTreeNode<T> localRoot, int parentDepth)
        {
            Stack<KDTreeNode<T>> stack = new();
            KDTreeNode<T> currNode = localRoot;
            KDTreeNode<T> max = currNode;
            var keyPosition = parentDepth % Dimensions;

            while (currNode != null || stack.Count > 0)
            {
                while (currNode != null)
                {
                    if (max == null)
                        max = currNode;
                    else if (currNode.Value.GetKeys()[keyPosition].CompareKeys(max.Value.GetKeys()[keyPosition]) >= 0)
                        max = currNode;

                    stack.Push(currNode);
                    currNode = currNode.LeftSon!;
                }

                currNode = stack.Pop();

                if (max == null)
                    max = currNode;
                else if (currNode.Value.GetKeys()[keyPosition].CompareKeys(max.Value.GetKeys()[keyPosition]) >= 0)
                    max = currNode;

                currNode = currNode.RightSon!;
            }

            return max;
        }

        private KDTreeNode<T> GetMinInorder(KDTreeNode<T> localRoot, int parentDepth)
        {
            Stack<KDTreeNode<T>> stack = new();
            KDTreeNode<T> currNode = localRoot;
            KDTreeNode<T> min = currNode;
            var keyPosition = parentDepth % Dimensions;

            while (currNode != null || stack.Count > 0)
            {
                while (currNode != null)
                {
                    if (currNode.Value.GetKeys()[keyPosition].CompareKeys(min.Value.GetKeys()[keyPosition]) <= 0)
                        min = currNode;

                    stack.Push(currNode);
                    currNode = currNode.LeftSon!;
                }

                currNode = stack.Pop();

                currNode = currNode.RightSon!;
            }

            return min;
        }

        private (bool, bool) HandleDuplicateDelete(KDTreeNode<T> currNode, T value, bool isLeft)
        {
            if (currNode.Duplicates.Count > 0)                                              // kontrola duplikatov
            {
                if (currNode.Value.Equals(value))                                           // ak sa kluc zhoduje s hlavnym workingNode, vyberieme prvy duplikat a nahradime ho nim
                {
                    var newHeadNode = currNode.Duplicates[0];
                    newHeadNode.LeftSon = currNode.LeftSon;
                    newHeadNode.RightSon = currNode.RightSon;
                    newHeadNode.Duplicates = currNode.Duplicates;
                    newHeadNode.Duplicates.RemoveAt(0);

                    if (currNode.Parent == null)
                        Root = newHeadNode;
                    else if (isLeft)
                        currNode.Parent.LeftSon = newHeadNode;
                    else
                        currNode.Parent.RightSon = newHeadNode;

                    currNode = null;                                                        // zmazeme povodny workingNode

                    return (true, false);
                }

                foreach (var item in currNode.Duplicates)
                {
                    if (item.Value.Equals(value))                                       // ak v liste duplikatov najdeme hladany prvok, zmazeme ho z neho
                    {
                        currNode.Duplicates.Remove(item);
                        return (true, false);
                    }
                }

                return (false, false);
            }
            else if (currNode.Value.Equals(value))                                      // ak nema duplikaty a rovna sa, vyskocime z while a pokracujeme
            {
                return (false, true);
            }
            else
            {
                return (false, false);
            }
        }

        private void HandleReplacing(KDTreeNode<T> oldNode, KDTreeNode<T> newNode)
        {
            if (newNode.Parent != null)                                                 // odstranenie syna z parenta
            {
                if (newNode.Parent.LeftSon == newNode)
                    newNode.Parent.LeftSon = null;
                else
                    newNode.Parent.RightSon = null;
            }

            newNode.Parent = oldNode.Parent;
            newNode.LeftSon = oldNode.LeftSon;                                           
            newNode.RightSon = oldNode.RightSon;
            newNode.Depth = oldNode.Depth;

            if (oldNode.Parent != null)
            {
                if (oldNode.Parent.LeftSon == oldNode)
                    oldNode.Parent.LeftSon = newNode;
                else
                    oldNode.Parent.RightSon = newNode;
            }
            else
            {
                Root = newNode;
            }

            if (oldNode.LeftSon != null)                                            // odlinkovanie synov a priradenie noveho parenta
            {
                oldNode.LeftSon.Parent = newNode;
                oldNode.LeftSon = null;
            }

            if (oldNode.RightSon != null)
            {
                oldNode.RightSon.Parent = newNode;
                oldNode.RightSon = null;
            }
        }
        #endregion
    }
}
