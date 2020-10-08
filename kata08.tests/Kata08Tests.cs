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
            var finder = new FixedSizeAnagramFinder(@"C:\Users\Etienne\Documents\GitHub\codekatas\wordlist.txt", 6);
            
            foreach (string w in finder.Find())
            {
                Console.WriteLine(w);
            }
        }
    }
}
