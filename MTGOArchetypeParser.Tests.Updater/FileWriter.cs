using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTGOArchetypeParser.Tests.Updater
{
    public static class FileWriter
    {
        public static void Write(string file, string contents)
        {
            string directory = Path.GetDirectoryName(file);
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
            File.WriteAllText(file, contents);
        }
    }
}
