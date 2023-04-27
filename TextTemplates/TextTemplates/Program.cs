
using System;
using System.IO;

namespace TextTemplates
{
    internal class Program
    {

    //    public static void ReadAllLines(string path)
    //    {
    //        foreach (var line in File
    //            .ReadAllLines(path)
    //            .Select((value, i) => new { value, i }))
    //        {
    //           string className = line.value;
    //            string modulesPath = $@"C:\Users\Hp\source\repos\TextTemplates\TextTemplates\Modules/{className}.cs";
    //            FileStream fs = File.Create(modulesPath);
    //            fs.Close();
    //            string[] classStructure =
    //            {
    //                "namespace TextTemplates{",
    //                $"internal class {className}",
    //                "{}",
    //                "}"
    //            };
    //            File.WriteAllLines(modulesPath, classStructure);
    //        }

    //    }  
    //    public static void FileExistence()
    //    {
    //        string modulesPath = @"C:\\Users\\Hp\\source\\repos\\TextTemplates\\TextTemplates\\Modules/";
    //        DirectoryInfo di = new DirectoryInfo(modulesPath);
    //        FileInfo[] csFiles = di.GetFiles("*.cs");
    //        if (csFiles.Length > 0)
    //        {
    //            foreach (FileInfo fi in csFiles)
    //            {
    //                File.Delete(@$"C:\\Users\\Hp\\source\\repos\\TextTemplates\\TextTemplates\\Modules/{fi.Name}");
    //            }
    //        }
    //    }

       static void Main(string[] args)
      {
    //        string filePath = @"C:\Users\Hp\source\repos\TextTemplates\TextTemplates\classNames.txt";
    //        FileExistence();
    //        ReadAllLines(filePath);
           
        }
    }
}