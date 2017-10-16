using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using MorseCodify.Interface;

namespace MorseCodify.Service
{
    class MorseCoder:ICodeable
    {
        public string Encode(string input, Dictionary<char, string> codex)
        {
            StringBuilder s = new StringBuilder();
            foreach (var letter in input)
            {
                //check to see if the character matches a key in the dictionary. If so, then append the associated value, if not, continue.
                //This skips characters that are not a part of the International Morse Code standard.
                if (codex.ContainsKey(letter))
                    s.Append(codex[letter]+" ");
            }
            return s.ToString().Trim();
        }
    }
}
