using System;

namespace TablePull
{
    public static class Program
    {
        public const string Version = "1.0.0";

        public static int Main(string[] args)
        {
            const string app = "table-pull";
            if (args.Length == 0)
            {
                Console.WriteLine(app + " v" + Version + " - Free, open-source table extractor for Windows PDFs and scans to CSV or Excel with a grid fixer. 100 MB portable, offline, MIT.");
                Console.WriteLine();
                Console.WriteLine("Usage: " + app + ".exe [--help] [--version] [--status] [--run]");
                Console.WriteLine("Portable build, MIT licensed.");
                return 0;
            }

            switch (args[0])
            {
                case "--version":
                    Console.WriteLine(app + " v" + Version);
                    return 0;
                case "--status":
                    Console.WriteLine(app + " v" + Version + " - environment check");
                    Console.WriteLine("  OS   : " + Environment.OSVersion);
                    Console.WriteLine("  Arch : " + (Environment.Is64BitOperatingSystem ? "x64" : "x86"));
                    return 0;
                case "--run":
                    Console.WriteLine(app + " v" + Version + " starting...");
                    Console.WriteLine("Ready. Press Ctrl+C to exit.");
                    try { Console.ReadKey(); } catch { }
                    return 0;
                default:
                    Console.WriteLine("Unknown option: " + args[0] + " - try --help");
                    return 1;
            }
        }
    }
}