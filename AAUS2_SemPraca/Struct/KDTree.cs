namespace AAUS2_SemPraca.Struct
{
    public class KDTree<T, K> where K : IComparable<K>
    {
        private KDTreeNode<T, K>? Root = null;
        private int Dimensions = 0;

        public KDTree() 
        {

        }

        public void Insert(T value, K[] key)
        {
            if (Root == null)                                           // ak neexistuje root, vkladany prvok sa nim stane a dimenzia jeho kluca urci dimenziu stromu
            {
                Root = new(value, key);
                Dimensions = key.Length;

                return;
            }

            if (key.Length != Dimensions)                               // kontrola dimenzii kluca
                throw new ArgumentException("Wrong key dimension!");

            KDTreeNode<T, K>? currNode = Root;                          // nastavim aktualny node na root, kedze prehladavam od korena
            KDTreeNode<T, K>? parentNode = null;
            bool isLeft = true;
            int depth = 0;

            while (currNode != null)                                    // pokial sa nedostaneme do listu (nema syna)
            {
                parentNode = currNode;
                int axis = depth % Dimensions;

                if (key[axis].CompareTo(currNode.Key[axis]) < 0)        // porovnanie klucov v danej dimenzii
                {
                    currNode = currNode.LeftSon;                        //ak je kluc mensi, ideme cestou dolava
                    isLeft = true;
                }
                else
                {
                    currNode = currNode.RightSon;                       //ak je kluc vacsi, ideme cestou doprava
                    isLeft = false;
                }

                depth++;
            }

            if (isLeft && parentNode != null)
                parentNode.LeftSon = new(value, key);
            else if (parentNode != null)
                parentNode.RightSon = new(value, key);
            else
                throw new InvalidOperationException("Parent node is null!");
        }

        public List<T> RangeSearch(K[] target, Func<T, bool> condition)
        {
            if (Root == null)                                           // ak neexistuje root, strom je prazdny, vrat prazdny zoznam
                return new();

            if (target.Length != Dimensions)                            // kontrola dimenzii kluca
                throw new ArgumentException("Wrong key dimension!");

            // TODO: implementacia vyhladavania v oblasti
            throw new NotImplementedException();
        }

        public void Delete(K[] key) 
        {
            var nodeToDelete = Search(key);                             // najdem prvok ktory chcem vymazat

            if (nodeToDelete == null)                                   // ak sa prvok nenasiel tak skonci
                return;

            //TODO: implementacia delete
            throw new NotImplementedException();
        }

        #region private
        private T? Search(K[] key)                                      //bodove vyhladavanie na operacie s konkretymi prvkami
        {
            if (Root == null)                                           // ak neexistuje root, strom je prazdny
                return default;

            if (key.Length != Dimensions)                               // kontrola dimenzii kluca
                throw new ArgumentException("Wrong key dimension!");

            KDTreeNode<T, K>? currNode = Root;                          // nastavim aktualny node na root, kedze prehladavam od korena
            int depth = 0;

            while (currNode != null)                                    // pokial sa nedostaneme do listu (nema syna)
            {
                if (currNode.Key.SequenceEqual(key))                    // ak sa kluc zhoduje s hladanym klucom, vrat prvok
                    return currNode.Value;

                int axis = depth % Dimensions;

                if (key[axis].CompareTo(currNode.Key[axis]) < 0)        // porovnanie klucov v danej dimenzii
                    currNode = currNode.LeftSon;                        //ak je kluc mensi, ideme dolava
                else
                    currNode = currNode.RightSon;                       //ak je kluc vacsi, ideme doprava

                depth++;
            }

            return default;
        }

        #endregion
    }
}
