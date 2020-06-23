using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace Generic
{
    class EmployeeComparer : IEqualityComparer<Employee>,IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return String.Compare(x.Name, y.Name);
        }

        public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
