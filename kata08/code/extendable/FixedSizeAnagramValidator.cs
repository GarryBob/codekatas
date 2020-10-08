using System;

namespace codekatas.kata08.extendable
{
    public class FixedSizeAnagramValidator : IAnagramValidator
    {
        public int AnagramSize { get; private set; }

        public FixedSizeAnagramValidator(int anagramSize) => this.AnagramSize = anagramSize;

        public bool CanBeConstituent(string word)
        {
            return !String.IsNullOrEmpty(word) && word.Length < AnagramSize;
        }

        public bool CanBeAnagram(string word)
        {
            return !String.IsNullOrEmpty(word) && word.Length == AnagramSize;
        }
    }
}