using System;

namespace CCapi
{
    public static class Extensions
    {
        const StringComparison comp = StringComparison.OrdinalIgnoreCase;
        public static bool CaselessEq(this string a, string b) { return a.Equals(b, comp); }
    }
}
