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
            PathClass newPath = GetFilePath();
            CopyFile(newPath);
        }
        //test
        //    C:\Intel\Test.txt

        private static void CopyFile(PathClass newPath)
        {
            string targetPath;
            targetPath = @"C:\Intel\";
            Guid guid = Guid.NewGuid();
            newPath.guid = guid;
            string srcFile = newPath.path;
            string destFile = targetPath + guid;
            File.Copy(srcFile, destFile);
        }

        public static PathClass  GetFilePath()
        {
            PathClass newPath = new PathClass();
            Console.WriteLine("Write file path");          
            path = Console.ReadLine();                
            extension = Path.GetExtension(path);        
            string curPath = path;
            if (File.Exists(curPath))
            {                     
                newPath.path = path;
                newPath.extension = extension;
                newPath.fileName = Path.GetFileName(path);
            }
            else
            {
                Console.WriteLine("Write correct path");
                GetFilePath();
            }
            return newPath;
        }
    }
}
