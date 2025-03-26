
using System.Windows.Markup;

namespace NoIfsNoButs
{
    public class Comparator
    {
        static Dictionary<int, string> values = new Dictionary<int, string>
        {
            {0, "smaller than" },
            {1,  "equal to"},
            {2, "greater than" }
        };
        // values to array


        public static string Compare(int a, int b)
        {
            int compareResult = a.CompareTo(b) + 1;
            string result = $"{a} is {values[compareResult]} {b}";
            return result;
        }
    }
}