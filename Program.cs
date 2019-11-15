using System;
using System.IO;
using Microsoft.DotNet.Archive;

namespace unarchive
{
    class Program
    {
        static void Main(string[] args)
        {
            var archivePath = args[0];
            var extractionPath = args[1];

            Directory.CreateDirectory(extractionPath);

            var progress = new ConsoleProgressReport();
            var archive = new IndexedArchive();

            archive.Extract(archivePath, extractionPath, progress);
        }
    }
}
