using System.Collections.Generic;

namespace codekatas.kata08.extendable
{
    public interface IAnagramValidator
    {
        bool CanBeConstituent(string word);

        bool CanBeAnagram(string word);
    }
}