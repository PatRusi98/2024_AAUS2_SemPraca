using AAUS2_SemPraca.Struct;
using System.Xml;

namespace AAUS2_SemPraca.Tester
{
    public class StructTester
    {
        private static StructTester _instance;
        private Random _random = new();
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

        public bool TestSearch(List<TestEntity> entities)
        {
            while (entities.Count > 0)
            {
                var entityToSearch = entities[_random.Next(entities.Count)];
                var found = TestTree.Search(entityToSearch);
                if (found == null) 
                    return false;
                entities.Remove(entityToSearch);
            }

            return true;
        }

        public bool TestDelete(List<TestEntity> entities)
        {
            while (entities.Count > 0)
            {
                var entityToDelete = entities[_random.Next(entities.Count)];
                TestTree.Delete(entityToDelete);
                entities.Remove(entityToDelete);

                if (TestTree.Search(entityToDelete) != null)
                    return false;
            }

            return true;
        }

        private void ClearTree()
        {
            TestTree = new();
        }
    }
}
