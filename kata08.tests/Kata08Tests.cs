using System;
using System.Linq;
using Xunit;
using codekatas.kata08.readable;
using codekatas.kata08.extendable;

namespace codekatas.kata08.tests
{
    public class Kata08Tests
    {
        [Fact]
        public void ProcessingWordListFor6LettersAnagrams_FindsSome()
        {
            var readableFinder = new FixedSizeAnagramFinder(@"C:\Users\Etienne\Documents\GitHub\codekatas\wordlist.txt", 6);
            int count1 = readableFinder.Find().Count();

            Assert.NotEqual(0, count1);

            var extendableFinder = new AnagramFinder(
                new FileBasedWordListProvider(@"C:\Users\Etienne\Documents\GitHub\codekatas\wordlist.txt"),
                new FixedSizeAnagramValidator(6)
                // TODO: Inject find algo...
            );
            int count2 = extendableFinder.Find().Count();

            Assert.Equal(count1, count2);
        }
    }
}
