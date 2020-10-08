using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace codekatas.kata08.readable
{
    public class FixedSizeAnagramFinder
    {
        readonly string inputFilePath;
        readonly int anagramSize;

        public FixedSizeAnagramFinder(string inputFilePath, int anagramSize)
        {
            this.inputFilePath = inputFilePath;
            this.anagramSize = anagramSize;
        }

        // Ugly but you know exactly what's going on at first read! :-)
        public IEnumerable<string> Find()
        {
            string[] allWords = File.ReadAllLines(inputFilePath);

            var smallWords = allWords.Where(w => w.Length < anagramSize);

            var anagramSizedWords = allWords.Where(w => w.Length == anagramSize);

            var reference = new HashSet<string>(anagramSizedWords, StringComparer.OrdinalIgnoreCase);

            foreach (string smallWord1 in smallWords)
            {
                foreach (string smallWord2 in smallWords)
                {
                    string anagram = smallWord1 + smallWord2;

                    if (anagram.Length == anagramSize && reference.Contains(anagram))
                    {
                        yield return anagram;
                    }
                }
            }
        }
    }
}
