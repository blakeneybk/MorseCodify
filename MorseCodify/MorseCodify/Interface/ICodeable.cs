using System.Collections.Generic;

namespace MorseCodify.Interface
{
    interface ICodeable
    {
        string Encode(string input, Dictionary<char, string> codex);
    }
}
