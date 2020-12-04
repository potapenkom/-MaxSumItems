using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MaxSumItems
{
    public class PathWrapper : IPathWrapper
    {
        private string _path;
        private string _extension;

        public PathWrapper(string path)
        {
            _path = path;
        }
        public bool PathExists()
        {
            _extension = Path.GetExtension(_path);
            return File.Exists(_path) && _extension == ".txt";
        }

    }
}
