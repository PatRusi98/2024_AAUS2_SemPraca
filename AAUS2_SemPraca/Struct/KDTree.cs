using AAUS2_SemPraca.Utils;

namespace AAUS2_SemPraca.Struct
{
    public class KDTree<T> where T : IMultiKey
    {
        private KDTreeNode<T>? Root = null;
        private int Dimensions = 0;

        public KDTree() { }

        public void Insert(T value)              // pozn.cvicenie: doplnit si vlastny komparator!!! Key1 neposielat, posielat objekt s komparatorom (T value)
        {
            if (Root == null)                                                                   // ak neexistuje root, vkladany prvok sa nim stane a dimenzia jeho kluca urci dimenziu stromu
            {
                Root = new(value);
                Dimensions = value.GetKeys().Length;
                return;
            }

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                throw new ArgumentException("Wrong key dimension!");

            KDTreeNode<T>? currNode = Root;                                                     // nastavim aktualny node na root, kedze prehladavam od korena
            KDTreeNode<T>? parentNode = null;
            bool isLeft = true;
            int depth = 0;

            while (currNode != null)                                                            // pokial sa nedostaneme do listu (nema syna)
            {
                parentNode = currNode;
                int axis = depth % Dimensions;                                                  // podla ktoreho kluca sa rozhodujem

                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) < 0)      // porovnanie klucov v danej dimenzii
                {
                    currNode = currNode.LeftSon;                                                //ak je kluc mensi, ideme cestou dolava
                    isLeft = true;
                }
                else
                {
                    currNode = currNode.RightSon;                                               //ak je kluc vacsi, ideme cestou doprava
                    isLeft = false;
                }

                depth++;
            }

            if (isLeft && parentNode != null)
                parentNode.LeftSon = new(value);
            else if (parentNode != null)
                parentNode.RightSon = new(value);
            else
                throw new InvalidOperationException("Parent node is null!");
        }

        public T? Search(T value)                                                               //bodove vyhladavanie na operacie s konkretymi prvkami
        {
            if (Root == null)                                                                   // ak neexistuje root, strom je prazdny
                return default;

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                throw new ArgumentException("Wrong key dimension!");

            KDTreeNode<T>? currNode = Root;                                                     // nastavim aktualny node na root, kedze prehladavam od korena
            int depth = 0;

            while (currNode != null)                                                            // pokial sa nedostaneme do listu (nema syna)
            {
                if (currNode.Value.GetKeys().SequenceEqual(value.GetKeys()))                    // ak sa kluc zhoduje s hladanym klucom, vrat prvok
                    return currNode.Value;

                int axis = depth % Dimensions;

                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) < 0)      // porovnanie klucov v danej dimenzii
                    currNode = currNode.LeftSon;                                                // ak je kluc mensi, ideme dolava
                else
                    currNode = currNode.RightSon;                                               // ak je kluc vacsi, ideme doprava

                depth++;
            }

            return default;
        }

        public void Delete(T value)
        {
            if (Root == null)                                                                   // ak je strom prazdny
                return;

            if (value.GetKeys().Length != Dimensions)                                           // kontrola dimenzii kluca
                throw new ArgumentException("Wrong key dimension!");

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

                if (value.GetKeys()[axis].CompareKeys(currNode.Value.GetKeys()[axis]) < 0)      // porovnanie klucov v danej dimenzii
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

            if (currNode == null)                                                               // ak sa prvok nenasiel, nemame co zmazat
                return;

            // ak je list, zmazat, nastavit v parentovi null
            // ak ma praveho syna, prehladat podstrom praveho syna a najst najmensi prvok, nahradit tymto prvkom hladany prvok a zmazat najdeny a potom cyklicky prehladavat az kym nenajdeme list
            // ak ma laveho syna, prehladat podstrom laveho syna a najst najvacsi prvok, nahradit tymto prvkom hladany prvok a zmazat najdeny a potom cyklicky prehladavat az kym nenajdeme list

            //if ()
            //{

            //    return;
            //}
            //else if ()
            //{

            //    return;
            //}
            //else if (currNode.LeftSon == null && currNode.RightSon == null)                     // ak je listom (nema synov)
            //{
            //    if (parentNode == null)                                                         // ak je mazany prvok root
            //        Root = null;
            //    else if (isLeft)                                                                // ak je mazany prvok lavy syn
            //        parentNode.LeftSon = null;
            //    else
            //        parentNode.RightSon = null;

            //    return;
            //}

            throw new ArgumentException("Something went wrong.");
        }
    }
}
