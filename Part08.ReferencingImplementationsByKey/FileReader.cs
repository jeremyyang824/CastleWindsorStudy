using System.IO;

namespace Part08.ReferencingImplementationsByKey
{
    public class FileReader
    {
        public string FileName { get; set; }

        public string ReadToEnd()
        {
            return File.ReadAllText(FileName);
        }
    }
}
