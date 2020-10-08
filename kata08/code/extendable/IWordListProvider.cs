using System.Collections.Generic;

namespace codekatas.kata08.extendable
{
    public interface IWordListProvider
    {
        IEnumerable<string> GetWordList();
    }
}