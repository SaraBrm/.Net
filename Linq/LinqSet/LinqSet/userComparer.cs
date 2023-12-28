using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LinqSet
{
    public class userComparer : IEqualityComparer<User>
    {
        public bool Equals([AllowNull] User x, [AllowNull] User y)
        {
            if (x.Name == y.Name)
                return true;
            return false;
        }

        public int GetHashCode([DisallowNull] User obj)
        {
            return obj.Name.GetHashCode();
        }
    }

}
