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
            pathClass newPath = new pathClass();
            GetFilePath(newPath);
            TransferFile(newPath);

        }
        //test
        //    C:\Intel\Test.txt

        private static void TransferFile(pathClass newPath)
        {
            string targetPath;
            Console.WriteLine("Write target path");
            string fileName = GetFileName(newPath.path);
            targetPath = Console.ReadLine();
            Console.WriteLine("Write new file name");
            string newFile = Console.ReadLine();
            if (File.Exists(targetPath+newFile))
            {
                Console.WriteLine("That name alredy exists,write another one"); 
                newFile= Console.ReadLine();
            }
            else
            {
                string srcFile = Path.Combine(path);
                string destFile = Path.Combine(targetPath, newFile);
                File.Move(srcFile, destFile);
            }
        }

        public static void  GetFilePath(pathClass newPath)
        {                      
                Console.WriteLine("Write file path");          
                path = Console.ReadLine();                
                extension = Path.GetExtension(path);
                GetFileName(path);
         
            string curPath = path;
            if (File.Exists(curPath))
            {                             
                   newPath.extension = extension;
                   newPath.path = path;                        
            }
            else
            {
                Console.WriteLine("Write correct path");
                path = Console.ReadLine();
            }
        }
        private static string GetFileName(string path)
        {
            return Path.GetFileName(path );
        }



    }
}
