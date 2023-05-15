using System.Collections;

namespace LeetCodeContest.Tests
{
    public sealed class Task3_test
    {
        [Theory, ClassData(typeof(Task3TestData))]
        public void Check(int inputData, int expected)
        {
            var solver = new Task3();
            var result = solver.Solve();

            Assert.Equal(expected, result);
        }
    }

    public sealed class Task3TestData : IEnumerable<object[]>
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
