using System.Collections.Generic;
using System.IO;

namespace codekatas.kata08.extendable
{
    public class FileBasedWordListProvider : IWordListProvider
    {
        public string inputFilePath { get; private set; }

        public FileBasedWordListProvider(string inputFilePath) => this.inputFilePath = inputFilePath;

        public IEnumerable<string> GetWordList()
        {
            return File.ReadAllLines(inputFilePath);

            // TODO: Read large files by chunks
        }
    }
}