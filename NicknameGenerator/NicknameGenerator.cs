using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicknameGenerator
{
    public class NicknameGenerator
    {
        private static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        private static readonly Dictionary<bool, Func<string, string>> dict = new Dictionary<bool, Func<string, string>>();

        public NicknameGenerator() 
        {
            dict[true] = x => x.Substring(0, 4);
            dict[false] = x => x.Substring(0, 3);
        }

        public string GenerateNickname(string nickname)
        {
            if (nickname.Length < 4) return "Error: Name too short";

            var is3rdLetterVowel = vowels.Contains(nickname.ElementAt(2));
            return dict[is3rdLetterVowel](nickname);
        }
    }
}
