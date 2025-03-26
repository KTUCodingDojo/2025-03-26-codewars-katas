
using System.Windows.Markup;

namespace NoIfsNoButs
{
    public class Comparator
    {
        private static string[] answers = { "smaller than", "equal to", "greater than" };

        public static string Compare(int a, int b)
        {
            int compareResult = a.CompareTo(b) + 1;
            string result = $"{a} is {answers[compareResult]} {b}";
            return result;
        }
    }
}