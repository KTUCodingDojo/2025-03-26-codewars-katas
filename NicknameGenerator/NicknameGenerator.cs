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

        public string GenerateNickname(string nickname)
        {
            if (nickname.Length < 4) return "Error: Name too short";

            var is3rdLetterVowel = vowels.Contains(nickname.ElementAt(2));
            if (is3rdLetterVowel)
            {
                return nickname.Substring(0, 4);
            }

            return nickname.Substring(0, 3);
        }
    }
}
