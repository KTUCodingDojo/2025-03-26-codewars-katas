using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicknameGenerator
{
    public class NicknameGenerator
    {
        public NicknameGenerator() 
        {
            
        }

        public string GenerateNickname(string nickname)
        {
            if (nickname.Length < 4) return "Error: Name too short";

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(nickname.ElementAt(2)))
            {
                return nickname.Substring(0, 4);
            }

            return nickname.Substring(0, 3);
        }
    }
}
