using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp.TestData
{
    public class MemberCalssData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 11, 3, 14 };
            yield return new object[] { 3, 2, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
