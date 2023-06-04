using System.Collections;

namespace LeetCodeContest.Tests
{
    public sealed class Task2_test
    {
        [Theory, ClassData(typeof(Task2TestData))]
        public void Check(int inputData, int expected)
        {
            var solver = new Task2();
            var result = solver.Solve(0);

            Assert.Equal(expected, result);
        }
    }

    public sealed class Task2TestData : IEnumerable<object[]>
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
