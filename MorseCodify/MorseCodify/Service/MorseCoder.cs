using System;
using System.Collections.Generic;
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
                s.Append(codex.ContainsKey(letter) ? codex[letter]+" " : String.Empty);
            }
            return s.ToString().Trim();
        }
    }
}
