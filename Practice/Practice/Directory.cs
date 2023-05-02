using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{

    public class FileSystem
    {
        public FileSystem()
        {
            RootDir = new Directory("root", "\\");
        }
        public Directory RootDir { get; set; }

    }
    public class Directory
    {
        public Directory(string name, string path) 
        {
            Name = name;
            RelativePath = path;
        }
        Dictionary<int ,File> Files { get; set; } // TODO: write method to add files to this prop.
        public String Name { get; set; }
        public String RelativePath { get; set; }
    }

    public class File
    {
        public object Data { get; set; }
        public String Name { get; set; }
        public string RelativePath { get; set; }
    }
}
