using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandedEnglish
{
    public class Expander : IExpander
    {
        private Dictionary<string, string> _conversions = new Dictionary<string,string>();

        public string Expand(string sentenceToExpand)
        {
            var sb = new StringBuilder();
            var words = sentenceToExpand.Split();

            foreach (var word in words)
            {
                sb.Append(ExpandWord(word));
                sb.Append(' ');
            }

            return sb.ToString().Trim();
        }

        private void GetConversions()
        {

        }

        private string ExpandWord(string word)
        {
            bool isCap = !string.IsNullOrWhiteSpace(word) && char.IsUpper(word, 0);
            var wordLower = word.ToLower();

            foreach (var conversion in _conversions)
            {
                if (wordLower.Contains(conversion.Key.ToLower()))
                {
                    wordLower.Replace(conversion.Key.ToLower(), conversion.Value);

                    if (isCap)
                        wordLower = wordLower.First().ToString().ToUpper() + wordLower.Substring(1);

                    return wordLower;
                }
            }

            return word;
        }
    }
}
