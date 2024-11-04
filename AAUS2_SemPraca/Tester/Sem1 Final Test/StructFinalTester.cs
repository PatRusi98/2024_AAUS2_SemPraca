using AAUS2_SemPraca.Struct;
using System.Diagnostics;

namespace AAUS2_SemPraca.Tester
{
    public class StructFinalTester
    {
        private readonly Random _random;
        private readonly Random _seedGen = new();
        private KDTree<TestFinalEntity> TestTree { get; set; } = new();
        public List<TestFinalEntity> TestEntities { get; private set; } = new();

        public StructFinalTester() {
            var seed = _seedGen.Next();
            _random = new Random(seed);
            Debug.WriteLine("Seed: " + seed);
        }

        public void TestInsert(int numberOfEntities = 1, bool clearTree = false)
        {
            if (clearTree)
                ClearTree();

            if (numberOfEntities < 1)
                return;

            for (int i = 0; i < numberOfEntities; i++)
            {
                var testValue1 = _random.Next(50);
                var testValue2 = _random.Next(50);

                TestTree.Insert(new TestFinalEntity(testValue1, testValue2, GenerateRandomString()));
                TestEntities.Add(new TestFinalEntity(testValue1, testValue2, GenerateRandomString()));
            }
        }

        public void TestDelete(int numberOfIterations = 1)
        {
            if (TestEntities.Count < 1)
                return;

            if (numberOfIterations < 1)
                return;

            for (int i = 0; i < numberOfIterations; i++)
            {
                var entityToDelete = TestEntities[_random.Next(TestEntities.Count)];
                //var entityToDelete = TestEntities[TestEntities.Count - 1];
                var (succ, message) = TestTree.Delete(entityToDelete);
                TestEntities.Remove(entityToDelete);
            }
        }

        public void Insert(List<int[]> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                var numbers = values[i];

                var testValue1 = numbers[0];
                var testValue2 = numbers[1];

                TestTree.Insert(new TestFinalEntity(testValue1, testValue2, GenerateRandomString()));
                TestEntities.Add(new TestFinalEntity(testValue1, testValue2, GenerateRandomString()));
            }
        }

        public void TestSearch(int numberOfIterations = 1)
        {
            if (TestEntities.Count < 1)
                return;

            if (numberOfIterations < 1)
                return;

            for (int i = 0; i < numberOfIterations; i++)
            {
                var entityToSearch = TestEntities[_random.Next(TestEntities.Count)];
                var found = TestTree.Search(entityToSearch);
            }
        }

        public void CreateTestCase(int numberOfIterations, int numberOfItemsToStart, double insertProb, double searchProb, double deleteProb)
        {
            ClearTree();
            TestEntities = new();

            var combinedProb = insertProb + searchProb + deleteProb;
            double insert = insertProb / combinedProb;
            double search = searchProb / combinedProb;
            double delete = deleteProb / combinedProb;
            string op = "";

            for (int i = 0; i < numberOfItemsToStart; i++)
            {
                TestInsert();
            }

            for (int i = 0; i < numberOfIterations; i++)
            {
                var operation = _random.NextDouble();

                switch (operation)
                {
                    case var expression when operation < insert:
                        op = "Insert";
                        TestInsert();
                        break;
                    case var expression when operation < insert + search:
                        op = "Search";
                        TestSearch();
                        break;
                    case var expression when operation > search:
                        op = "Delete";
                        TestDelete();
                        break;
                    default:
                        throw new ArgumentException("Something went wrong in CreateTestCase!");
                }

                Debug.WriteLine("Iteration " + i);
                Debug.WriteLine("Operation: " + op);
                Debug.WriteLine("Number of items in KD Tree: " + ItemsCountInTree());
                Debug.WriteLine("Number of items in List: " + TestEntities.Count);
                Debug.WriteLine("--------------------------------------");

                if (TestEntities.Count != ItemsCountInTree())
                    throw new ArgumentException("Rozny pocet");
            }
        }

        #region private

        private void ClearTree()
        {
            TestTree = new();
        }

        private string GenerateRandomString(int length = 10)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            char[] randomString = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomString[i] = alphabet[_random.Next(alphabet.Length)];
            }

            return new string(randomString);
        }

        private int ItemsCountInTree()
        { 
            var count = TestTree.GetAllItems()?.Count;
            return (int)(count == null ? 0 : count);
        }
        #endregion
    }
}
