using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Combinatorics.Collections;

namespace codekatas.kata08.extendable
{
    public class AnagramFinder
    {
        public IWordListProvider WordListProvider { get; private set; }
        public IAnagramValidator AnagramValidator { get; private set; }

        public AnagramFinder(IWordListProvider wordListProvider,
            IAnagramValidator anagramValidator)
        {
            this.WordListProvider = wordListProvider;
            this.AnagramValidator = anagramValidator;
        }

        // Ugly but you know exactly what's going on at first read! :-)
        public IEnumerable<string> Find()
        {
            var allWords = WordListProvider.GetWordList();

            var reference = new HashSet<string>(allWords.Where(w => AnagramValidator.CanBeAnagram(w)), StringComparer.OrdinalIgnoreCase);

            var combinations = new Combinations<string>(allWords.Where(w => AnagramValidator.CanBeConstituent(w)), 2, GenerateOption.WithRepetition);

            foreach (var combo in combinations)
            {
                string anagram = string.Join("", combo);

                if (AnagramValidator.CanBeAnagram(anagram) && reference.Contains(anagram))
                {
                    yield return anagram;
                }
            }
        }
    }
}
