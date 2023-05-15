using System.Collections;

namespace LeetCodeContest.Tests
{
    public sealed class Task4_test
    {
        [Theory, ClassData(typeof(Task4TestData))]
        public void Check(int inputData, int expected)
        {
            var solver = new Task4();
            var result = solver.Solve();

            Assert.Equal(expected, result);
        }
    }

    public sealed class Task4TestData : IEnumerable<object[]>
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
