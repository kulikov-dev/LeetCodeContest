using System.Collections;

namespace LeetCodeContest.Tests
{
    public sealed class Task1_test
    {
        [Theory, ClassData(typeof(Task1TestData))]
        public void Check(int inputData, int expected)
        {
            var solver = new Task1();
            var result = solver.Solve();

            Assert.Equal(expected, result);
        }
    }

    public sealed class Task1TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                1,
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
