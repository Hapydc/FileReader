using System;
using System.IO;

namespace File_Reader
{
    class Program
    {
        public static string path;
        public static string extension;
        static void Main(string[] args)
        {
            GetFilePath();
            ReadFile(path);          
        }     

        private static void GetFilePath()
        {
            Console.WriteLine("Write file path");
            path = Console.ReadLine();
            Console.WriteLine(path);           
            extension = Path.GetExtension(path);
            Console.WriteLine(extension);
        }
        private static void ReadFile(string path)
        {
            
        }
    }
}
