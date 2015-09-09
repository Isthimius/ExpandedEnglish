using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandedEnglish
{
    public interface IExpander
    {
        string Expand(string sentenceToExpand);
    }
}
