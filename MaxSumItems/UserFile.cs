using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MaxSumItems
{
    public class UserFile
    {
        public string Path { private set; get; }

        public UserFile(string path)
        {
            Path = path;
        }

        public string[] Content()
        {
            string[] readText = File.ReadAllLines(Path);
            return readText;
        }

    }
}
