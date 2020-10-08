using System;
using System.IO;
using System.Linq;
using Xunit;

namespace codekatas.kata06
{
    public class Kata06Tests
    {
        // This is mostly a copy paste of an answer found in the kata's comments.
        // Intent was to get started quickly and have a first working xunit.
        [Fact]
        public void ProcessingWordListForAnagrams_Finds20683()
        {
            int count = File.ReadAllLines(@"c:\Users\Etienne\projects\codekatas\wordlist.txt")
                .GroupBy(w => String.Concat(w.OrderBy(c => c)))
                .Where(g => g.Count() > 1)
                // .ToList().ForEach(g => Console.WriteLine(String.Join(" ", g)));
                .Count();

            Assert.Equal(20683, count);
        }
    }
}
