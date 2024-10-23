using AAUS2_SemPraca.Struct;

namespace AAUS2_SemPraca.Tester
{
    public class StructTester
    {
        private static StructTester? _instance;
        private readonly Random _random = new();
        private KDTree<TestEntity> TestTree { get; set; } = new();

        private StructTester() { }

        public static StructTester Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StructTester();
                }
                return _instance;
            }
        }

        public List<TestEntity> TestInsert(int numberOfEntities, bool clearTree = false)
        {
            if (clearTree)
                ClearTree();

            var inserted = new List<TestEntity>();

            for (int i = 0; i < numberOfEntities; i++)
            {
                var testValue1 = _random.NextDouble() * _random.Next(100);
                var testValue2 = _random.NextDouble() * _random.Next(100);

                TestTree.Insert(new TestEntity(testValue1, testValue2));
                inserted.Add(new TestEntity(testValue1, testValue2));
            }

            return inserted;
        }

        public bool TestSearch(List<TestEntity> entities, int numberOfIterations = 0)
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

        public bool TestDelete(List<TestEntity> entities, int numberOfIterations = 0)
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

        public bool CreateTestCase(int numberOfIterations, int insertProb, int searchProb, int deleteProb)
        {
            ClearTree();

            var combinedProb = insertProb + searchProb + deleteProb;
            double insert = insertProb / combinedProb;
            double search = searchProb / combinedProb;
            double delete = deleteProb / combinedProb;
            var searched = new List<TestEntity>();
            bool ok = true;

            for (int i = 0; i < numberOfIterations; i++)
            {
                var operation = _random.NextDouble();

                switch (operation)
                {
                    case var expression when operation < insert:
                        searched.Add(TestInsert(1)[0]);
                        break;
                    case var expression when operation < search:
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
        #endregion
    }
}
