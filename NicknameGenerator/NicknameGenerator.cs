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
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(nickname.ElementAt(3)))
            {
                return nickname.Substring(0, 3);
            }

            return nickname.Substring(0, 4);
        }
    }
}
