using System.Collections.Generic;

namespace MorseCodify.Interface
{
    interface ICodeable
    {
        //An interface for testability if needed.
        string Encode(string input, Dictionary<char, string> codex);
    }
}
