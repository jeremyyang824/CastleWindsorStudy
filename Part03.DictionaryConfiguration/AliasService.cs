using System.Collections.Generic;

namespace Part03.DictionaryConfiguration
{
    public class AliasService
    {
        public Dictionary<string, string> Aliases { get; set; }

        public string Evaluate(string term)
        {
            if (Aliases == null)
                return term;

            while (Aliases.ContainsKey(term))
            {
                term = Aliases[term];
                break;
            }

            return term;
        }
    }
}
