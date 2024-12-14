using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Tester
{
    public class StructTester4Dim
    {
        private static StructTester4Dim? _instance;
        private readonly Random _random = new();
        private KDTree<TestEntity4Dim> TestTree { get; set; } = new();

        private StructTester4Dim() { }

        public static StructTester4Dim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StructTester4Dim();
                }
                return _instance;
            }
        }

        public List<TestEntity4Dim> TestInsert(int numberOfEntities, bool clearTree = false)
        {
            if (clearTree)
                ClearTree();

            var inserted = new List<TestEntity4Dim>();

            for (int i = 0; i < numberOfEntities; i++)
            {
                var a = _random.NextDouble() * _random.Next(100);
                var b = GetRandomString();
                var c = _random.Next(100);
                var d = _random.NextDouble() * _random.Next(100);

                var testEntity = new TestEntity4Dim(new ABKey(a, b), c, d, new BCKey(b, c));

                TestTree.Insert(testEntity);
                inserted.Add(testEntity);
            }

            return inserted;
        }

        public bool TestSearch(List<TestEntity4Dim> entities, int numberOfIterations = 0)
        {
            if (entities.Count < 1)
                return true;

            var internalList = entities;
            if (numberOfIterations == 0)
                numberOfIterations = internalList.Count;

            for (int i = 0; i < numberOfIterations; i++)
            {
                var entityToSearch = internalList[_random.Next(internalList.Count)];
                var found = TestTree.Search(entityToSearch);
                if (found == null)
                    return false;
                internalList.Remove(entityToSearch);
            }

            return true;
        }

        public bool TestDelete(List<TestEntity4Dim> entities, int numberOfIterations = 0)
        {
            if (entities.Count < 1)
                return true;

            var internalList = entities;
            if (numberOfIterations == 0)
                numberOfIterations = internalList.Count;

            for (int i = 0; i < numberOfIterations; i++)
            {
                var entityToDelete = internalList[_random.Next(internalList.Count)];
                TestTree.Delete(entityToDelete);
                internalList.Remove(entityToDelete);

                if (TestTree.Search(entityToDelete) != null)
                    return false;
            }

            return true;
        }

        public bool CreateTestCase(int numberOfIterations, double insertProb, double searchProb, double deleteProb)
        {
            ClearTree();

            var combinedProb = insertProb + searchProb + deleteProb;
            double insert = insertProb / combinedProb;
            double search = searchProb / combinedProb;
            double delete = deleteProb / combinedProb;
            var searched = new List<TestEntity4Dim>();
            bool ok = true;

            for (int i = 0; i < numberOfIterations; i++)
            {
                var operation = _random.NextDouble();

                switch (operation)
                {
                    case var expression when operation < insert:
                        searched.Add(TestInsert(1)[0]);
                        break;
                    case var expression when operation < insert + search:
                        ok = TestSearch(searched, 1);
                        if (!ok)
                            return false;
                        break;
                    case var expression when operation > search:
                        ok = TestDelete(searched, 1);
                        if (!ok)
                            return false;
                        break;
                    default:
                        throw new ArgumentException("Something went wrong in CreateTestCase!");
                }
            }

            return ok;
        }

        #region private

        private void ClearTree()
        {
            TestTree = new();
        }

        private string GetRandomString()
        {
            string[] strArray = ["tree", "dimensions", "struct"];

            return strArray[_random.Next(strArray.Length)];
        }
        #endregion
    }
}