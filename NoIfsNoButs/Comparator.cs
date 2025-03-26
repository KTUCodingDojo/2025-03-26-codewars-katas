
using System.Windows.Markup;

namespace NoIfsNoButs
{
    public class Comparator
    {
        static Dictionary<int, string> values = new Dictionary<int, string>
        {
            {0, " is smaller than " },
            {1,  " is equal to "},
            {2, " is greater than " }
        };
        public static string Compare(int a, int b)
        {
            int compareResult = a.CompareTo(b) + 1;
            string result = a + values[compareResult] + b;
            return result;
        }
    }
}