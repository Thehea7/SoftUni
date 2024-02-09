using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            //string reportFileName = @"..\..\..\report.txt";
            string reportFileName = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);

            Dictionary<string, List<FileInfo>> report = new();

            StringBuilder fullReport = new StringBuilder();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;


                if (!report.ContainsKey(extension))
                {
                    report.Add(extension, new List<FileInfo>());
                }
                report[extension].Add(fileInfo);
            }

            foreach (var (extension, list) in report.OrderByDescending(x => x.Value.Count)
                                                          .ThenBy(x => x.Key))
            {
                fullReport.AppendLine(extension);
                foreach (var file in list.OrderBy(x => x.Length))
                {
                    fullReport.AppendLine($"--{file.Name} - {file.Length / 1024.0:f3}kb");
                }
            }

            return fullReport.ToString();
        }


        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            File.WriteAllText(reportFileName, textContent);
        }
    }
}
