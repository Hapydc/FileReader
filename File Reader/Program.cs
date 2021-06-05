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
            Console.WriteLine(newPath.path+newPath.extension);
            ReadFile(newPath);          
        }     

        public static void  GetFilePath(pathClass newPath)
        {                      
                Console.WriteLine("Write file path");          
                path = Console.ReadLine();                
                extension = Path.GetExtension(path);
                path = path.Substring(0, path.IndexOf("."));
                string curFile = path + extension;
            if (File.Exists(curFile))
            {              
                newPath.extension = extension;
                newPath.path = path;
            }
            else
            {
                GetFilePath(newPath);
            }
        }
        private static void ReadFile(pathClass putanja)
        {           
               //string[] lines = System.IO.File.ReadAllLines(putanja.path+putanja.extension);
               //Console.WriteLine(lines);                        
        }
    }
}
