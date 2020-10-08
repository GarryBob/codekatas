using System;
using Xunit;
using codekatas.kata08.readable;

namespace codekatas.kata08.tests
{
    public class Kata08Tests
    {
        [Fact]
        public void Test1()
        {
            var finder = new FixedSizeAnagramFinder(@"c:\Users\Etienne\projects\codekatas\wordlist.txt", 6);
            
            foreach (string w in finder.Find())
            {
                Console.WriteLine(w);
            }
        }
    }
}