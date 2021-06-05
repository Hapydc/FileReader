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
            CreateFileAndWrite(ReadFile(path));

        }
        private static void GetFileName(pathClass newPath)
        {
            throw new NotImplementedException();
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
                GetFilePath(newPath);
            }
        }
        private static string GetFileName(string path)
        {
            Console.WriteLine(Path.GetFileName(path ));
            return Path.GetFileName(path );
        }
        private static string ReadFile(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }
        private static void CreateFileAndWrite(string v)
        {
            StreamWriter sw = new StreamWriter("C:\\Intel\\Test1.txt");
            sw.Write(v);
            sw.Close();
            Console.WriteLine(v);

        }



    }
}
